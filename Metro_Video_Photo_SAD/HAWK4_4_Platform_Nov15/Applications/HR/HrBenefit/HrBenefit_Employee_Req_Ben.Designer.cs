namespace Applications.Applications.HR.HrBenefit
{
    partial class HrBenefit_Employee_Req_Ben
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
            this.dataGridView_benefits = new System.Windows.Forms.DataGridView();
            this.btn_req_to_add = new System.Windows.Forms.Button();
            this.btn_req_to_delete = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_benefits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_benefits
            // 
            this.dataGridView_benefits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_benefits.Location = new System.Drawing.Point(222, 169);
            this.dataGridView_benefits.Name = "dataGridView_benefits";
            this.dataGridView_benefits.Size = new System.Drawing.Size(608, 236);
            this.dataGridView_benefits.TabIndex = 0;
            this.dataGridView_benefits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_benefits_CellContentClick);
            // 
            // btn_req_to_add
            // 
            this.btn_req_to_add.Location = new System.Drawing.Point(340, 428);
            this.btn_req_to_add.Name = "btn_req_to_add";
            this.btn_req_to_add.Size = new System.Drawing.Size(118, 48);
            this.btn_req_to_add.TabIndex = 1;
            this.btn_req_to_add.Text = "Request to Add";
            this.btn_req_to_add.UseVisualStyleBackColor = true;
            // 
            // btn_req_to_delete
            // 
            this.btn_req_to_delete.Location = new System.Drawing.Point(614, 428);
            this.btn_req_to_delete.Name = "btn_req_to_delete";
            this.btn_req_to_delete.Size = new System.Drawing.Size(120, 48);
            this.btn_req_to_delete.TabIndex = 2;
            this.btn_req_to_delete.Text = "Request to Delete";
            this.btn_req_to_delete.UseVisualStyleBackColor = true;
            // 
            // HrBenefit_Employee_Req_Ben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 507);
            this.Controls.Add(this.btn_req_to_delete);
            this.Controls.Add(this.btn_req_to_add);
            this.Controls.Add(this.dataGridView_benefits);
            this.Name = "HrBenefit_Employee_Req_Ben";
            this.Text = "HrBenefit_Employee_Req_Ben";
            this.Controls.SetChildIndex(this.dataGridView_benefits, 0);
            this.Controls.SetChildIndex(this.btn_req_to_add, 0);
            this.Controls.SetChildIndex(this.btn_req_to_delete, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_benefits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_benefits;
        private System.Windows.Forms.Button btn_req_to_add;
        private System.Windows.Forms.Button btn_req_to_delete;
    }
}