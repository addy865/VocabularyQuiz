namespace VocabularyQuiz
{
    partial class Modify
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
            this.LabTra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabEng = new System.Windows.Forms.Label();
            this.EditTra = new System.Windows.Forms.TextBox();
            this.EditRemark = new System.Windows.Forms.TextBox();
            this.EditEng = new System.Windows.Forms.TextBox();
            this.PanelButtom = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PanelButtom.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabTra
            // 
            this.LabTra.AutoSize = true;
            this.LabTra.Location = new System.Drawing.Point(13, 53);
            this.LabTra.Name = "LabTra";
            this.LabTra.Size = new System.Drawing.Size(51, 15);
            this.LabTra.TabIndex = 12;
            this.LabTra.Text = "Chinese";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(271, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "＊";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(271, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "＊";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Remark";
            // 
            // LabEng
            // 
            this.LabEng.AutoSize = true;
            this.LabEng.Location = new System.Drawing.Point(13, 24);
            this.LabEng.Name = "LabEng";
            this.LabEng.Size = new System.Drawing.Size(47, 15);
            this.LabEng.TabIndex = 11;
            this.LabEng.Text = "English";
            // 
            // EditTra
            // 
            this.EditTra.Location = new System.Drawing.Point(70, 50);
            this.EditTra.Name = "EditTra";
            this.EditTra.Size = new System.Drawing.Size(199, 23);
            this.EditTra.TabIndex = 1;
            // 
            // EditRemark
            // 
            this.EditRemark.Location = new System.Drawing.Point(70, 79);
            this.EditRemark.Name = "EditRemark";
            this.EditRemark.Size = new System.Drawing.Size(199, 23);
            this.EditRemark.TabIndex = 2;
            // 
            // EditEng
            // 
            this.EditEng.Location = new System.Drawing.Point(70, 21);
            this.EditEng.Name = "EditEng";
            this.EditEng.Size = new System.Drawing.Size(199, 23);
            this.EditEng.TabIndex = 0;
            // 
            // PanelButtom
            // 
            this.PanelButtom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelButtom.Controls.Add(this.BtnCancel);
            this.PanelButtom.Controls.Add(this.BtnSave);
            this.PanelButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtom.Location = new System.Drawing.Point(0, 122);
            this.PanelButtom.Name = "PanelButtom";
            this.PanelButtom.Size = new System.Drawing.Size(312, 32);
            this.PanelButtom.TabIndex = 16;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(232, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(151, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 154);
            this.Controls.Add(this.PanelButtom);
            this.Controls.Add(this.LabTra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabEng);
            this.Controls.Add(this.EditTra);
            this.Controls.Add(this.EditRemark);
            this.Controls.Add(this.EditEng);
            this.Name = "Modify";
            this.Text = "Modify";
            this.PanelButtom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabTra;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label LabEng;
        private Panel PanelButtom;
        private Button BtnCancel;
        private Button BtnSave;
        public TextBox EditTra;
        public TextBox EditRemark;
        public TextBox EditEng;
    }
}