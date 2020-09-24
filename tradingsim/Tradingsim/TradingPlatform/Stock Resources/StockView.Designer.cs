namespace TradingPlatform
{
    partial class StockView
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
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.onedaybtn = new System.Windows.Forms.Button();
            this.ChartImg = new System.Windows.Forms.PictureBox();
            this.fivedaybtn = new System.Windows.Forms.Button();
            this.threemonthbtn = new System.Windows.Forms.Button();
            this.sixmonthbtn = new System.Windows.Forms.Button();
            this.oneyearbtn = new System.Windows.Forms.Button();
            this.twoyearbtn = new System.Windows.Forms.Button();
            this.fiveyearbtn = new System.Windows.Forms.Button();
            this.maxbtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChartImg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(38, 54);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(164, 26);
            this.txtSymbol.TabIndex = 0;
            // 
            // onedaybtn
            // 
            this.onedaybtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.onedaybtn.Location = new System.Drawing.Point(213, 22);
            this.onedaybtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.onedaybtn.Name = "onedaybtn";
            this.onedaybtn.Size = new System.Drawing.Size(130, 32);
            this.onedaybtn.TabIndex = 2;
            this.onedaybtn.Text = "One Day";
            this.onedaybtn.UseVisualStyleBackColor = false;
            this.onedaybtn.Click += new System.EventHandler(this.onedaybtn_Click);
            // 
            // ChartImg
            // 
            this.ChartImg.Location = new System.Drawing.Point(38, 100);
            this.ChartImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChartImg.Name = "ChartImg";
            this.ChartImg.Size = new System.Drawing.Size(916, 545);
            this.ChartImg.TabIndex = 3;
            this.ChartImg.TabStop = false;
            // 
            // fivedaybtn
            // 
            this.fivedaybtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fivedaybtn.Location = new System.Drawing.Point(213, 57);
            this.fivedaybtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fivedaybtn.Name = "fivedaybtn";
            this.fivedaybtn.Size = new System.Drawing.Size(130, 35);
            this.fivedaybtn.TabIndex = 5;
            this.fivedaybtn.Text = "Five Days";
            this.fivedaybtn.UseVisualStyleBackColor = false;
            this.fivedaybtn.Click += new System.EventHandler(this.fivedaybtn_Click);
            // 
            // threemonthbtn
            // 
            this.threemonthbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.threemonthbtn.Location = new System.Drawing.Point(352, 18);
            this.threemonthbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.threemonthbtn.Name = "threemonthbtn";
            this.threemonthbtn.Size = new System.Drawing.Size(148, 35);
            this.threemonthbtn.TabIndex = 5;
            this.threemonthbtn.Text = "Three Months";
            this.threemonthbtn.UseVisualStyleBackColor = false;
            this.threemonthbtn.Click += new System.EventHandler(this.threemonthbtn_Click);
            // 
            // sixmonthbtn
            // 
            this.sixmonthbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sixmonthbtn.Location = new System.Drawing.Point(510, 20);
            this.sixmonthbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sixmonthbtn.Name = "sixmonthbtn";
            this.sixmonthbtn.Size = new System.Drawing.Size(153, 35);
            this.sixmonthbtn.TabIndex = 5;
            this.sixmonthbtn.Text = "Six Months";
            this.sixmonthbtn.UseVisualStyleBackColor = false;
            this.sixmonthbtn.Click += new System.EventHandler(this.sixmonthbtn_Click);
            // 
            // oneyearbtn
            // 
            this.oneyearbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.oneyearbtn.Location = new System.Drawing.Point(672, 18);
            this.oneyearbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oneyearbtn.Name = "oneyearbtn";
            this.oneyearbtn.Size = new System.Drawing.Size(141, 35);
            this.oneyearbtn.TabIndex = 5;
            this.oneyearbtn.Text = "One Year";
            this.oneyearbtn.UseVisualStyleBackColor = false;
            this.oneyearbtn.Click += new System.EventHandler(this.oneyearbtn_Click);
            // 
            // twoyearbtn
            // 
            this.twoyearbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.twoyearbtn.Location = new System.Drawing.Point(672, 55);
            this.twoyearbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.twoyearbtn.Name = "twoyearbtn";
            this.twoyearbtn.Size = new System.Drawing.Size(141, 35);
            this.twoyearbtn.TabIndex = 5;
            this.twoyearbtn.Text = "Two Years";
            this.twoyearbtn.UseVisualStyleBackColor = false;
            this.twoyearbtn.Click += new System.EventHandler(this.twoyearbtn_Click);
            // 
            // fiveyearbtn
            // 
            this.fiveyearbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fiveyearbtn.Location = new System.Drawing.Point(352, 57);
            this.fiveyearbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fiveyearbtn.Name = "fiveyearbtn";
            this.fiveyearbtn.Size = new System.Drawing.Size(148, 35);
            this.fiveyearbtn.TabIndex = 5;
            this.fiveyearbtn.Text = "Five Years";
            this.fiveyearbtn.UseVisualStyleBackColor = false;
            this.fiveyearbtn.Click += new System.EventHandler(this.fiveyearbtn_Click);
            // 
            // maxbtn
            // 
            this.maxbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.maxbtn.Location = new System.Drawing.Point(510, 57);
            this.maxbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maxbtn.Name = "maxbtn";
            this.maxbtn.Size = new System.Drawing.Size(153, 35);
            this.maxbtn.TabIndex = 6;
            this.maxbtn.Text = "Max";
            this.maxbtn.UseVisualStyleBackColor = false;
            this.maxbtn.Click += new System.EventHandler(this.maxbtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Closebtn.Location = new System.Drawing.Point(976, 605);
            this.Closebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(112, 35);
            this.Closebtn.TabIndex = 7;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = false;
            // 
            // StockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1131, 658);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.maxbtn);
            this.Controls.Add(this.fiveyearbtn);
            this.Controls.Add(this.twoyearbtn);
            this.Controls.Add(this.oneyearbtn);
            this.Controls.Add(this.sixmonthbtn);
            this.Controls.Add(this.threemonthbtn);
            this.Controls.Add(this.fivedaybtn);
            this.Controls.Add(this.ChartImg);
            this.Controls.Add(this.onedaybtn);
            this.Controls.Add(this.txtSymbol);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StockView";
            this.Text = "StockView";
            this.Load += new System.EventHandler(this.StockView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Button onedaybtn;
        private System.Windows.Forms.PictureBox ChartImg;
        private System.Windows.Forms.Button fivedaybtn;
        private System.Windows.Forms.Button threemonthbtn;
        private System.Windows.Forms.Button sixmonthbtn;
        private System.Windows.Forms.Button oneyearbtn;
        private System.Windows.Forms.Button twoyearbtn;
        private System.Windows.Forms.Button fiveyearbtn;
        private System.Windows.Forms.Button maxbtn;
        private System.Windows.Forms.Button Closebtn;
    }
}