using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HitClients.Api;
using HitClients.Api.Types.Trading;
using HitClients.Types;
using WeifenLuo.WinFormsUI.Docking;

namespace HitClients.Forms
{
    public partial class TradeForm : DockContent
    {
        public Symbol Symbol;

        public TradeForm()
        {
            InitializeComponent();
        }

        private void TradeForm_Load(object sender, EventArgs e)
        {

        }

        private void TradeForm_Shown(object sender, EventArgs e)
        {
            foreach (var symbol in Program.MainForm.Symbols.Values.OrderBy(x=>x.Id))
            {
                cbSymbols.Items.Add(symbol);
            }
            cbSymbols.SelectedItem = Symbol;
            cbType.Items.Add(OrderTypeEnum.Market);
            cbType.Items.Add(OrderTypeEnum.Limit);
            cbType.SelectedIndex = 0;
        }


        public void Init(Symbol symbol)
        {
            Symbol = symbol;
        }


        private void btnSell_Click(object sender, EventArgs e)
        {
            var order = new Order();
            order.Symbol = cbSymbols.Text;
            order.Price = nmPrice.Value;
            order.Quantity = nmAmount.Value;
            order.Type = cbType.Text;
            order.Side = SideEnum.sell.ToString();
            var result = ApiProvider.CreateOrder(order);
            if (result != null)
            {
                lbStatus.Text = $"Order created - {result}";
            }
            else
            {
                lbStatus.Text = "Failed to create order";
            }
        }

        private void cbSymbols_SelectedIndexChanged(object sender, EventArgs e)
        {
            var symbol = cbSymbols.SelectedItem as Symbol;
            if (symbol != null)
            {
                nmPrice.Increment = symbol.TickSize;
                nmPrice.Minimum = symbol.TickSize;
                nmPrice.DecimalPlaces = BitConverter.GetBytes(decimal.GetBits(symbol.TickSize)[3])[2];
                if (symbol.Price > 0)
                {
                    nmPrice.Value = symbol.Price;
                }
                nmAmount.Increment = symbol.QuantityIncrement;
                nmAmount.Minimum = symbol.QuantityIncrement;
                nmAmount.DecimalPlaces = BitConverter.GetBytes(decimal.GetBits(symbol.QuantityIncrement)[3])[2]; ;
                nmAmount.Value = symbol.QuantityIncrement;
            }

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = (OrderTypeEnum)cbType.SelectedItem;
            nmPrice.Enabled = type == OrderTypeEnum.Limit;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var order = new Order();
            order.Symbol = cbSymbols.Text;
            order.Price = nmPrice.Value;
            order.Quantity = nmAmount.Value;
            order.Type = cbType.Text;
            order.Side = SideEnum.buy.ToString();
            var result = ApiProvider.CreateOrder(order);
            if (result != null)
            {
                lbStatus.Text = $"Order created - {result}";

            }
            else
            {
                lbStatus.Text = "Failed to create order";
            }
        }
    }
}
