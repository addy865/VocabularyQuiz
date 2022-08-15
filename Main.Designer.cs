namespace VocabularyQuiz
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.GbQuiz = new System.Windows.Forms.GroupBox();
            this.EditTopic = new WinformForTesting.RJControls.RJTextBox();
            this.EditAnser = new WinformForTesting.RJControls.RJTextBox();
            this.LabMsg = new System.Windows.Forms.Label();
            this.LabAnswer = new System.Windows.Forms.Label();
            this.LabTopic = new System.Windows.Forms.Label();
            this.LabTopicType = new System.Windows.Forms.Label();
            this.CombType = new System.Windows.Forms.ComboBox();
            this.StatusStripVersion = new System.Windows.Forms.StatusStrip();
            this.TSLabelVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabFormName = new System.Windows.Forms.Label();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnFormSize = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.GBParameters = new System.Windows.Forms.GroupBox();
            this.LabTopicNum = new System.Windows.Forms.Label();
            this.BtnStart = new WinformForTesting.RJButton();
            this.NumQty = new System.Windows.Forms.NumericUpDown();
            this.MSSetting = new System.Windows.Forms.MenuStrip();
            this.MenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.VocabularyListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GbQuiz.SuspendLayout();
            this.StatusStripVersion.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            this.PanelForm.SuspendLayout();
            this.GBParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumQty)).BeginInit();
            this.MSSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbQuiz
            // 
            this.GbQuiz.Controls.Add(this.EditTopic);
            this.GbQuiz.Controls.Add(this.EditAnser);
            this.GbQuiz.Controls.Add(this.LabMsg);
            this.GbQuiz.Controls.Add(this.LabAnswer);
            this.GbQuiz.Controls.Add(this.LabTopic);
            this.GbQuiz.Location = new System.Drawing.Point(293, 30);
            this.GbQuiz.Name = "GbQuiz";
            this.GbQuiz.Size = new System.Drawing.Size(232, 175);
            this.GbQuiz.TabIndex = 2;
            this.GbQuiz.TabStop = false;
            this.GbQuiz.Text = "Quiz";
            // 
            // EditTopic
            // 
            this.EditTopic.BackColor = System.Drawing.SystemColors.Control;
            this.EditTopic.BorderColor = System.Drawing.Color.DimGray;
            this.EditTopic.BorderColorFouce = System.Drawing.Color.RoyalBlue;
            this.EditTopic.BorderRadius = 10;
            this.EditTopic.BorderSize = 1;
            this.EditTopic.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditTopic.Location = new System.Drawing.Point(21, 58);
            this.EditTopic.Multiline = false;
            this.EditTopic.Name = "EditTopic";
            this.EditTopic.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.EditTopic.PasswordChar = false;
            this.EditTopic.PlaceHoderText = "";
            this.EditTopic.PlaceHolderColer = System.Drawing.Color.DarkGray;
            this.EditTopic.ReadOnly = true;
            this.EditTopic.Size = new System.Drawing.Size(190, 29);
            this.EditTopic.TabIndex = 8;
            this.EditTopic.Texts = "";
            this.EditTopic.UnderlinedStyle = false;
            // 
            // EditAnser
            // 
            this.EditAnser.BackColor = System.Drawing.Color.MintCream;
            this.EditAnser.BorderColor = System.Drawing.Color.DimGray;
            this.EditAnser.BorderColorFouce = System.Drawing.Color.DimGray;
            this.EditAnser.BorderRadius = 10;
            this.EditAnser.BorderSize = 1;
            this.EditAnser.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditAnser.Location = new System.Drawing.Point(21, 111);
            this.EditAnser.Multiline = false;
            this.EditAnser.Name = "EditAnser";
            this.EditAnser.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.EditAnser.PasswordChar = false;
            this.EditAnser.PlaceHoderText = "";
            this.EditAnser.PlaceHolderColer = System.Drawing.Color.DarkGray;
            this.EditAnser.ReadOnly = false;
            this.EditAnser.Size = new System.Drawing.Size(190, 29);
            this.EditAnser.TabIndex = 7;
            this.EditAnser.Texts = "";
            this.EditAnser.UnderlinedStyle = false;
            this.EditAnser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditAnswer_KeyPress);
            // 
            // LabMsg
            // 
            this.LabMsg.AutoSize = true;
            this.LabMsg.Location = new System.Drawing.Point(84, 33);
            this.LabMsg.Name = "LabMsg";
            this.LabMsg.Size = new System.Drawing.Size(0, 15);
            this.LabMsg.TabIndex = 4;
            // 
            // LabAnswer
            // 
            this.LabAnswer.AutoSize = true;
            this.LabAnswer.Location = new System.Drawing.Point(21, 93);
            this.LabAnswer.Name = "LabAnswer";
            this.LabAnswer.Size = new System.Drawing.Size(47, 15);
            this.LabAnswer.TabIndex = 1;
            this.LabAnswer.Text = "Answer";
            // 
            // LabTopic
            // 
            this.LabTopic.AutoSize = true;
            this.LabTopic.Location = new System.Drawing.Point(21, 40);
            this.LabTopic.Name = "LabTopic";
            this.LabTopic.Size = new System.Drawing.Size(39, 15);
            this.LabTopic.TabIndex = 0;
            this.LabTopic.Text = "Topic";
            // 
            // LabTopicType
            // 
            this.LabTopicType.AutoSize = true;
            this.LabTopicType.Location = new System.Drawing.Point(29, 25);
            this.LabTopicType.Name = "LabTopicType";
            this.LabTopicType.Size = new System.Drawing.Size(70, 15);
            this.LabTopicType.TabIndex = 4;
            this.LabTopicType.Text = "Topic Type";
            // 
            // CombType
            // 
            this.CombType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombType.FormattingEnabled = true;
            this.CombType.Items.AddRange(new object[] {
            "Chinese",
            "English"});
            this.CombType.Location = new System.Drawing.Point(29, 43);
            this.CombType.Name = "CombType";
            this.CombType.Size = new System.Drawing.Size(190, 23);
            this.CombType.TabIndex = 5;
            // 
            // StatusStripVersion
            // 
            this.StatusStripVersion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSLabelVersion});
            this.StatusStripVersion.Location = new System.Drawing.Point(0, 258);
            this.StatusStripVersion.Name = "StatusStripVersion";
            this.StatusStripVersion.Size = new System.Drawing.Size(550, 22);
            this.StatusStripVersion.TabIndex = 6;
            this.StatusStripVersion.Text = "statusStrip1";
            // 
            // TSLabelVersion
            // 
            this.TSLabelVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TSLabelVersion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TSLabelVersion.Name = "TSLabelVersion";
            this.TSLabelVersion.Size = new System.Drawing.Size(54, 17);
            this.TSLabelVersion.Text = "  Version ";
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.PanelTitle.Controls.Add(this.LabFormName);
            this.PanelTitle.Controls.Add(this.PBIcon);
            this.PanelTitle.Controls.Add(this.BtnClose);
            this.PanelTitle.Controls.Add(this.BtnFormSize);
            this.PanelTitle.Controls.Add(this.BtnMinimize);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(550, 32);
            this.PanelTitle.TabIndex = 1;
            this.PanelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            this.PanelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseMove);
            this.PanelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseUp);
            // 
            // LabFormName
            // 
            this.LabFormName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabFormName.AutoSize = true;
            this.LabFormName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabFormName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabFormName.Location = new System.Drawing.Point(214, 9);
            this.LabFormName.Name = "LabFormName";
            this.LabFormName.Size = new System.Drawing.Size(109, 17);
            this.LabFormName.TabIndex = 6;
            this.LabFormName.Text = "Vocabulary Quiz";
            // 
            // PBIcon
            // 
            this.PBIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBIcon.Image = ((System.Drawing.Image)(resources.GetObject("PBIcon.Image")));
            this.PBIcon.Location = new System.Drawing.Point(191, 6);
            this.PBIcon.Name = "PBIcon";
            this.PBIcon.Size = new System.Drawing.Size(21, 23);
            this.PBIcon.TabIndex = 2;
            this.PBIcon.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnClose.Location = new System.Drawing.Point(7, 11);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(12, 12);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Tag = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnTitleBar_Click);
            // 
            // BtnFormSize
            // 
            this.BtnFormSize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFormSize.BackgroundImage")));
            this.BtnFormSize.FlatAppearance.BorderSize = 0;
            this.BtnFormSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFormSize.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFormSize.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnFormSize.Location = new System.Drawing.Point(23, 11);
            this.BtnFormSize.Name = "BtnFormSize";
            this.BtnFormSize.Size = new System.Drawing.Size(12, 12);
            this.BtnFormSize.TabIndex = 4;
            this.BtnFormSize.Tag = "Size";
            this.BtnFormSize.UseVisualStyleBackColor = true;
            this.BtnFormSize.Click += new System.EventHandler(this.BtnTitleBar_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.BackgroundImage")));
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnMinimize.Location = new System.Drawing.Point(40, 11);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(12, 12);
            this.BtnMinimize.TabIndex = 3;
            this.BtnMinimize.Tag = "Minimize";
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnTitleBar_Click);
            // 
            // PanelForm
            // 
            this.PanelForm.Controls.Add(this.GBParameters);
            this.PanelForm.Controls.Add(this.GbQuiz);
            this.PanelForm.Controls.Add(this.MSSetting);
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(0, 32);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(550, 226);
            this.PanelForm.TabIndex = 7;
            // 
            // GBParameters
            // 
            this.GBParameters.Controls.Add(this.LabTopicNum);
            this.GBParameters.Controls.Add(this.BtnStart);
            this.GBParameters.Controls.Add(this.NumQty);
            this.GBParameters.Controls.Add(this.LabTopicType);
            this.GBParameters.Controls.Add(this.CombType);
            this.GBParameters.Location = new System.Drawing.Point(12, 30);
            this.GBParameters.Name = "GBParameters";
            this.GBParameters.Size = new System.Drawing.Size(247, 175);
            this.GBParameters.TabIndex = 9;
            this.GBParameters.TabStop = false;
            this.GBParameters.Text = "Parameters";
            // 
            // LabTopicNum
            // 
            this.LabTopicNum.AutoSize = true;
            this.LabTopicNum.Location = new System.Drawing.Point(29, 72);
            this.LabTopicNum.Name = "LabTopicNum";
            this.LabTopicNum.Size = new System.Drawing.Size(131, 15);
            this.LabTopicNum.TabIndex = 9;
            this.LabTopicNum.Text = "Numbers of questions";
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnStart.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.BtnStart.BorderColer = System.Drawing.Color.Black;
            this.BtnStart.BorderRadius = 10;
            this.BtnStart.BorderSize = 1;
            this.BtnStart.FlatAppearance.BorderSize = 0;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnStart.Location = new System.Drawing.Point(28, 125);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(190, 30);
            this.BtnStart.TabIndex = 7;
            this.BtnStart.Text = "Start";
            this.BtnStart.TextColor = System.Drawing.SystemColors.Control;
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // NumQty
            // 
            this.NumQty.BackColor = System.Drawing.SystemColors.Control;
            this.NumQty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumQty.Location = new System.Drawing.Point(29, 90);
            this.NumQty.Name = "NumQty";
            this.NumQty.Size = new System.Drawing.Size(190, 23);
            this.NumQty.TabIndex = 8;
            // 
            // MSSetting
            // 
            this.MSSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSetting});
            this.MSSetting.Location = new System.Drawing.Point(0, 0);
            this.MSSetting.Name = "MSSetting";
            this.MSSetting.Size = new System.Drawing.Size(550, 24);
            this.MSSetting.TabIndex = 6;
            this.MSSetting.Text = "menuStrip1";
            // 
            // MenuItemSetting
            // 
            this.MenuItemSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VocabularyListToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MenuItemSetting.Name = "MenuItemSetting";
            this.MenuItemSetting.Size = new System.Drawing.Size(64, 20);
            this.MenuItemSetting.Text = "Settings";
            // 
            // VocabularyListToolStripMenuItem
            // 
            this.VocabularyListToolStripMenuItem.Name = "VocabularyListToolStripMenuItem";
            this.VocabularyListToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.VocabularyListToolStripMenuItem.Text = "Vocabulary List";
            this.VocabularyListToolStripMenuItem.Click += new System.EventHandler(this.VocabularyListToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 280);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.StatusStripVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Vocabulary Quiz";
            this.Load += new System.EventHandler(this.Main_Load);
            this.GbQuiz.ResumeLayout(false);
            this.GbQuiz.PerformLayout();
            this.StatusStripVersion.ResumeLayout(false);
            this.StatusStripVersion.PerformLayout();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).EndInit();
            this.PanelForm.ResumeLayout(false);
            this.PanelForm.PerformLayout();
            this.GBParameters.ResumeLayout(false);
            this.GBParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumQty)).EndInit();
            this.MSSetting.ResumeLayout(false);
            this.MSSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox GbQuiz;
        private Label LabAnswer;
        private Label LabTopic;
        private Label LabTopicType;
        private ComboBox CombType;
        private Label LabMsg;
        private StatusStrip StatusStripVersion;
        private ToolStripStatusLabel TSLabelVersion;
        private Panel PanelTitle;
        private PictureBox PBIcon;
        private Button BtnClose;
        private Button BtnFormSize;
        private Button BtnMinimize;
        private Label LabFormName;
        private Panel PanelForm;
        private MenuStrip MSSetting;
        private ToolStripMenuItem MenuItemSetting;
        private ToolStripMenuItem VocabularyListToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private WinformForTesting.RJControls.RJTextBox EditAnser;
        private WinformForTesting.RJButton BtnStart;
        private WinformForTesting.RJControls.RJTextBox EditTopic;
        private GroupBox GBParameters;
        private Label LabTopicNum;
        private NumericUpDown NumQty;
    }
}