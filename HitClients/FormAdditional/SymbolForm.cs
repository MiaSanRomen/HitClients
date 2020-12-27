using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HitClients.Api;
using HitClients.Api.Types.Trading;
using HitClients.Types;
using WeifenLuo.WinFormsUI.Docking;

namespace HitClients.FormControls
{
    public partial class SymbolForm : DockContent
    {
        public  List<Symbol> Symbols = new List<Symbol>(); 
        public QuoteCurrencyEnum QuoteCurrency = QuoteCurrencyEnum.USD;
        public SymbolForm()
        {
            InitializeComponent();
            SetupColumns();

            var extender = new VisualStudioToolStripExtender();
            extender.SetStyle(toolStrip1, VisualStudioToolStripExtender.VsVersion.Vs2015, new VS2015BlueTheme());
        }
        public void SetObject()
        {
            Symbols = Program.MainForm.Symbols.Values.Where(x => x.QuoteCurrency == QuoteCurrency.ToString()).ToList();
            listView.ClearObjects();
            listView.SetObjects(Symbols);
        }
        public void UpdateObject()
        {
            listView.UpdateObjects(Symbols);
        }

        private void SetupColumns()
        {
            NameColumn.AspectGetter = delegate(object x)
            {
                var s = x as Symbol;
                if (s != null)
                {
                    return s.BaseCurrency;
                }
                return null;
            };
            NameColumn.ImageGetter = delegate (object x)
            {
                var s = x as Symbol;
                if (s != null)
                {
                    switch (QuoteCurrency)
                    {
                        case QuoteCurrencyEnum.BTC:
                            return (int)ImageEnum.BTC;
                        case QuoteCurrencyEnum.ETH:
                            return (int)ImageEnum.ETH;
                        case QuoteCurrencyEnum.USD:
                            return (int)ImageEnum.USD;
                    }
                }
                return -1;
            };
            PriceColumn.AspectGetter = delegate(object x)
            {
                var s = x as Symbol;
                if (s != null)
                {
                    return s.Price;
                }
                return null;
            };
            ChangeColumn.AspectGetter = delegate(object x)
            {
                var s = x as Symbol;
                if (s != null)
                {
                    return $"{s.Change:n2}%";
                }
                return null;
            };
        }

        public void LoadTickers()
        {
            var tickers = ApiProvider.GetTickers();
            if (tickers != null)
            {
                foreach (var ticker in tickers)
                {
                    if (ticker.Open > 0)
                    {
                        if (Program.MainForm.Symbols.ContainsKey(ticker.Symbol))
                        {
                            var symbol = Program.MainForm.Symbols[ticker.Symbol];
                            symbol.Price = ticker.Last;
                            symbol.Change = (ticker.Last - ticker.Open)/ticker.Open*100;
                        }
                    }
                }
                UpdateObject();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadTickers();
        }

        private void SymbolControl_Load(object sender, EventArgs e)
        {
            SetObject();
        }

        private void timerTickers_Tick(object sender, EventArgs e)
        {
            LoadTickers();
        }

        private void listView_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if (e.ColumnIndex == ChangeColumn.Index)
            {
                var s = e.Model as Symbol;
                if (s != null)
                {
                    if (s.Change > 0)
                    {
                        e.SubItem.ForeColor = Color.Green;
                    }
                    else
                    {
                        e.SubItem.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            var symbol = listView.SelectedObject as Symbol;
            if (symbol != null)
            {
                Program.MainForm.OpenChart(symbol);
            }
        }

        private void btnETH_Click(object sender, EventArgs e)
        {
            QuoteCurrency = QuoteCurrencyEnum.ETH;
            SetObject();
        }

        private void btnBTC_Click(object sender, EventArgs e)
        {
            QuoteCurrency = QuoteCurrencyEnum.BTC;
            SetObject();
        }

        private void btnUSDT_Click(object sender, EventArgs e)
        {
            QuoteCurrency = QuoteCurrencyEnum.USD;
            SetObject();
        }

        private void miCreateOrder_Click(object sender, EventArgs e)
        {
            var symbol = listView.SelectedObject as Symbol;
            Program.MainForm.CreateOrder(symbol);
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            var symbol = listView.SelectedObject as Symbol;
            miCreateOrder.Enabled = symbol != null && ApiProvider.IsLogin;
        }

        private void SymbolForm_Shown(object sender, EventArgs e)
        {
            listView.SmallImageList = Program.MainForm.imageList;
            Program.MainForm.SymbolLoaded += MainForm_SymbolLoaded;
            SetObject();
        }

        private void MainForm_SymbolLoaded(object sender, EventArgs e)
        {
            SetObject();
        }

        private void SymbolForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainForm.SymbolLoaded -= MainForm_SymbolLoaded;
        }
    }
}
