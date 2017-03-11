namespace Applications.Applications.Accounting.AccountsReports
{
    partial class financialReports_main
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
            this.balanceSheetcrys = new System.Windows.Forms.Button();
            this.crysIncomeRpt = new System.Windows.Forms.Button();
            this.crysInternalrpt = new System.Windows.Forms.Button();
            this.crysTrialBalrpt = new System.Windows.Forms.Button();
            this.testReport = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // balanceSheetcrys
            // 
            this.balanceSheetcrys.Location = new System.Drawing.Point(500, 244);
            this.balanceSheetcrys.Name = "balanceSheetcrys";
            this.balanceSheetcrys.Size = new System.Drawing.Size(158, 67);
            this.balanceSheetcrys.TabIndex = 2;
            this.balanceSheetcrys.Text = "balanceSheetcrys";
            this.balanceSheetcrys.UseVisualStyleBackColor = true;
            this.balanceSheetcrys.Click += new System.EventHandler(this.balanceSheetcrys_Click);
            // 
            // crysIncomeRpt
            // 
            this.crysIncomeRpt.Location = new System.Drawing.Point(862, 244);
            this.crysIncomeRpt.Name = "crysIncomeRpt";
            this.crysIncomeRpt.Size = new System.Drawing.Size(153, 68);
            this.crysIncomeRpt.TabIndex = 3;
            this.crysIncomeRpt.Text = "Income Report";
            this.crysIncomeRpt.UseVisualStyleBackColor = true;
            this.crysIncomeRpt.Click += new System.EventHandler(this.crysIncomeRpt_Click);
            // 
            // crysInternalrpt
            // 
            this.crysInternalrpt.Location = new System.Drawing.Point(500, 358);
            this.crysInternalrpt.Name = "crysInternalrpt";
            this.crysInternalrpt.Size = new System.Drawing.Size(158, 67);
            this.crysInternalrpt.TabIndex = 4;
            this.crysInternalrpt.Text = "Internal Report";
            this.crysInternalrpt.UseVisualStyleBackColor = true;
            this.crysInternalrpt.Click += new System.EventHandler(this.crysInternalrpt_Click);
            // 
            // crysTrialBalrpt
            // 
            this.crysTrialBalrpt.Location = new System.Drawing.Point(862, 358);
            this.crysTrialBalrpt.Name = "crysTrialBalrpt";
            this.crysTrialBalrpt.Size = new System.Drawing.Size(158, 67);
            this.crysTrialBalrpt.TabIndex = 5;
            this.crysTrialBalrpt.Text = "Trial Balance";
            this.crysTrialBalrpt.UseVisualStyleBackColor = true;
            this.crysTrialBalrpt.Click += new System.EventHandler(this.crysTrialBalrpt_Click);
            // 
            // testReport
            // 
            this.testReport.Location = new System.Drawing.Point(500, 504);
            this.testReport.Name = "testReport";
            this.testReport.Size = new System.Drawing.Size(145, 37);
            this.testReport.TabIndex = 6;
            this.testReport.Text = "testreport";
            this.testReport.UseVisualStyleBackColor = true;
            this.testReport.Click += new System.EventHandler(this.testReport_Click);
            // 
            // financialReports_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1571, 906);
            this.Controls.Add(this.testReport);
            this.Controls.Add(this.crysTrialBalrpt);
            this.Controls.Add(this.crysInternalrpt);
            this.Controls.Add(this.crysIncomeRpt);
            this.Controls.Add(this.balanceSheetcrys);
            this.Name = "financialReports_main";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.balanceSheetcrys, 0);
            this.Controls.SetChildIndex(this.crysIncomeRpt, 0);
            this.Controls.SetChildIndex(this.crysInternalrpt, 0);
            this.Controls.SetChildIndex(this.crysTrialBalrpt, 0);
            this.Controls.SetChildIndex(this.testReport, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button balanceSheetcrys;
        private System.Windows.Forms.Button crysIncomeRpt;
        private System.Windows.Forms.Button crysInternalrpt;
        private System.Windows.Forms.Button crysTrialBalrpt;
        private System.Windows.Forms.Button testReport;
    }
}
