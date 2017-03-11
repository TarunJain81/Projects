namespace Applications.Applications.HR.HrBenefit
{
    partial class DisplaySelectedObject_emp
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
            this.btn_add_benefit = new System.Windows.Forms.Button();
            this.btn_delete_benefit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Cmd
            // 
            this.textBox_Cmd.Size = new System.Drawing.Size(550, 65);
            // 
            // button_DisplayDoc
            // 
            this.button_DisplayDoc.Location = new System.Drawing.Point(645, 181);
            // 
            // button_ResetLabels
            // 
            this.button_ResetLabels.Location = new System.Drawing.Point(555, 192);
            // 
            // button_ResetCommand
            // 
            this.button_ResetCommand.Location = new System.Drawing.Point(468, 192);
            // 
            // button_ChangeDoc
            // 
            this.button_ChangeDoc.Location = new System.Drawing.Point(778, 177);
            // 
            // textBox_DataStrings
            // 
            this.textBox_DataStrings.Size = new System.Drawing.Size(279, 178);
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(240, 28);
            this.label_SubName.Text = " HR Benefits - Team 1D";
            // 
            // btn_add_benefit
            // 
            this.btn_add_benefit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_benefit.Location = new System.Drawing.Point(877, 167);
            this.btn_add_benefit.Name = "btn_add_benefit";
            this.btn_add_benefit.Size = new System.Drawing.Size(92, 68);
            this.btn_add_benefit.TabIndex = 42;
            this.btn_add_benefit.Text = "Add Benefit";
            this.btn_add_benefit.UseVisualStyleBackColor = true;
            this.btn_add_benefit.Click += new System.EventHandler(this.btn_add_benefit_Click);
            // 
            // btn_delete_benefit
            // 
            this.btn_delete_benefit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_benefit.Location = new System.Drawing.Point(985, 164);
            this.btn_delete_benefit.Name = "btn_delete_benefit";
            this.btn_delete_benefit.Size = new System.Drawing.Size(84, 69);
            this.btn_delete_benefit.TabIndex = 43;
            this.btn_delete_benefit.Text = "Remove Benefit";
            this.btn_delete_benefit.UseVisualStyleBackColor = true;
            this.btn_delete_benefit.Click += new System.EventHandler(this.btn_delete_benefit_Click);
            // 
            // DisplaySelectedObject_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1081, 677);
            this.Controls.Add(this.btn_delete_benefit);
            this.Controls.Add(this.btn_add_benefit);
            this.Name = "DisplaySelectedObject_emp";
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this.label_DocType, 0);
            this.Controls.SetChildIndex(this.textBox_DocType, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.textBox_Comment, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.label_DocNumber, 0);
            this.Controls.SetChildIndex(this.textBox_DocNum, 0);
            this.Controls.SetChildIndex(this.button_DisplayDoc, 0);
            this.Controls.SetChildIndex(this.textBox_Cmd, 0);
            this.Controls.SetChildIndex(this.textBox_ExtAgent, 0);
            this.Controls.SetChildIndex(this.textBox_IntAgent, 0);
            this.Controls.SetChildIndex(this.textBox_DataStrings, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1_TableName, 0);
            this.Controls.SetChildIndex(this.textBox_TableName, 0);
            this.Controls.SetChildIndex(this.button_ResetLabels, 0);
            this.Controls.SetChildIndex(this.button_ResetCommand, 0);
            this.Controls.SetChildIndex(this.button_ChangeDoc, 0);
            this.Controls.SetChildIndex(this.label_ExtAgent, 0);
            this.Controls.SetChildIndex(this.label_IntAgent, 0);
            this.Controls.SetChildIndex(this.btn_add_benefit, 0);
            this.Controls.SetChildIndex(this.btn_delete_benefit, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_benefit;
        private System.Windows.Forms.Button btn_delete_benefit;
    }
}
