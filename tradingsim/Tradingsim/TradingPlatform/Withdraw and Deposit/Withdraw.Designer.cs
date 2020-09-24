namespace TradingPlatform
{
    partial class Withdraw
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Withdrawtxt = new System.Windows.Forms.TextBox();
            this.Availabletxt = new System.Windows.Forms.TextBox();
            this.Withdrawbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "AVAILABLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(50, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "AMOUNT";
            // 
            // Withdrawtxt
            // 
            this.Withdrawtxt.Location = new System.Drawing.Point(142, 162);
            this.Withdrawtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Withdrawtxt.Name = "Withdrawtxt";
            this.Withdrawtxt.Size = new System.Drawing.Size(148, 26);
            this.Withdrawtxt.TabIndex = 4;
            // 
            // Availabletxt
            // 
            this.Availabletxt.Location = new System.Drawing.Point(142, 62);
            this.Availabletxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Availabletxt.Name = "Availabletxt";
            this.Availabletxt.ReadOnly = true;
            this.Availabletxt.Size = new System.Drawing.Size(148, 26);
            this.Availabletxt.TabIndex = 5;
            // 
            // Withdrawbtn
            // 
            this.Withdrawbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Withdrawbtn.Location = new System.Drawing.Point(148, 243);
            this.Withdrawbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Withdrawbtn.Name = "Withdrawbtn";
            this.Withdrawbtn.Size = new System.Drawing.Size(129, 35);
            this.Withdrawbtn.TabIndex = 3;
            this.Withdrawbtn.Text = "WITHDRAW";
            this.Withdrawbtn.UseVisualStyleBackColor = false;
            this.Withdrawbtn.Click += new System.EventHandler(this.Withdrawbtn_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(327, 291);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Withdrawtxt);
            this.Controls.Add(this.Availabletxt);
            this.Controls.Add(this.Withdrawbtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Withdrawtxt;
        private System.Windows.Forms.TextBox Availabletxt;
        private System.Windows.Forms.Button Withdrawbtn;
    }
}