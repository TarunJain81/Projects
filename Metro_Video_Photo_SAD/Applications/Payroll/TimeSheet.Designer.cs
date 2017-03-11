namespace Applications.Applications.Payroll
{
    partial class TimeSheet
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
            this.btnEnterTime = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_CMD
            // 
            this.textBox_CMD.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_CMD.Size = new System.Drawing.Size(485, 54);
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Margin = new System.Windows.Forms.Padding(4);
            // 
            // comboBox_TableName
            // 
            this.comboBox_TableName.Margin = new System.Windows.Forms.Padding(2);
            // 
            // button_Display
            // 
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click_1);
            // 
            // comboBox_DocType
            // 
            this.comboBox_DocType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_DocType.Text = "41";
            this.comboBox_DocType.SelectedIndexChanged += new System.EventHandler(this.comboBox_DocType_SelectedIndexChanged_1);
            // 
            // textBox_DocType
            // 
            this.textBox_DocType.Margin = new System.Windows.Forms.Padding(4);
            // 
            // button_Reset
            // 
            this.button_Reset.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.button_Reset.Location = new System.Drawing.Point(1011, 207);
            this.button_Reset.Text = "Update Timesheet";
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click_1);
            // 
            // textBox_DocNum
            // 
            this.textBox_DocNum.Margin = new System.Windows.Forms.Padding(4);
            // 
            // label_SubName
            // 
            this.label_SubName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_SubName.Size = new System.Drawing.Size(81, 28);
            this.label_SubName.Text = "Payroll";
            // 
            // btnEnterTime
            // 
            this.btnEnterTime.Location = new System.Drawing.Point(877, 203);
            this.btnEnterTime.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnterTime.Name = "btnEnterTime";
            this.btnEnterTime.Size = new System.Drawing.Size(112, 38);
            this.btnEnterTime.TabIndex = 15;
            this.btnEnterTime.Text = "Enter Hours";
            this.btnEnterTime.UseVisualStyleBackColor = true;
            this.btnEnterTime.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimeSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1219, 741);
            this.Controls.Add(this.btnEnterTime);
            this.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.Name = "TimeSheet";
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.comboBox_DocType, 0);
            this.Controls.SetChildIndex(this.textBox_DocType, 0);
            this.Controls.SetChildIndex(this.textBox_CMD, 0);
            this.Controls.SetChildIndex(this.button_Display, 0);
            this.Controls.SetChildIndex(this.comboBox_TableName, 0);
            this.Controls.SetChildIndex(this.textBox_TableName, 0);
            this.Controls.SetChildIndex(this.textBox_DocNum, 0);
            this.Controls.SetChildIndex(this.button_Reset, 0);
            this.Controls.SetChildIndex(this.btnEnterTime, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterTime;
    }
}
