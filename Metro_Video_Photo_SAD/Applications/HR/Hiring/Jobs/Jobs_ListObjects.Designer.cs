﻿namespace Applications.Applications.HR.Hiring.Jobs
{
    partial class Jobs_ListObjects
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowJobForm = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_CMD
            // 
            this.textBox_CMD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_CMD.Size = new System.Drawing.Size(645, 37);
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // comboBox_TableName
            // 
            this.comboBox_TableName.Size = new System.Drawing.Size(324, 24);
            // 
            // button_Display
            // 
            this.button_Display.Location = new System.Drawing.Point(895, 244);
            this.button_Display.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click_1);
            // 
            // comboBox_DocType
            // 
            this.comboBox_DocType.Size = new System.Drawing.Size(327, 24);
            // 
            // textBox_DocType
            // 
            this.textBox_DocType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DocType.Text = "67";
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(1093, 255);
            this.button_Reset.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button_Reset.Size = new System.Drawing.Size(151, 42);
            // 
            // textBox_DocNum
            // 
            this.textBox_DocNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // label_SubName
            // 
            this.label_SubName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label_SubName.Size = new System.Drawing.Size(199, 37);
            this.label_SubName.Text = "Job Description";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1267, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Print report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnShowJobForm
            // 
            this.btnShowJobForm.Location = new System.Drawing.Point(1390, 255);
            this.btnShowJobForm.Name = "btnShowJobForm";
            this.btnShowJobForm.Size = new System.Drawing.Size(128, 42);
            this.btnShowJobForm.TabIndex = 16;
            this.btnShowJobForm.Text = "Add New Job";
            this.btnShowJobForm.UseVisualStyleBackColor = true;
            this.btnShowJobForm.Click += new System.EventHandler(this.btnShowJobForm_Click);
            // 
            // Jobs_ListObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1565, 961);
            this.Controls.Add(this.btnShowJobForm);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Jobs_ListObjects";
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
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnShowJobForm, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShowJobForm;
    }
}
