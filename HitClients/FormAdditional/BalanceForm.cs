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
    public partial class BalanceForm : DockContent
    {
        public Dictionary<string, Balance> Balances = new Dictionary<string, Balance>();
        public BalanceForm()
        {
            InitializeComponent();
            SetupColumns();
            var extender = new VisualStudioToolStripExtender();
            extender.SetStyle(tsBalance, VisualStudioToolStripExtender.VsVersion.Vs2015, new VS2015BlueTheme());
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }
        public void SetObject()
        {
            listView.SetObjects(Balances.Values);
        }
        public void UpdateObject()
        {
            listView.UpdateObjects(Balances.Values);
        }


        private void SetupColumns()
        {
            AvailiableColumn.AspectGetter = delegate (object x)
            {
                var s = x as Balance;
                if (s != null)
                {
                    return s.Available;
                }
                return null;
            };
            CurrencyColumn.AspectGetter = delegate (object x)
            {
                var s = x as Balance;
                if (s != null)
                {
                    return s.Currency;
                }
                return null;
            };
            CurrencyColumn.ImageGetter = delegate (object x)
            {
                var s = x as Balance;
                if (s != null)
                {
                    
                    return s.Available>0? (int)ImageEnum.CoinGold : (int)ImageEnum.CoinSilver;
                }
                return -1;
            };

        }
        public void Reload()
        {
            var balances = ApiProvider.GetBalance();
            if (balances != null)
            {
                Balances = balances.OrderByDescending(x=>x.Available).ToDictionary(x => x.Currency, x => x);
                SetObject();
            }
        }

        private void timerTickers_Tick(object sender, EventArgs e)
        {
            //LoadBalance();
        }

        private void BalanceForm_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void listView_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            var balance = e.Model as Balance;
            if (balance != null)
            {
                if (balance.Available > 0)
                {
                    e.Item.Font = new Font(e.Item.Font, FontStyle.Bold);
                }
            }
        }

        private void SymbolForm_Shown(object sender, EventArgs e)
        {
            ApiProvider.LoginEvent += ApiProvider_LoginEvent;
            listView.SmallImageList = Program.MainForm.imageList;

        }

        private void ApiProvider_LoginEvent(object sender, EventArgs e)
        {
            timer.Enabled = ApiProvider.IsLogin;
            Reload();
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
