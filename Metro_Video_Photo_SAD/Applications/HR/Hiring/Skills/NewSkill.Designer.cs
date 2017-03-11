namespace Applications.Applications.HR.Hiring.Skills
{
    partial class NewSkill
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
            this.textBox_DataItems = new System.Windows.Forms.TextBox();
            this.label_ExtAgent = new System.Windows.Forms.Label();
            this.textBox_SkillName = new System.Windows.Forms.TextBox();
            this.button_ValidateData = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_DocNum = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.textBox_Comment = new System.Windows.Forms.TextBox();
            this.label_Comment = new System.Windows.Forms.Label();
            this.textBox_DocType = new System.Windows.Forms.TextBox();
            this.label_DocumentType = new System.Windows.Forms.Label();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(132, 37);
            this.label_SubName.Text = "New Skill";
            // 
            // textBox_DataItems
            // 
            this.textBox_DataItems.Location = new System.Drawing.Point(764, 317);
            this.textBox_DataItems.Multiline = true;
            this.textBox_DataItems.Name = "textBox_DataItems";
            this.textBox_DataItems.Size = new System.Drawing.Size(446, 92);
            this.textBox_DataItems.TabIndex = 104;
            // 
            // label_ExtAgent
            // 
            this.label_ExtAgent.AutoSize = true;
            this.label_ExtAgent.Location = new System.Drawing.Point(360, 390);
            this.label_ExtAgent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ExtAgent.Name = "label_ExtAgent";
            this.label_ExtAgent.Size = new System.Drawing.Size(74, 17);
            this.label_ExtAgent.TabIndex = 99;
            this.label_ExtAgent.Text = "Skill Name";
            // 
            // textBox_SkillName
            // 
            this.textBox_SkillName.Location = new System.Drawing.Point(363, 419);
            this.textBox_SkillName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SkillName.Name = "textBox_SkillName";
            this.textBox_SkillName.Size = new System.Drawing.Size(329, 22);
            this.textBox_SkillName.TabIndex = 96;
            // 
            // button_ValidateData
            // 
            this.button_ValidateData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_ValidateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ValidateData.Location = new System.Drawing.Point(764, 437);
            this.button_ValidateData.Margin = new System.Windows.Forms.Padding(4);
            this.button_ValidateData.Name = "button_ValidateData";
            this.button_ValidateData.Size = new System.Drawing.Size(179, 73);
            this.button_ValidateData.TabIndex = 95;
            this.button_ValidateData.Text = "Validate Data";
            this.button_ValidateData.UseVisualStyleBackColor = false;
            this.button_ValidateData.Click += new System.EventHandler(this.button_ValidateData_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(1031, 434);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(179, 73);
            this.button_Save.TabIndex = 94;
            this.button_Save.Text = "Add Skill";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_DocNum
            // 
            this.textBox_DocNum.Enabled = false;
            this.textBox_DocNum.Location = new System.Drawing.Point(541, 317);
            this.textBox_DocNum.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_DocNum.Name = "textBox_DocNum";
            this.textBox_DocNum.Size = new System.Drawing.Size(151, 22);
            this.textBox_DocNum.TabIndex = 92;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(360, 320);
            this.label0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(105, 17);
            this.label0.TabIndex = 91;
            this.label0.Text = "Document Num";
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Location = new System.Drawing.Point(363, 485);
            this.textBox_Comment.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Comment.Name = "textBox_Comment";
            this.textBox_Comment.Size = new System.Drawing.Size(329, 22);
            this.textBox_Comment.TabIndex = 90;
            // 
            // label_Comment
            // 
            this.label_Comment.AutoSize = true;
            this.label_Comment.Location = new System.Drawing.Point(360, 456);
            this.label_Comment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Comment.Name = "label_Comment";
            this.label_Comment.Size = new System.Drawing.Size(67, 17);
            this.label_Comment.TabIndex = 89;
            this.label_Comment.Text = "Comment";
            // 
            // textBox_DocType
            // 
            this.textBox_DocType.Enabled = false;
            this.textBox_DocType.Location = new System.Drawing.Point(541, 352);
            this.textBox_DocType.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_DocType.Name = "textBox_DocType";
            this.textBox_DocType.Size = new System.Drawing.Size(151, 22);
            this.textBox_DocType.TabIndex = 88;
            this.textBox_DocType.Text = "63";
            // 
            // label_DocumentType
            // 
            this.label_DocumentType.AutoSize = true;
            this.label_DocumentType.Location = new System.Drawing.Point(360, 355);
            this.label_DocumentType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DocumentType.Name = "label_DocumentType";
            this.label_DocumentType.Size = new System.Drawing.Size(108, 17);
            this.label_DocumentType.TabIndex = 93;
            this.label_DocumentType.Text = "Document Type";
            // 
            // NewSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1571, 906);
            this.Controls.Add(this.textBox_DataItems);
            this.Controls.Add(this.label_ExtAgent);
            this.Controls.Add(this.textBox_SkillName);
            this.Controls.Add(this.button_ValidateData);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_DocNum);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.textBox_Comment);
            this.Controls.Add(this.label_Comment);
            this.Controls.Add(this.textBox_DocType);
            this.Controls.Add(this.label_DocumentType);
            this.Name = "NewSkill";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.label_DocumentType, 0);
            this.Controls.SetChildIndex(this.textBox_DocType, 0);
            this.Controls.SetChildIndex(this.label_Comment, 0);
            this.Controls.SetChildIndex(this.textBox_Comment, 0);
            this.Controls.SetChildIndex(this.label0, 0);
            this.Controls.SetChildIndex(this.textBox_DocNum, 0);
            this.Controls.SetChildIndex(this.button_Save, 0);
            this.Controls.SetChildIndex(this.button_ValidateData, 0);
            this.Controls.SetChildIndex(this.textBox_SkillName, 0);
            this.Controls.SetChildIndex(this.label_ExtAgent, 0);
            this.Controls.SetChildIndex(this.textBox_DataItems, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_DataItems;
        protected System.Windows.Forms.Label label_ExtAgent;
        protected System.Windows.Forms.TextBox textBox_SkillName;
        protected System.Windows.Forms.Button button_ValidateData;
        protected System.Windows.Forms.Button button_Save;
        protected System.Windows.Forms.TextBox textBox_DocNum;
        private System.Windows.Forms.Label label0;
        protected System.Windows.Forms.TextBox textBox_Comment;
        private System.Windows.Forms.Label label_Comment;
        protected System.Windows.Forms.TextBox textBox_DocType;
        private System.Windows.Forms.Label label_DocumentType;
    }
}
