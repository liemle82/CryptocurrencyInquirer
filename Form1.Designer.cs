namespace CryptocurrencyInquirer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.priceInquireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newsInquireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ccTickerTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCryptocurrencyInquiry = new System.Windows.Forms.Button();
            this.AddCyrptocurrencyInquiryGrpBx = new System.Windows.Forms.GroupBox();
            this.GrpBxCryptocurrencyWatchlist = new System.Windows.Forms.GroupBox();
            this.CryptocurrencyWatchListLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCryptocurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.AddCyrptocurrencyInquiryGrpBx.SuspendLayout();
            this.GrpBxCryptocurrencyWatchlist.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Cryptocurrency Inquirer";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceInquireToolStripMenuItem,
            this.newsInquireToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 70);
            // 
            // priceInquireToolStripMenuItem
            // 
            this.priceInquireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.priceInquireToolStripMenuItem.Name = "priceInquireToolStripMenuItem";
            this.priceInquireToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.priceInquireToolStripMenuItem.Text = "Price Inquire";
            this.priceInquireToolStripMenuItem.Click += new System.EventHandler(this.priceInquireToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.addToolStripMenuItem.Text = "Add...";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // newsInquireToolStripMenuItem
            // 
            this.newsInquireToolStripMenuItem.Name = "newsInquireToolStripMenuItem";
            this.newsInquireToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newsInquireToolStripMenuItem.Text = "News Inquire";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ccTickerTbx
            // 
            this.ccTickerTbx.Location = new System.Drawing.Point(129, 21);
            this.ccTickerTbx.Name = "ccTickerTbx";
            this.ccTickerTbx.Size = new System.Drawing.Size(31, 20);
            this.ccTickerTbx.TabIndex = 1;
            this.ccTickerTbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cryptocurrency Ticker:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddCryptocurrencyInquiry
            // 
            this.btnAddCryptocurrencyInquiry.Location = new System.Drawing.Point(166, 19);
            this.btnAddCryptocurrencyInquiry.Name = "btnAddCryptocurrencyInquiry";
            this.btnAddCryptocurrencyInquiry.Size = new System.Drawing.Size(75, 23);
            this.btnAddCryptocurrencyInquiry.TabIndex = 3;
            this.btnAddCryptocurrencyInquiry.Text = "Add";
            this.btnAddCryptocurrencyInquiry.UseVisualStyleBackColor = true;
            this.btnAddCryptocurrencyInquiry.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCyrptocurrencyInquiryGrpBx
            // 
            this.AddCyrptocurrencyInquiryGrpBx.Controls.Add(this.btnAddCryptocurrencyInquiry);
            this.AddCyrptocurrencyInquiryGrpBx.Controls.Add(this.ccTickerTbx);
            this.AddCyrptocurrencyInquiryGrpBx.Controls.Add(this.label1);
            this.AddCyrptocurrencyInquiryGrpBx.Location = new System.Drawing.Point(12, 27);
            this.AddCyrptocurrencyInquiryGrpBx.Name = "AddCyrptocurrencyInquiryGrpBx";
            this.AddCyrptocurrencyInquiryGrpBx.Size = new System.Drawing.Size(252, 55);
            this.AddCyrptocurrencyInquiryGrpBx.TabIndex = 4;
            this.AddCyrptocurrencyInquiryGrpBx.TabStop = false;
            this.AddCyrptocurrencyInquiryGrpBx.Text = "Add Cryptocurrency Inquiry";
            this.AddCyrptocurrencyInquiryGrpBx.Visible = false;
            // 
            // GrpBxCryptocurrencyWatchlist
            // 
            this.GrpBxCryptocurrencyWatchlist.Controls.Add(this.CryptocurrencyWatchListLabel);
            this.GrpBxCryptocurrencyWatchlist.Location = new System.Drawing.Point(12, 27);
            this.GrpBxCryptocurrencyWatchlist.Name = "GrpBxCryptocurrencyWatchlist";
            this.GrpBxCryptocurrencyWatchlist.Size = new System.Drawing.Size(200, 100);
            this.GrpBxCryptocurrencyWatchlist.TabIndex = 5;
            this.GrpBxCryptocurrencyWatchlist.TabStop = false;
            this.GrpBxCryptocurrencyWatchlist.Text = "Cryptocurrency Watchlist";
            // 
            // CryptocurrencyWatchListLabel
            // 
            this.CryptocurrencyWatchListLabel.AutoSize = true;
            this.CryptocurrencyWatchListLabel.Location = new System.Drawing.Point(3, 16);
            this.CryptocurrencyWatchListLabel.Name = "CryptocurrencyWatchListLabel";
            this.CryptocurrencyWatchListLabel.Size = new System.Drawing.Size(0, 13);
            this.CryptocurrencyWatchListLabel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCryptocurrencyToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // addCryptocurrencyToolStripMenuItem
            // 
            this.addCryptocurrencyToolStripMenuItem.Name = "addCryptocurrencyToolStripMenuItem";
            this.addCryptocurrencyToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addCryptocurrencyToolStripMenuItem.Text = "Add Cryptocurrency";
            this.addCryptocurrencyToolStripMenuItem.Click += new System.EventHandler(this.addCryptocurrencyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GrpBxCryptocurrencyWatchlist);
            this.Controls.Add(this.AddCyrptocurrencyInquiryGrpBx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cryptocurrency Inquirer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.AddCyrptocurrencyInquiryGrpBx.ResumeLayout(false);
            this.AddCyrptocurrencyInquiryGrpBx.PerformLayout();
            this.GrpBxCryptocurrencyWatchlist.ResumeLayout(false);
            this.GrpBxCryptocurrencyWatchlist.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem priceInquireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newsInquireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox ccTickerTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCryptocurrencyInquiry;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.GroupBox AddCyrptocurrencyInquiryGrpBx;
        private System.Windows.Forms.GroupBox GrpBxCryptocurrencyWatchlist;
        private System.Windows.Forms.Label CryptocurrencyWatchListLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCryptocurrencyToolStripMenuItem;
    }
}

