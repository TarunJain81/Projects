namespace Applications.Applications.Payroll
{
    partial class Crystal
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
            this.btnTimesheet = new System.Windows.Forms.Button();
            this.btnGrossPay = new System.Windows.Forms.Button();
            this.btnNetPay = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimesheet
            // 
            this.btnTimesheet.Location = new System.Drawing.Point(237, 184);
            this.btnTimesheet.Name = "btnTimesheet";
            this.btnTimesheet.Size = new System.Drawing.Size(89, 32);
            this.btnTimesheet.TabIndex = 2;
            this.btnTimesheet.Text = "Time Sheet";
            this.btnTimesheet.UseVisualStyleBackColor = true;
            this.btnTimesheet.Click += new System.EventHandler(this.btnTimesheet_Click);
            // 
            // btnGrossPay
            // 
            this.btnGrossPay.Location = new System.Drawing.Point(372, 182);
            this.btnGrossPay.Name = "btnGrossPay";
            this.btnGrossPay.Size = new System.Drawing.Size(86, 32);
            this.btnGrossPay.TabIndex = 3;
            this.btnGrossPay.Text = "Gross Pay";
            this.btnGrossPay.UseVisualStyleBackColor = true;
            this.btnGrossPay.Click += new System.EventHandler(this.btnGrossPay_Click);
            // 
            // btnNetPay
            // 
            this.btnNetPay.Location = new System.Drawing.Point(510, 184);
            this.btnNetPay.Name = "btnNetPay";
            this.btnNetPay.Size = new System.Drawing.Size(81, 32);
            this.btnNetPay.TabIndex = 4;
            this.btnNetPay.Text = "Net Pay";
            this.btnNetPay.UseVisualStyleBackColor = true;
            this.btnNetPay.Click += new System.EventHandler(this.btnNetPay_Click);
            // 
            // Crystal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.btnNetPay);
            this.Controls.Add(this.btnGrossPay);
            this.Controls.Add(this.btnTimesheet);
            this.Name = "Crystal";
            this.Text = "Crystal";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.btnTimesheet, 0);
            this.Controls.SetChildIndex(this.btnGrossPay, 0);
            this.Controls.SetChildIndex(this.btnNetPay, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimesheet;
        private System.Windows.Forms.Button btnGrossPay;
        private System.Windows.Forms.Button btnNetPay;
    }
}