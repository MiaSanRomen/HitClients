using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using HitClients.Api;
using HitClients.Api.Types.Requests;
using HitClients.Api.Types.Trading;
using HitClients.FormControls;
using HitClients.Helpers;
using HitClients.Types;
using WeifenLuo.WinFormsUI.Docking;

namespace HitClients.Forms
{
    public partial class MainForm : Form
    {
        private DeserializeDockContent dockContent;
        public BalanceForm FrmBalance = new BalanceForm();
        public SymbolForm FrmSymbol = new SymbolForm();
        public OrderForm FrmOrder = new OrderForm();
        public HistoryForm FrmHistory = new HistoryForm();
        public TradeForm FrmTrade = new TradeForm();
        public VS2015BlueTheme Theme = new VS2015BlueTheme();
        public Dictionary<string, Symbol> Symbols = new Dictionary<string, Symbol>();
        public Dictionary<string, CandleForm> Candles = new Dictionary<string, CandleForm>();
        public event EventHandler SymbolLoaded;
        public MainForm()
        {
            InitializeComponent();
            dockPanel.Theme = Theme;
            dockContent = GetContentFromPersistString;
            var extender = new VisualStudioToolStripExtender();
            extender.SetStyle(tsMain, VisualStudioToolStripExtender.VsVersion.Vs2015, Theme);
            extender.SetStyle(stMain, VisualStudioToolStripExtender.VsVersion.Vs2015, Theme);
        }

        public void Reload()
        {
            var symbols = ApiProvider.GetSymbols();
            if (symbols != null)
            {
                Program.MainForm.Symbols = symbols.OrderBy(x => x.BaseCurrency).ToDictionary(x => x.Id, x => x);
                OnSymbolLoaded();
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            if (!FrmOrder.IsHandleCreated)
            {
                FrmOrder = new OrderForm();
            }
            FrmOrder.Show(dockPanel, DockState.DockRight);

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            if (!FrmBalance.IsHandleCreated)
            {
                FrmBalance = new BalanceForm();
            }
            FrmBalance.Show(dockPanel, DockState.DockRight);
        }

        public void OpenChart(Symbol symbol)
        {
            if(!Candles.ContainsKey(symbol.Id))
            {
                var candle = new CandleForm();
                candle.Init(symbol);
                Candles.Add(symbol.Id, candle);
            }
            Candles[symbol.Id].Show(dockPanel, DockState.Document);

        }

        public void CloseChart(Symbol symbol)
        {
            if (Candles.ContainsKey(symbol.Id))
            {
                var tab = Candles[symbol.Id];
                Candles.Remove(symbol.Id);
               
            }
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            if (!FrmHistory.IsHandleCreated)
            {
                FrmHistory = new HistoryForm();
            }
            FrmHistory.Show(dockPanel, DockState.DockBottom);
        }

        

        private void btnSymbols_Click(object sender, EventArgs e)
        {
            if (!FrmSymbol.IsHandleCreated)
            {
                FrmSymbol = new SymbolForm();
            }
            FrmSymbol.Show(dockPanel, DockState.DockLeft);
        }

        //===========================================================================================

        private void LoadDockPanel()
        {
            var configFile = Path.Combine(FolderHelper.HitClientsPath, "DockPanel.xml");
            if (File.Exists(configFile))
            {
                dockPanel.LoadFromXml(configFile, dockContent);
            }
        }
        private void SaveDockPanel()
        {
            var configFile = Path.Combine(FolderHelper.HitClientsPath, "DockPanel.xml");
            dockPanel.SaveAsXml(configFile);
        }

        private DockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof (SymbolForm).ToString())
                return FrmSymbol;
            if (persistString == typeof(BalanceForm).ToString())
                return FrmBalance;
            if (persistString == typeof(HistoryForm).ToString())
                return FrmHistory;
            if (persistString == typeof(OrderForm).ToString())
                return FrmOrder;
            if (persistString == typeof(TradeForm).ToString())
                return FrmTrade;
            return null;
        }


        //===========================================================================================
        private void MainForm_Shown(object sender, EventArgs e)
        {
            var state = FormHelper.Load(GetType().Name);
            if (state != null)
            {
                Top = state.Top;
                Left = state.Left;
                Height = state.Height;
                Width = state.Width;
            }
            LoadDockPanel();
            Reload();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormState state = new FormState();
            state.Top = Top;
            state.Height = Height;
            state.Left = Left;
            state.Width = Width;
            FormHelper.Save(GetType().Name, state);
            SaveDockPanel();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrder();
        }
        //===========================================================================================
        public void CreateOrder()
        {
            if (!FrmTrade.IsHandleCreated)
            {
                FrmTrade = new TradeForm();
            }
            FrmTrade.Show(dockPanel, DockState.Float);
        }

        public void CreateOrder(Symbol symbol)
        {
            if (!FrmTrade.IsHandleCreated)
            {
                FrmTrade = new TradeForm();
            }
            FrmTrade.Show(dockPanel, DockState.Float);
            FrmTrade.Init(symbol);
        }

        protected virtual void OnSymbolLoaded()
        {
            SymbolLoaded?.Invoke(this, EventArgs.Empty);
        }
    }
}
