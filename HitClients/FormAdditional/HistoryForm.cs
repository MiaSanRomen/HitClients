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
    public partial class HistoryForm : DockContent
    {
        public List<Trade> Trades = new List<Trade>();
        public HistoryForm()
        {
            InitializeComponent();
            SetupColumns();

            var extender = new VisualStudioToolStripExtender();
            extender.SetStyle(toolStrip1, VisualStudioToolStripExtender.VsVersion.Vs2015, new VS2015BlueTheme());
        }
        
        public void SetObject()
        {
            listView.SetObjects(Trades);
        }
        public void UpdateObject()
        {
            listView.UpdateObjects(Trades);
        }

        private void SetupColumns()
        {
            NameColumn.AspectGetter = delegate (object x)
            {
                var s = x as Trade;
                if (s != null)
                {
                    return s.Symbol;
                }
                return null;
            };
            SideColumn.AspectGetter = delegate (object x)
            {
                var s = x as Trade;
                if (s != null)
                {
                    return s.Side;
                }
                return null;
            };
            PriceColumn.AspectGetter = delegate (object x)
            {
                var s = x as Trade;
                if (s != null)
                {
                    return s.Price;
                }
                return null;
            };
            TimeColumn.AspectGetter = delegate (object x)
            {
                var s = x as Trade;
                if (s != null)
                {
                    return s.Timestamp.ToString("g");
                }
                return null;
            };
            TimeColumn.ImageGetter = delegate (object x)
            {
                var s = x as Trade;
                if (s != null)
                {
                    return (int)ImageEnum.Order;
                }
                return -1;
            };
            AmountColumn.AspectGetter = delegate (object x)
            {
                var s = x as Trade;
                if (s != null)
                {
                    return s.Quantity;
                }
                return null;
            };
        }
        public void Reload()
        {
            var trades = ApiProvider.GetTradesHistory();
            if (trades != null)
            {
                Trades = trades;
                SetObject();

            }
        }

        private void tsReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void SymbolForm_Shown(object sender, EventArgs e)
        {
            ApiProvider.LoginEvent += ApiProvider_LoginEvent;
            listView.SmallImageList = Program.MainForm.imageList;
        }

        private void ApiProvider_LoginEvent(object sender, EventArgs e)
        {
            timer.Enabled = ApiProvider.IsLogin;
        }

        private void SymbolForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ApiProvider.LoginEvent -= ApiProvider_LoginEvent;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
