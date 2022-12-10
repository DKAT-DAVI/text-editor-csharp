namespace text_editor
{
    partial class Form1
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
            this.rtxbFile = new System.Windows.Forms.RichTextBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tmnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuAlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuAlignCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuAlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuAlignJustify = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuBold = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.tbnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bntCopy = new System.Windows.Forms.ToolStripButton();
            this.btnPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalic = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLeft = new System.Windows.Forms.ToolStripButton();
            this.btnCenter = new System.Windows.Forms.ToolStripButton();
            this.btnRight = new System.Windows.Forms.ToolStripButton();
            this.bntJustify = new System.Windows.Forms.ToolStripButton();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pnlFile = new System.Windows.Forms.Panel();
            this.ScrollBar = new System.Windows.Forms.VScrollBar();
            this.mnuMain.SuspendLayout();
            this.tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxbFile
            // 
            this.rtxbFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtxbFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbFile.Location = new System.Drawing.Point(110, 80);
            this.rtxbFile.Margin = new System.Windows.Forms.Padding(10);
            this.rtxbFile.Name = "rtxbFile";
            this.rtxbFile.Size = new System.Drawing.Size(750, 1088);
            this.rtxbFile.TabIndex = 0;
            this.rtxbFile.Text = "";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuFormat});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(984, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnuNew,
            this.tmnuOpen,
            this.tmnuSave,
            this.tmnuPrint,
            this.toolStripMenuItem1,
            this.tmnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // tmnuNew
            // 
            this.tmnuNew.Name = "tmnuNew";
            this.tmnuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tmnuNew.Size = new System.Drawing.Size(146, 22);
            this.tmnuNew.Text = "New";
            this.tmnuNew.Click += new System.EventHandler(this.tmnuNew_Click);
            // 
            // tmnuOpen
            // 
            this.tmnuOpen.Name = "tmnuOpen";
            this.tmnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tmnuOpen.Size = new System.Drawing.Size(146, 22);
            this.tmnuOpen.Text = "Open";
            this.tmnuOpen.Click += new System.EventHandler(this.tmnuOpen_Click);
            // 
            // tmnuSave
            // 
            this.tmnuSave.Name = "tmnuSave";
            this.tmnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tmnuSave.Size = new System.Drawing.Size(146, 22);
            this.tmnuSave.Text = "Save";
            this.tmnuSave.Click += new System.EventHandler(this.tmnuSave_Click);
            // 
            // tmnuPrint
            // 
            this.tmnuPrint.Name = "tmnuPrint";
            this.tmnuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tmnuPrint.Size = new System.Drawing.Size(146, 22);
            this.tmnuPrint.Text = "Print";
            this.tmnuPrint.Click += new System.EventHandler(this.tmnuPrint_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // tmnuExit
            // 
            this.tmnuExit.Name = "tmnuExit";
            this.tmnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tmnuExit.Size = new System.Drawing.Size(146, 22);
            this.tmnuExit.Text = "Exit";
            this.tmnuExit.Click += new System.EventHandler(this.tmnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnuCopy,
            this.tmnuPaste,
            this.tmnuUndo,
            this.tmnuRedo});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "Edit";
            // 
            // tmnuCopy
            // 
            this.tmnuCopy.Name = "tmnuCopy";
            this.tmnuCopy.Size = new System.Drawing.Size(103, 22);
            this.tmnuCopy.Text = "Copy";
            this.tmnuCopy.Click += new System.EventHandler(this.tmnuCopy_Click);
            // 
            // tmnuPaste
            // 
            this.tmnuPaste.Name = "tmnuPaste";
            this.tmnuPaste.Size = new System.Drawing.Size(103, 22);
            this.tmnuPaste.Text = "Paste";
            this.tmnuPaste.Click += new System.EventHandler(this.tmnuPaste_Click);
            // 
            // tmnuUndo
            // 
            this.tmnuUndo.Name = "tmnuUndo";
            this.tmnuUndo.Size = new System.Drawing.Size(103, 22);
            this.tmnuUndo.Text = "Undo";
            this.tmnuUndo.Click += new System.EventHandler(this.tmnuUndo_Click);
            // 
            // tmnuRedo
            // 
            this.tmnuRedo.Name = "tmnuRedo";
            this.tmnuRedo.Size = new System.Drawing.Size(103, 22);
            this.tmnuRedo.Text = "Redo";
            this.tmnuRedo.Click += new System.EventHandler(this.tmnuRedo_Click);
            // 
            // mnuFormat
            // 
            this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnuAlign,
            this.tmnuBold,
            this.tmnuItalic,
            this.tmnuUnderline});
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Size = new System.Drawing.Size(57, 20);
            this.mnuFormat.Text = "Format";
            // 
            // tmnuAlign
            // 
            this.tmnuAlign.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnuAlignLeft,
            this.tmnuAlignCenter,
            this.tmnuAlignRight,
            this.tmnuAlignJustify});
            this.tmnuAlign.Name = "tmnuAlign";
            this.tmnuAlign.Size = new System.Drawing.Size(167, 22);
            this.tmnuAlign.Text = "Align";
            // 
            // tmnuAlignLeft
            // 
            this.tmnuAlignLeft.Name = "tmnuAlignLeft";
            this.tmnuAlignLeft.Size = new System.Drawing.Size(109, 22);
            this.tmnuAlignLeft.Text = "Left";
            this.tmnuAlignLeft.Click += new System.EventHandler(this.tmnuAlignLeft_Click);
            // 
            // tmnuAlignCenter
            // 
            this.tmnuAlignCenter.Name = "tmnuAlignCenter";
            this.tmnuAlignCenter.Size = new System.Drawing.Size(109, 22);
            this.tmnuAlignCenter.Text = "Center";
            this.tmnuAlignCenter.Click += new System.EventHandler(this.tmnuAlignCenter_Click);
            // 
            // tmnuAlignRight
            // 
            this.tmnuAlignRight.Name = "tmnuAlignRight";
            this.tmnuAlignRight.Size = new System.Drawing.Size(109, 22);
            this.tmnuAlignRight.Text = "Right";
            this.tmnuAlignRight.Click += new System.EventHandler(this.tmnuAlignRight_Click);
            // 
            // tmnuAlignJustify
            // 
            this.tmnuAlignJustify.Name = "tmnuAlignJustify";
            this.tmnuAlignJustify.Size = new System.Drawing.Size(109, 22);
            this.tmnuAlignJustify.Text = "Justify";
            this.tmnuAlignJustify.Click += new System.EventHandler(this.tmnuAlignJustify_Click);
            // 
            // tmnuBold
            // 
            this.tmnuBold.Name = "tmnuBold";
            this.tmnuBold.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.tmnuBold.Size = new System.Drawing.Size(167, 22);
            this.tmnuBold.Text = "Bold";
            this.tmnuBold.Click += new System.EventHandler(this.tmnuBold_Click);
            // 
            // tmnuItalic
            // 
            this.tmnuItalic.Name = "tmnuItalic";
            this.tmnuItalic.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.tmnuItalic.Size = new System.Drawing.Size(167, 22);
            this.tmnuItalic.Text = "Italic";
            this.tmnuItalic.Click += new System.EventHandler(this.tmnuItalic_Click);
            // 
            // tmnuUnderline
            // 
            this.tmnuUnderline.Name = "tmnuUnderline";
            this.tmnuUnderline.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.tmnuUnderline.Size = new System.Drawing.Size(167, 22);
            this.tmnuUnderline.Text = "Underline";
            this.tmnuUnderline.Click += new System.EventHandler(this.tmnuUnderline_Click);
            // 
            // tools
            // 
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.tbnOpen,
            this.btnSave,
            this.btnPrint,
            this.toolStripSeparator1,
            this.bntCopy,
            this.btnPaste,
            this.toolStripSeparator2,
            this.btnBold,
            this.btnItalic,
            this.btnUnderline,
            this.toolStripSeparator3,
            this.btnLeft,
            this.btnCenter,
            this.btnRight,
            this.bntJustify});
            this.tools.Location = new System.Drawing.Point(0, 24);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(984, 25);
            this.tools.TabIndex = 2;
            this.tools.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = global::text_editor.Properties.Resources._new;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 22);
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tbnOpen
            // 
            this.tbnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbnOpen.Image = global::text_editor.Properties.Resources.open;
            this.tbnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbnOpen.Name = "tbnOpen";
            this.tbnOpen.Size = new System.Drawing.Size(23, 22);
            this.tbnOpen.Text = "Open";
            this.tbnOpen.Click += new System.EventHandler(this.tbnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::text_editor.Properties.Resources.save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = global::text_editor.Properties.Resources.print;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(23, 22);
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bntCopy
            // 
            this.bntCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bntCopy.Image = global::text_editor.Properties.Resources.copy;
            this.bntCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntCopy.Name = "bntCopy";
            this.bntCopy.Size = new System.Drawing.Size(23, 22);
            this.bntCopy.Text = "Copy";
            this.bntCopy.Click += new System.EventHandler(this.bntCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPaste.Image = global::text_editor.Properties.Resources.paste;
            this.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(23, 22);
            this.btnPaste.Text = "Paste";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBold
            // 
            this.btnBold.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Image = global::text_editor.Properties.Resources.bold;
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 22);
            this.btnBold.Text = "Bold";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalic.Image = global::text_editor.Properties.Resources.italic;
            this.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(23, 22);
            this.btnItalic.Text = "Italic";
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnderline.Image = global::text_editor.Properties.Resources.underlined;
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(23, 22);
            this.btnUnderline.Text = "Underline";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLeft
            // 
            this.btnLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLeft.Image = global::text_editor.Properties.Resources.align_left;
            this.btnLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(23, 22);
            this.btnLeft.Text = "Left";
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCenter.Image = global::text_editor.Properties.Resources.align_center;
            this.btnCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(23, 22);
            this.btnCenter.Text = "Center";
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnRight
            // 
            this.btnRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRight.Image = global::text_editor.Properties.Resources.align_right;
            this.btnRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(23, 22);
            this.btnRight.Text = "Right";
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // bntJustify
            // 
            this.bntJustify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bntJustify.Image = global::text_editor.Properties.Resources.justified;
            this.bntJustify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntJustify.Name = "bntJustify";
            this.bntJustify.Size = new System.Drawing.Size(23, 22);
            this.bntJustify.Text = "Justify";
            this.bntJustify.Click += new System.EventHandler(this.bntJustify_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "dkat|*.dkat|txt|*.txt|All files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "*.dkat|*.dkat|*.txt|*.txt|All files|*.*";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // pnlFile
            // 
            this.pnlFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFile.BackColor = System.Drawing.Color.White;
            this.pnlFile.Location = new System.Drawing.Point(88, 60);
            this.pnlFile.Name = "pnlFile";
            this.pnlFile.Size = new System.Drawing.Size(794, 1122);
            this.pnlFile.TabIndex = 3;
            // 
            // ScrollBar
            // 
            this.ScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBar.Location = new System.Drawing.Point(969, 49);
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.Size = new System.Drawing.Size(15, 613);
            this.ScrollBar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.ScrollBar);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.rtxbFile);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.pnlFile);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DKAT Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxbFile;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem tmnuNew;
        private System.Windows.Forms.ToolStripMenuItem tmnuOpen;
        private System.Windows.Forms.ToolStripMenuItem tmnuSave;
        private System.Windows.Forms.ToolStripMenuItem tmnuPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tmnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem tmnuCopy;
        private System.Windows.Forms.ToolStripMenuItem tmnuPaste;
        private System.Windows.Forms.ToolStripMenuItem tmnuUndo;
        private System.Windows.Forms.ToolStripMenuItem tmnuRedo;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem tmnuBold;
        private System.Windows.Forms.ToolStripMenuItem tmnuItalic;
        private System.Windows.Forms.ToolStripMenuItem tmnuUnderline;
        private System.Windows.Forms.ToolStripMenuItem tmnuAlign;
        private System.Windows.Forms.ToolStripMenuItem tmnuAlignLeft;
        private System.Windows.Forms.ToolStripMenuItem tmnuAlignCenter;
        private System.Windows.Forms.ToolStripMenuItem tmnuAlignRight;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton tbnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bntCopy;
        private System.Windows.Forms.ToolStripButton btnPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnItalic;
        private System.Windows.Forms.ToolStripButton btnUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnLeft;
        private System.Windows.Forms.ToolStripButton btnCenter;
        private System.Windows.Forms.ToolStripButton btnRight;
        private System.Windows.Forms.ToolStripButton bntJustify;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem tmnuAlignJustify;
        private System.Windows.Forms.Panel pnlFile;
        private System.Windows.Forms.VScrollBar ScrollBar;
    }
}

