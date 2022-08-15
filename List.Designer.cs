namespace VocabularyQuiz
{
    partial class List
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabFormName = new System.Windows.Forms.Label();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnFormSize = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.EditSearch = new WinformForTesting.RJControls.RJTextBox();
            this.LabSearch = new System.Windows.Forms.Label();
            this.SCForm = new System.Windows.Forms.SplitContainer();
            this.LVData = new System.Windows.Forms.ListView();
            this.NUM = new System.Windows.Forms.ColumnHeader();
            this.ENGLISH = new System.Windows.Forms.ColumnHeader();
            this.CHINESE = new System.Windows.Forms.ColumnHeader();
            this.REMARK = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.EditEng = new WinformForTesting.RJControls.RJTextBox();
            this.EditTra = new WinformForTesting.RJControls.RJTextBox();
            this.EditRemark = new WinformForTesting.RJControls.RJTextBox();
            this.BtnAdd = new WinformForTesting.RJButton();
            this.LabTra = new System.Windows.Forms.Label();
            this.LabSign2 = new System.Windows.Forms.Label();
            this.LabSign1 = new System.Windows.Forms.Label();
            this.LabRemark = new System.Windows.Forms.Label();
            this.LabEng = new System.Windows.Forms.Label();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            this.PanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCForm)).BeginInit();
            this.SCForm.Panel1.SuspendLayout();
            this.SCForm.Panel2.SuspendLayout();
            this.SCForm.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.PanelAdd.SuspendLayout();
            this.SuspendLayout();
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
            this.PanelTitle.Size = new System.Drawing.Size(837, 32);
            this.PanelTitle.TabIndex = 2;
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
            this.LabFormName.Location = new System.Drawing.Point(347, 9);
            this.LabFormName.Name = "LabFormName";
            this.LabFormName.Size = new System.Drawing.Size(103, 17);
            this.LabFormName.TabIndex = 6;
            this.LabFormName.Text = "Vocabulary List";
            // 
            // PBIcon
            // 
            this.PBIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBIcon.Image = ((System.Drawing.Image)(resources.GetObject("PBIcon.Image")));
            this.PBIcon.Location = new System.Drawing.Point(324, 6);
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
            // PanelSearch
            // 
            this.PanelSearch.Controls.Add(this.EditSearch);
            this.PanelSearch.Controls.Add(this.LabSearch);
            this.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearch.Location = new System.Drawing.Point(0, 32);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(837, 43);
            this.PanelSearch.TabIndex = 3;
            // 
            // EditSearch
            // 
            this.EditSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.EditSearch.BorderColor = System.Drawing.Color.Gainsboro;
            this.EditSearch.BorderColorFouce = System.Drawing.Color.SlateGray;
            this.EditSearch.BorderRadius = 12;
            this.EditSearch.BorderSize = 1;
            this.EditSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditSearch.Location = new System.Drawing.Point(64, 6);
            this.EditSearch.Multiline = false;
            this.EditSearch.Name = "EditSearch";
            this.EditSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.EditSearch.PasswordChar = false;
            this.EditSearch.PlaceHoderText = "";
            this.EditSearch.PlaceHolderColer = System.Drawing.Color.White;
            this.EditSearch.ReadOnly = false;
            this.EditSearch.Size = new System.Drawing.Size(200, 32);
            this.EditSearch.TabIndex = 6;
            this.EditSearch.Texts = "";
            this.EditSearch.UnderlinedStyle = false;
            this.EditSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditSearch_KeyPress);
            // 
            // LabSearch
            // 
            this.LabSearch.AutoSize = true;
            this.LabSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabSearch.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LabSearch.Location = new System.Drawing.Point(10, 13);
            this.LabSearch.Name = "LabSearch";
            this.LabSearch.Size = new System.Drawing.Size(48, 17);
            this.LabSearch.TabIndex = 5;
            this.LabSearch.Text = "Search";
            // 
            // SCForm
            // 
            this.SCForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SCForm.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.SCForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCForm.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SCForm.Location = new System.Drawing.Point(0, 75);
            this.SCForm.Name = "SCForm";
            // 
            // SCForm.Panel1
            // 
            this.SCForm.Panel1.Controls.Add(this.LVData);
            // 
            // SCForm.Panel2
            // 
            this.SCForm.Panel2.Controls.Add(this.PanelAdd);
            this.SCForm.Size = new System.Drawing.Size(837, 260);
            this.SCForm.SplitterDistance = 585;
            this.SCForm.TabIndex = 7;
            // 
            // LVData
            // 
            this.LVData.BackColor = System.Drawing.SystemColors.Control;
            this.LVData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LVData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NUM,
            this.ENGLISH,
            this.CHINESE,
            this.REMARK});
            this.LVData.ContextMenuStrip = this.contextMenuStrip1;
            this.LVData.Cursor = System.Windows.Forms.Cursors.Default;
            this.LVData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVData.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LVData.FullRowSelect = true;
            this.LVData.GridLines = true;
            this.LVData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LVData.Location = new System.Drawing.Point(0, 0);
            this.LVData.Name = "LVData";
            this.LVData.Size = new System.Drawing.Size(583, 258);
            this.LVData.TabIndex = 0;
            this.LVData.TabStop = false;
            this.LVData.UseCompatibleStateImageBehavior = false;
            this.LVData.View = System.Windows.Forms.View.Details;
            // 
            // NUM
            // 
            this.NUM.Text = "No";
            this.NUM.Width = 80;
            // 
            // ENGLISH
            // 
            this.ENGLISH.Text = "English";
            this.ENGLISH.Width = 170;
            // 
            // CHINESE
            // 
            this.CHINESE.Text = "Chinese";
            this.CHINESE.Width = 170;
            // 
            // REMARK
            // 
            this.REMARK.Text = "Remark";
            this.REMARK.Width = 160;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 48);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // PanelAdd
            // 
            this.PanelAdd.BackColor = System.Drawing.SystemColors.Control;
            this.PanelAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAdd.Controls.Add(this.EditEng);
            this.PanelAdd.Controls.Add(this.EditTra);
            this.PanelAdd.Controls.Add(this.EditRemark);
            this.PanelAdd.Controls.Add(this.BtnAdd);
            this.PanelAdd.Controls.Add(this.LabTra);
            this.PanelAdd.Controls.Add(this.LabSign2);
            this.PanelAdd.Controls.Add(this.LabSign1);
            this.PanelAdd.Controls.Add(this.LabRemark);
            this.PanelAdd.Controls.Add(this.LabEng);
            this.PanelAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAdd.Location = new System.Drawing.Point(0, 0);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(246, 258);
            this.PanelAdd.TabIndex = 0;
            // 
            // EditEng
            // 
            this.EditEng.BackColor = System.Drawing.SystemColors.Control;
            this.EditEng.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EditEng.BorderColorFouce = System.Drawing.Color.RoyalBlue;
            this.EditEng.BorderRadius = 12;
            this.EditEng.BorderSize = 1;
            this.EditEng.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditEng.Location = new System.Drawing.Point(65, 30);
            this.EditEng.Multiline = false;
            this.EditEng.Name = "EditEng";
            this.EditEng.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.EditEng.PasswordChar = false;
            this.EditEng.PlaceHoderText = "";
            this.EditEng.PlaceHolderColer = System.Drawing.Color.DarkGray;
            this.EditEng.ReadOnly = false;
            this.EditEng.Size = new System.Drawing.Size(150, 29);
            this.EditEng.TabIndex = 1;
            this.EditEng.Texts = "";
            this.EditEng.UnderlinedStyle = true;
            // 
            // EditTra
            // 
            this.EditTra.BackColor = System.Drawing.SystemColors.Control;
            this.EditTra.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EditTra.BorderColorFouce = System.Drawing.Color.RoyalBlue;
            this.EditTra.BorderRadius = 12;
            this.EditTra.BorderSize = 1;
            this.EditTra.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditTra.Location = new System.Drawing.Point(65, 60);
            this.EditTra.Multiline = false;
            this.EditTra.Name = "EditTra";
            this.EditTra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.EditTra.PasswordChar = false;
            this.EditTra.PlaceHoderText = "";
            this.EditTra.PlaceHolderColer = System.Drawing.Color.DarkGray;
            this.EditTra.ReadOnly = false;
            this.EditTra.Size = new System.Drawing.Size(150, 29);
            this.EditTra.TabIndex = 2;
            this.EditTra.Texts = "";
            this.EditTra.UnderlinedStyle = true;
            // 
            // EditRemark
            // 
            this.EditRemark.BackColor = System.Drawing.SystemColors.Control;
            this.EditRemark.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EditRemark.BorderColorFouce = System.Drawing.Color.RoyalBlue;
            this.EditRemark.BorderRadius = 12;
            this.EditRemark.BorderSize = 1;
            this.EditRemark.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditRemark.Location = new System.Drawing.Point(65, 90);
            this.EditRemark.Multiline = false;
            this.EditRemark.Name = "EditRemark";
            this.EditRemark.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.EditRemark.PasswordChar = false;
            this.EditRemark.PlaceHoderText = "";
            this.EditRemark.PlaceHolderColer = System.Drawing.Color.DarkGray;
            this.EditRemark.ReadOnly = false;
            this.EditRemark.Size = new System.Drawing.Size(151, 29);
            this.EditRemark.TabIndex = 3;
            this.EditRemark.Texts = "";
            this.EditRemark.UnderlinedStyle = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnAdd.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.BtnAdd.BorderColer = System.Drawing.Color.Black;
            this.BtnAdd.BorderRadius = 12;
            this.BtnAdd.BorderSize = 1;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAdd.Location = new System.Drawing.Point(64, 125);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(151, 32);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.TextColor = System.Drawing.SystemColors.Control;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LabTra
            // 
            this.LabTra.AutoSize = true;
            this.LabTra.BackColor = System.Drawing.SystemColors.Control;
            this.LabTra.Location = new System.Drawing.Point(15, 70);
            this.LabTra.Name = "LabTra";
            this.LabTra.Size = new System.Drawing.Size(48, 14);
            this.LabTra.TabIndex = 13;
            this.LabTra.Text = "Chinese";
            // 
            // LabSign2
            // 
            this.LabSign2.AutoSize = true;
            this.LabSign2.BackColor = System.Drawing.SystemColors.Control;
            this.LabSign2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabSign2.ForeColor = System.Drawing.Color.DarkRed;
            this.LabSign2.Location = new System.Drawing.Point(210, 80);
            this.LabSign2.Name = "LabSign2";
            this.LabSign2.Size = new System.Drawing.Size(24, 17);
            this.LabSign2.TabIndex = 16;
            this.LabSign2.Text = "＊";
            // 
            // LabSign1
            // 
            this.LabSign1.AutoSize = true;
            this.LabSign1.BackColor = System.Drawing.SystemColors.Control;
            this.LabSign1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabSign1.ForeColor = System.Drawing.Color.DarkRed;
            this.LabSign1.Location = new System.Drawing.Point(210, 45);
            this.LabSign1.Name = "LabSign1";
            this.LabSign1.Size = new System.Drawing.Size(24, 17);
            this.LabSign1.TabIndex = 15;
            this.LabSign1.Text = "＊";
            // 
            // LabRemark
            // 
            this.LabRemark.AutoSize = true;
            this.LabRemark.BackColor = System.Drawing.SystemColors.Control;
            this.LabRemark.Location = new System.Drawing.Point(15, 100);
            this.LabRemark.Name = "LabRemark";
            this.LabRemark.Size = new System.Drawing.Size(46, 14);
            this.LabRemark.TabIndex = 14;
            this.LabRemark.Text = "Remark";
            // 
            // LabEng
            // 
            this.LabEng.AutoSize = true;
            this.LabEng.BackColor = System.Drawing.SystemColors.Control;
            this.LabEng.Location = new System.Drawing.Point(15, 40);
            this.LabEng.Name = "LabEng";
            this.LabEng.Size = new System.Drawing.Size(45, 14);
            this.LabEng.TabIndex = 12;
            this.LabEng.Text = "English";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(837, 335);
            this.Controls.Add(this.SCForm);
            this.Controls.Add(this.PanelSearch);
            this.Controls.Add(this.PanelTitle);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "List";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).EndInit();
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            this.SCForm.Panel1.ResumeLayout(false);
            this.SCForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCForm)).EndInit();
            this.SCForm.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelTitle;
        private Label LabFormName;
        private PictureBox PBIcon;
        private Button BtnClose;
        private Button BtnFormSize;
        private Button BtnMinimize;
        private Panel PanelSearch;
        private SplitContainer SCForm;
        private ListView LVData;
        private ColumnHeader NUM;
        private ColumnHeader ENGLISH;
        private ColumnHeader CHINESE;
        private ColumnHeader REMARK;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem modifyToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private Panel PanelAdd;
        private WinformForTesting.RJControls.RJTextBox EditSearch;
        private Label LabSearch;
        private WinformForTesting.RJControls.RJTextBox EditEng;
        private WinformForTesting.RJControls.RJTextBox EditTra;
        private WinformForTesting.RJControls.RJTextBox EditRemark;
        private WinformForTesting.RJButton BtnAdd;
        private Label LabTra;
        private Label LabSign2;
        private Label LabSign1;
        private Label LabRemark;
        private Label LabEng;
    }
}