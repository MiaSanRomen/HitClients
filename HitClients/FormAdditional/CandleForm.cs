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
using System.Windows.Forms.DataVisualization.Charting;
using HitClients.Api.Types.Requests;
using HitClients.Api.Types.Trading;
using WeifenLuo.WinFormsUI.Docking;

namespace HitClients.FormControls
{
    public partial class CandleForm : DockContent
    {
        public Symbol Symbol;
        public CandleForm()
        {
            InitializeComponent();
            var extender = new VisualStudioToolStripExtender();
            extender.SetStyle(toolStrip1, VisualStudioToolStripExtender.VsVersion.Vs2015, new VS2015BlueTheme());
        }
        public void Init(Symbol symbol)
        {
            Text = symbol.Id;
            Symbol = symbol;
            var req = new CandleRequest();
            req.Symbol = symbol.Id;
            var candles = ApiProvider.GetCandles(req);
            if(candles == null) return;
            var serie = new Series();
            serie.Name = symbol.Id;
            serie.ChartType = SeriesChartType.Candlestick;
            serie.Color = Color.CornflowerBlue;
            chtSymbol.Series.Add(serie);
            foreach (var candle in candles)
            {
                serie.Points.AddXY(candle.Timestamp, candle.Min, candle.Max, candle.Open, candle.Close);
            }
            chtSymbol.ChartAreas[0].RecalculateAxesScale();
            chtSymbol.ChartAreas[0].AxisY.IsStartedFromZero = false;
        }
        private void CandleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainForm.CloseChart(Symbol);
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            miCreateOrder.Enabled = Symbol != null && ApiProvider.IsLogin;

        }

        private void miCreateOrder_Click(object sender, EventArgs e)
        {
            Program.MainForm.CreateOrder(Symbol);
        }
    }
}
