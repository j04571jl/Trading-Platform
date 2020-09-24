namespace TradingPlatform
{
    partial class MainPage
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
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradingHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentTradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Availabletxt = new System.Windows.Forms.TextBox();
            this.ProfitLosstxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameedit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OpenStockViewbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UpdateFXbtn = new System.Windows.Forms.Button();
            this.OpenStockBuybtn = new System.Windows.Forms.Button();
            this.DeleteSecbtn = new System.Windows.Forms.Button();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.tradingPlatformDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Open = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviousClose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Change = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.securityPricesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradingPlatformDBDataSet = new TradingPlatform.TradingPlatformDBDataSet();
            this.securityPricesTableAdapter = new TradingPlatform.TradingPlatformDBDataSetTableAdapters.SecurityPricesTableAdapter();
            this.tableAdapterManager = new TradingPlatform.TradingPlatformDBDataSetTableAdapters.TableAdapterManager();
            this.tradingPlatformDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.symbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.securityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.askDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousCloseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mystockbtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingPlatformDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityPricesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingPlatformDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingPlatformDBDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Logoutbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Logoutbtn.Location = new System.Drawing.Point(1132, 678);
            this.Logoutbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(206, 42);
            this.Logoutbtn.TabIndex = 0;
            this.Logoutbtn.Text = "Log Out";
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1372, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.fileToolStripMenuItem.Text = "Menu";
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.LogOutToolStripMenuItem.Text = "Log Out";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tradeToolStripMenuItem,
            this.tradingHistoryToolStripMenuItem,
            this.currentTradesToolStripMenuItem,
            this.ordersToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // tradeToolStripMenuItem
            // 
            this.tradeToolStripMenuItem.Name = "tradeToolStripMenuItem";
            this.tradeToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.tradeToolStripMenuItem.Text = "Trade";
            // 
            // tradingHistoryToolStripMenuItem
            // 
            this.tradingHistoryToolStripMenuItem.Name = "tradingHistoryToolStripMenuItem";
            this.tradingHistoryToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.tradingHistoryToolStripMenuItem.Text = "Trading History";
            // 
            // currentTradesToolStripMenuItem
            // 
            this.currentTradesToolStripMenuItem.Name = "currentTradesToolStripMenuItem";
            this.currentTradesToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.currentTradesToolStripMenuItem.Text = "Current Trades";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withdrawToolStripMenuItem,
            this.depositToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.WithdrawToolStripMenuItem_Click);
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.DepositToolStripMenuItem_Click);
            // 
            // Availabletxt
            // 
            this.Availabletxt.Location = new System.Drawing.Point(752, 114);
            this.Availabletxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Availabletxt.Name = "Availabletxt";
            this.Availabletxt.ReadOnly = true;
            this.Availabletxt.Size = new System.Drawing.Size(188, 26);
            this.Availabletxt.TabIndex = 2;
            // 
            // ProfitLosstxt
            // 
            this.ProfitLosstxt.Location = new System.Drawing.Point(951, 114);
            this.ProfitLosstxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProfitLosstxt.Name = "ProfitLosstxt";
            this.ProfitLosstxt.ReadOnly = true;
            this.ProfitLosstxt.Size = new System.Drawing.Size(188, 26);
            this.ProfitLosstxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(747, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Available";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(946, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Profit/Loss";
            // 
            // usernameedit
            // 
            this.usernameedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usernameedit.Location = new System.Drawing.Point(291, 78);
            this.usernameedit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameedit.Name = "usernameedit";
            this.usernameedit.ReadOnly = true;
            this.usernameedit.Size = new System.Drawing.Size(188, 26);
            this.usernameedit.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(285, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username";
            // 
            // OpenStockViewbtn
            // 
            this.OpenStockViewbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenStockViewbtn.Location = new System.Drawing.Point(291, 542);
            this.OpenStockViewbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpenStockViewbtn.Name = "OpenStockViewbtn";
            this.OpenStockViewbtn.Size = new System.Drawing.Size(206, 42);
            this.OpenStockViewbtn.TabIndex = 5;
            this.OpenStockViewbtn.Text = "Open Stock View ";
            this.OpenStockViewbtn.UseVisualStyleBackColor = false;
            this.OpenStockViewbtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.Bid,
            this.Ask,
            this.Open,
            this.PreviousClose,
            this.Last,
            this.Change,
            this.symbolDataGridViewTextBoxColumn,
            this.securityDataGridViewTextBoxColumn,
            this.bidDataGridViewTextBoxColumn,
            this.askDataGridViewTextBoxColumn,
            this.openDataGridViewTextBoxColumn,
            this.previousCloseDataGridViewTextBoxColumn,
            this.lastDataGridViewTextBoxColumn,
            this.changeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.securityPricesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1266, 314);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // UpdateFXbtn
            // 
            this.UpdateFXbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateFXbtn.Location = new System.Drawing.Point(1110, 477);
            this.UpdateFXbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateFXbtn.Name = "UpdateFXbtn";
            this.UpdateFXbtn.Size = new System.Drawing.Size(207, 42);
            this.UpdateFXbtn.TabIndex = 7;
            this.UpdateFXbtn.Text = "Update Securities";
            this.UpdateFXbtn.UseVisualStyleBackColor = false;
            this.UpdateFXbtn.Click += new System.EventHandler(this.UpdateFXbtn_Click);
            // 
            // OpenStockBuybtn
            // 
            this.OpenStockBuybtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenStockBuybtn.Location = new System.Drawing.Point(75, 542);
            this.OpenStockBuybtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpenStockBuybtn.Name = "OpenStockBuybtn";
            this.OpenStockBuybtn.Size = new System.Drawing.Size(206, 42);
            this.OpenStockBuybtn.TabIndex = 8;
            this.OpenStockBuybtn.Text = "Open Stock Buy";
            this.OpenStockBuybtn.UseVisualStyleBackColor = false;
            this.OpenStockBuybtn.Click += new System.EventHandler(this.OpenStockBuybtn_Click);
            // 
            // DeleteSecbtn
            // 
            this.DeleteSecbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteSecbtn.Location = new System.Drawing.Point(896, 477);
            this.DeleteSecbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteSecbtn.Name = "DeleteSecbtn";
            this.DeleteSecbtn.Size = new System.Drawing.Size(207, 42);
            this.DeleteSecbtn.TabIndex = 9;
            this.DeleteSecbtn.Text = "Delete All Securities";
            this.DeleteSecbtn.UseVisualStyleBackColor = false;
            this.DeleteSecbtn.Click += new System.EventHandler(this.DeleteSecbtn_Click);
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Refreshbtn.Location = new System.Drawing.Point(1150, 109);
            this.Refreshbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(112, 35);
            this.Refreshbtn.TabIndex = 10;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = false;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // tradingPlatformDBDataSetBindingSource
            // 
            this.tradingPlatformDBDataSetBindingSource.AllowNew = true;
            this.tradingPlatformDBDataSetBindingSource.DataSource = this.securityPricesBindingSource;
            this.tradingPlatformDBDataSetBindingSource.CurrentChanged += new System.EventHandler(this.tradingPlatformDBDataSetBindingSource_CurrentChanged);
            // 
            // Symbol
            // 
            this.Symbol.DataPropertyName = "Symbol";
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            this.Symbol.ReadOnly = true;
            // 
            // Bid
            // 
            this.Bid.DataPropertyName = "Bid";
            this.Bid.HeaderText = "Bid";
            this.Bid.Name = "Bid";
            this.Bid.ReadOnly = true;
            // 
            // Ask
            // 
            this.Ask.DataPropertyName = "Ask";
            this.Ask.HeaderText = "Ask";
            this.Ask.Name = "Ask";
            this.Ask.ReadOnly = true;
            // 
            // Open
            // 
            this.Open.DataPropertyName = "Open";
            this.Open.HeaderText = "Open";
            this.Open.Name = "Open";
            this.Open.ReadOnly = true;
            // 
            // PreviousClose
            // 
            this.PreviousClose.DataPropertyName = "PreviousClose";
            this.PreviousClose.HeaderText = "PreviousClose";
            this.PreviousClose.Name = "PreviousClose";
            this.PreviousClose.ReadOnly = true;
            // 
            // Last
            // 
            this.Last.DataPropertyName = "Last";
            this.Last.HeaderText = "Last";
            this.Last.Name = "Last";
            this.Last.ReadOnly = true;
            // 
            // Change
            // 
            this.Change.DataPropertyName = "Change";
            this.Change.HeaderText = "Change";
            this.Change.Name = "Change";
            this.Change.ReadOnly = true;
            // 
            // securityPricesBindingSource
            // 
            this.securityPricesBindingSource.DataMember = "SecurityPrices";
            this.securityPricesBindingSource.DataSource = this.tradingPlatformDBDataSet;
            this.securityPricesBindingSource.CurrentChanged += new System.EventHandler(this.securityPricesBindingSource_CurrentChanged);
            // 
            // tradingPlatformDBDataSet
            // 
            this.tradingPlatformDBDataSet.DataSetName = "TradingPlatformDBDataSet";
            this.tradingPlatformDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // securityPricesTableAdapter
            // 
            this.securityPricesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.SecuritiesBoughtTableAdapter = null;
            this.tableAdapterManager.SecurityPricesTableAdapter = this.securityPricesTableAdapter;
            this.tableAdapterManager.UpdateOrder = TradingPlatform.TradingPlatformDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tradingPlatformDBDataSetBindingSource1
            // 
            this.tradingPlatformDBDataSetBindingSource1.DataSource = this.tradingPlatformDBDataSet;
            this.tradingPlatformDBDataSetBindingSource1.Position = 0;
            this.tradingPlatformDBDataSetBindingSource1.CurrentChanged += new System.EventHandler(this.tradingPlatformDBDataSetBindingSource1_CurrentChanged);
            // 
            // symbolDataGridViewTextBoxColumn
            // 
            this.symbolDataGridViewTextBoxColumn.DataPropertyName = "Symbol";
            this.symbolDataGridViewTextBoxColumn.HeaderText = "Symbol";
            this.symbolDataGridViewTextBoxColumn.Name = "symbolDataGridViewTextBoxColumn";
            this.symbolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // securityDataGridViewTextBoxColumn
            // 
            this.securityDataGridViewTextBoxColumn.DataPropertyName = "Security";
            this.securityDataGridViewTextBoxColumn.HeaderText = "Security";
            this.securityDataGridViewTextBoxColumn.Name = "securityDataGridViewTextBoxColumn";
            this.securityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bidDataGridViewTextBoxColumn
            // 
            this.bidDataGridViewTextBoxColumn.DataPropertyName = "Bid";
            this.bidDataGridViewTextBoxColumn.HeaderText = "Bid";
            this.bidDataGridViewTextBoxColumn.Name = "bidDataGridViewTextBoxColumn";
            this.bidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // askDataGridViewTextBoxColumn
            // 
            this.askDataGridViewTextBoxColumn.DataPropertyName = "Ask";
            this.askDataGridViewTextBoxColumn.HeaderText = "Ask";
            this.askDataGridViewTextBoxColumn.Name = "askDataGridViewTextBoxColumn";
            this.askDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // openDataGridViewTextBoxColumn
            // 
            this.openDataGridViewTextBoxColumn.DataPropertyName = "Open";
            this.openDataGridViewTextBoxColumn.HeaderText = "Open";
            this.openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
            this.openDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // previousCloseDataGridViewTextBoxColumn
            // 
            this.previousCloseDataGridViewTextBoxColumn.DataPropertyName = "PreviousClose";
            this.previousCloseDataGridViewTextBoxColumn.HeaderText = "PreviousClose";
            this.previousCloseDataGridViewTextBoxColumn.Name = "previousCloseDataGridViewTextBoxColumn";
            this.previousCloseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastDataGridViewTextBoxColumn
            // 
            this.lastDataGridViewTextBoxColumn.DataPropertyName = "Last";
            this.lastDataGridViewTextBoxColumn.HeaderText = "Last";
            this.lastDataGridViewTextBoxColumn.Name = "lastDataGridViewTextBoxColumn";
            this.lastDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // changeDataGridViewTextBoxColumn
            // 
            this.changeDataGridViewTextBoxColumn.DataPropertyName = "Change";
            this.changeDataGridViewTextBoxColumn.HeaderText = "Change";
            this.changeDataGridViewTextBoxColumn.Name = "changeDataGridViewTextBoxColumn";
            this.changeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Mystockbtn
            // 
            this.Mystockbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Mystockbtn.Location = new System.Drawing.Point(520, 542);
            this.Mystockbtn.Name = "Mystockbtn";
            this.Mystockbtn.Size = new System.Drawing.Size(207, 42);
            this.Mystockbtn.TabIndex = 11;
            this.Mystockbtn.Text = "View User Stocks";
            this.Mystockbtn.UseVisualStyleBackColor = false;
            this.Mystockbtn.Click += new System.EventHandler(this.Mystockbtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1372, 752);
            this.Controls.Add(this.Mystockbtn);
            this.Controls.Add(this.Refreshbtn);
            this.Controls.Add(this.DeleteSecbtn);
            this.Controls.Add(this.OpenStockBuybtn);
            this.Controls.Add(this.UpdateFXbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OpenStockViewbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProfitLosstxt);
            this.Controls.Add(this.usernameedit);
            this.Controls.Add(this.Availabletxt);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingPlatformDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityPricesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingPlatformDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingPlatformDBDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.TextBox Availabletxt;
        private System.Windows.Forms.TextBox ProfitLosstxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradingHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentTradesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.Button OpenStockViewbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdateFXbtn;
        private System.Windows.Forms.Button OpenStockBuybtn;
        public System.Windows.Forms.TextBox usernameedit;
        private System.Windows.Forms.BindingSource tradingPlatformDBDataSetBindingSource;
        private TradingPlatformDBDataSet tradingPlatformDBDataSet;
        private System.Windows.Forms.Button DeleteSecbtn;
        private System.Windows.Forms.BindingSource securityPricesBindingSource;
        private TradingPlatformDBDataSetTableAdapters.SecurityPricesTableAdapter securityPricesTableAdapter;
        private TradingPlatformDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.BindingSource tradingPlatformDBDataSetBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ask;
        private System.Windows.Forms.DataGridViewTextBoxColumn Open;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreviousClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last;
        private System.Windows.Forms.DataGridViewTextBoxColumn Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn securityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn askDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousCloseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Mystockbtn;
    }
}