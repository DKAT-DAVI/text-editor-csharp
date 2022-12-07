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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.tmnuBold = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuAlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuAlignCenters = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuAlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tmnuAlignJustify = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFile = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxbFile
            // 
            this.rtxbFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtxbFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbFile.Location = new System.Drawing.Point(110, 80);
            this.rtxbFile.Margin = new System.Windows.Forms.Padding(10);
            this.rtxbFile.Name = "rtxbFile";
            this.rtxbFile.Size = new System.Drawing.Size(750, 560);
            this.rtxbFile.TabIndex = 0;
            this.rtxbFile.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuFormat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.tmnuNew.Size = new System.Drawing.Size(180, 22);
            this.tmnuNew.Text = "New";
            this.tmnuNew.Click += new System.EventHandler(this.tmnuNew_Click);
            // 
            // tmnuOpen
            // 
            this.tmnuOpen.Name = "tmnuOpen";
            this.tmnuOpen.Size = new System.Drawing.Size(180, 22);
            this.tmnuOpen.Text = "Open";
            // 
            // tmnuSave
            // 
            this.tmnuSave.Name = "tmnuSave";
            this.tmnuSave.Size = new System.Drawing.Size(180, 22);
            this.tmnuSave.Text = "Save";
            this.tmnuSave.Click += new System.EventHandler(this.tmnuSave_Click);
            // 
            // tmnuPrint
            // 
            this.tmnuPrint.Name = "tmnuPrint";
            this.tmnuPrint.Size = new System.Drawing.Size(180, 22);
            this.tmnuPrint.Text = "Print";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // tmnuExit
            // 
            this.tmnuExit.Name = "tmnuExit";
            this.tmnuExit.Size = new System.Drawing.Size(180, 22);
            this.tmnuExit.Text = "Exit";
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
            this.tmnuCopy.Size = new System.Drawing.Size(180, 22);
            this.tmnuCopy.Text = "Copy";
            // 
            // tmnuPaste
            // 
            this.tmnuPaste.Name = "tmnuPaste";
            this.tmnuPaste.Size = new System.Drawing.Size(180, 22);
            this.tmnuPaste.Text = "Paste";
            // 
            // tmnuUndo
            // 
            this.tmnuUndo.Name = "tmnuUndo";
            this.tmnuUndo.Size = new System.Drawing.Size(180, 22);
            this.tmnuUndo.Text = "Undo";
            // 
            // tmnuRedo
            // 
            this.tmnuRedo.Name = "tmnuRedo";
            this.tmnuRedo.Size = new System.Drawing.Size(180, 22);
            this.tmnuRedo.Text = "Redo";
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
            // tmnuBold
            // 
            this.tmnuBold.Name = "tmnuBold";
            this.tmnuBold.Size = new System.Drawing.Size(180, 22);
            this.tmnuBold.Text = "Bold";
            // 
            // tmnuItalic
            // 
            this.tmnuItalic.Name = "tmnuItalic";
            this.tmnuItalic.Size = new System.Drawing.Size(180, 22);
            this.tmnuItalic.Text = "Italic";
            // 
            // tmnuUnderline
            // 
            this.tmnuUnderline.Name = "tmnuUnderline";
            this.tmnuUnderline.Size = new System.Drawing.Size(180, 22);
            this.tmnuUnderline.Text = "Underline";
            // 
            // tmnuAlign
            // 
            this.tmnuAlign.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnuAlignLeft,
            this.tmnuAlignCenters,
            this.tmnuAlignRight,
            this.tmnuAlignJustify});
            this.tmnuAlign.Name = "tmnuAlign";
            this.tmnuAlign.Size = new System.Drawing.Size(180, 22);
            this.tmnuAlign.Text = "Align";
            // 
            // tmnuAlignLeft
            // 
            this.tmnuAlignLeft.Name = "tmnuAlignLeft";
            this.tmnuAlignLeft.Size = new System.Drawing.Size(180, 22);
            this.tmnuAlignLeft.Text = "Lefts";
            // 
            // tmnuAlignCenters
            // 
            this.tmnuAlignCenters.Name = "tmnuAlignCenters";
            this.tmnuAlignCenters.Size = new System.Drawing.Size(180, 22);
            this.tmnuAlignCenters.Text = "Centers";
            // 
            // tmnuAlignRight
            // 
            this.tmnuAlignRight.Name = "tmnuAlignRight";
            this.tmnuAlignRight.Size = new System.Drawing.Size(180, 22);
            this.tmnuAlignRight.Text = "Rights";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
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
            // 
            // btnPaste
            // 
            this.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPaste.Image = global::text_editor.Properties.Resources.paste;
            this.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(23, 22);
            this.btnPaste.Text = "Paste";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBold
            // 
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Image = global::text_editor.Properties.Resources.bold;
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 22);
            this.btnBold.Text = "Bold";
            // 
            // btnItalic
            // 
            this.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalic.Image = global::text_editor.Properties.Resources.italic;
            this.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(23, 22);
            this.btnItalic.Text = "Italic";
            // 
            // btnUnderline
            // 
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnderline.Image = global::text_editor.Properties.Resources.underlined;
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(23, 22);
            this.btnUnderline.Text = "Underline";
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
            // 
            // btnCenter
            // 
            this.btnCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCenter.Image = global::text_editor.Properties.Resources.align_center;
            this.btnCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(23, 22);
            this.btnCenter.Text = "Center";
            // 
            // btnRight
            // 
            this.btnRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRight.Image = global::text_editor.Properties.Resources.align_right;
            this.btnRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(23, 22);
            this.btnRight.Text = "Right";
            // 
            // bntJustify
            // 
            this.bntJustify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bntJustify.Image = global::text_editor.Properties.Resources.justified;
            this.bntJustify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntJustify.Name = "bntJustify";
            this.bntJustify.Size = new System.Drawing.Size(23, 22);
            this.bntJustify.Text = "Justify";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // tmnuAlignJustify
            // 
            this.tmnuAlignJustify.Name = "tmnuAlignJustify";
            this.tmnuAlignJustify.Size = new System.Drawing.Size(180, 22);
            this.tmnuAlignJustify.Text = "Justify";
            // 
            // pnlFile
            // 
            this.pnlFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFile.BackColor = System.Drawing.Color.White;
            this.pnlFile.Location = new System.Drawing.Point(88, 60);
            this.pnlFile.Name = "pnlFile";
            this.pnlFile.Size = new System.Drawing.Size(794, 600);
            this.pnlFile.TabIndex = 3;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(969, 49);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(15, 613);
            this.vScrollBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rtxbFile);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlFile);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxbFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem tmnuAlignCenters;
        private System.Windows.Forms.ToolStripMenuItem tmnuAlignRight;
        private System.Windows.Forms.ToolStrip toolStrip1;
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
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem tmnuAlignJustify;
        private System.Windows.Forms.Panel pnlFile;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

