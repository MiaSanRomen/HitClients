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
using WeifenLuo.WinFormsUI.Docking;

namespace HitClients.FormControls
{
    public partial class OrderForm : DockContent
    {
        public List<Order> Orders = new List<Order>();
        public OrderForm()
        {
            InitializeComponent();
            SetupColumns();

            var extender = new VisualStudioToolStripExtender();
            extender.SetStyle(toolStrip1, VisualStudioToolStripExtender.VsVersion.Vs2015, new VS2015BlueTheme());
        }

        public void SetObject()
        {
            listView.SetObjects(Orders);
        }
        public void UpdateObject()
        {
            listView.UpdateObjects(Orders);
        }
        private void SetupColumns()
        {
            CancelColumn.ImageGetter = delegate (object x)
            {
                var s = x as Order;
                if (s != null)
                {
                    return 0;
                }
                return -1;
            };
            NameColumn.AspectGetter = delegate (object x)
            {
                var s = x as Order;
                if (s != null)
                {
                    return s.Symbol;
                }
                return null;
            };
            SideColumn.AspectGetter = delegate (object x)
            {
                var s = x as Order;
                if (s != null)
                {
                    return s.Side;
                }
                return null;
            };
            PriceColumn.AspectGetter = delegate (object x)
            {
                var s = x as Order;
                if (s != null)
                {
                    return s.Price;
                }
                return null;
            };
            TimeColumn.AspectGetter = delegate (object x)
            {
                var s = x as Order;
                if (s != null)
                {
                    return s.CreatedAt.ToString("g");
                }
                return null;
            };
            AmountColumn.AspectGetter = delegate (object x)
            {
                var s = x as Order;
                if (s != null)
                {
                    return s.Quantity;
                }
                return null;
            };
        }

        public void Reload()
        {
            var orders = ApiProvider.GetOrders();
            if (orders != null)
            {
                Orders = orders;
                SetObject();

            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Reload();
        }

        private void SymbolForm_Shown(object sender, EventArgs e)
        {
            ApiProvider.LoginEvent += ApiProvider_LoginEvent;
        }

        private void ApiProvider_LoginEvent(object sender, EventArgs e)
        {
            timer.Enabled = ApiProvider.IsLogin;
        }

        private void SymbolForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ApiProvider.LoginEvent -= ApiProvider_LoginEvent;

        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void listView_CellClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            var order = listView.SelectedObject as Order;
            if (e.ColumnIndex == CancelColumn.Index && order != null)
            {

                var result = ApiProvider.CancelOrder(order);
                if (result != null)
                {
                    Reload();
                }
            }

        }
    }
}
