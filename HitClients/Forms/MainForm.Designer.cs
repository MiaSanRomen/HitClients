namespace HitClients.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.stMain = new System.Windows.Forms.StatusStrip();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSymbols = new System.Windows.Forms.ToolStripButton();
            this.btnBalance = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOrders = new System.Windows.Forms.ToolStripButton();
            this.btnTrade = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCreateOrder = new System.Windows.Forms.ToolStripButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // stMain
            // 
            this.stMain.Location = new System.Drawing.Point(0, 490);
            this.stMain.Name = "stMain";
            this.stMain.Size = new System.Drawing.Size(842, 22);
            this.stMain.TabIndex = 0;
            this.stMain.Text = "statusStrip1";
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogin,
            this.toolStripSeparator1,
            this.btnSymbols,
            this.btnBalance,
            this.toolStripSeparator2,
            this.btnOrders,
            this.btnTrade,
            this.toolStripSeparator3,
            this.btnCreateOrder});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(842, 25);
            this.tsMain.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLogin.Image = global::HitClients.Properties.Resources.key;
            this.btnLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(23, 22);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSymbols
            // 
            this.btnSymbols.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSymbols.Image = global::HitClients.Properties.Resources.feed;
            this.btnSymbols.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSymbols.Name = "btnSymbols";
            this.btnSymbols.Size = new System.Drawing.Size(23, 22);
            this.btnSymbols.Text = "Symbols";
            this.btnSymbols.Click += new System.EventHandler(this.btnSymbols_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBalance.Image = global::HitClients.Properties.Resources.coins;
            this.btnBalance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(23, 22);
            this.btnBalance.Text = "Balance";
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOrders
            // 
            this.btnOrders.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOrders.Image = global::HitClients.Properties.Resources.lightning;
            this.btnOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(23, 22);
            this.btnOrders.Text = "Orders";
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnTrade
            // 
            this.btnTrade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTrade.Image = global::HitClients.Properties.Resources.table_lightning;
            this.btnTrade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Size = new System.Drawing.Size(23, 22);
            this.btnTrade.Text = "Trades";
            this.btnTrade.Click += new System.EventHandler(this.btnTrade_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCreateOrder.Image = global::HitClients.Properties.Resources.lightning_add;
            this.btnCreateOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(23, 22);
            this.btnCreateOrder.Text = "Create order";
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "feed.png");
            this.imageList.Images.SetKeyName(1, "usdt16.png");
            this.imageList.Images.SetKeyName(2, "BTC16.png");
            this.imageList.Images.SetKeyName(3, "ETH16.png");
            this.imageList.Images.SetKeyName(4, "coin_single_gold.png");
            this.imageList.Images.SetKeyName(5, "coin_single_silver.png");
            this.imageList.Images.SetKeyName(6, "lightning.png");
            // 
            // dockPanel
            // 
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Location = new System.Drawing.Point(0, 25);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(842, 465);
            this.dockPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 512);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.stMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Hit Clients";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stMain;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton btnLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSymbols;
        private System.Windows.Forms.ToolStripButton btnBalance;
        private System.Windows.Forms.ToolStripButton btnOrders;
        private System.Windows.Forms.ToolStripButton btnTrade;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnCreateOrder;
        public System.Windows.Forms.ImageList imageList;
    }
}