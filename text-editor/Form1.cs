using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace text_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //-- mnuFile
        //
        //-- tmnuNew
        private void tmnuNew_Click(object sender, EventArgs e)
        {
            NewFile();
        }
        //--//

        //-- tmnuOpen
        private void tmnuOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        //--//

        //-- tmnuSave
        private void tmnuSave_Click(object sender, EventArgs e)
        {
            SaveFile();
               
        }
        //--//

        //-- tmnuPrint
        private void tmnuPrint_Click(object sender, EventArgs e)
        {

        }
        //--//

        //-- tmnuExit
        private void tmnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //--//
        //
        
        //-- mnuEdit
        //
        //-- tmnuCopy
        private void tmnuCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }
        //--//

        //-- tmnuPaste
        private void tmnuPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }
        //--//

        //-- tmnuUndo
        private void tmnuUndo_Click(object sender, EventArgs e)
        {

        }
        //--//

        //-- tmnuRedo
        private void tmnuRedo_Click(object sender, EventArgs e)
        {

        }
        //--//
        //

        //-- mnuFormat
        //
        //-- tmnuAlign
        //
        //-- tmnuAlignLeft
        private void tmnuAlignLeft_Click(object sender, EventArgs e)
        {
            AlignLeft();
        }
        //--//

        //-- tmnuAlignCenter
        private void tmnuAlignCenter_Click(object sender, EventArgs e)
        {
            AlignCenter();
        }
        //--//

        //-- tmnuAlignRight
        private void tmnuAlignRight_Click(object sender, EventArgs e)
        {
            AlignRight();
        }
        //--//

        //-- tmnuAlignJustify
        private void tmnuAlignJustify_Click(object sender, EventArgs e)
        {
            AlignJustify();
        }
        //
        //--//

        //-- Bold
        private void tmnuBold_Click(object sender, EventArgs e)
        {
            Bold();
            ChangeCollorsFormatButtons(this.btnBold);
        }
        //--//

        //-- Italic
        private void tmnuItalic_Click(object sender, EventArgs e)
        {
            Italic();
            ChangeCollorsFormatButtons(this.btnItalic);
        }
        //--//

        //-- Underline
        private void tmnuUnderline_Click(object sender, EventArgs e)
        {
            Underline();
            ChangeCollorsFormatButtons(this.btnUnderline);
        }
        //--//
        //
        //--//

        //-- Tools
        //
        //-- btnNew
        private void btnNew_Click(object sender, EventArgs e)
        {
            NewFile();
        }
        //--//

        //-- btnOpen
        private void tbnOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        //--//

        //-- btnSave
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        //

        //-- btnPrint
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
        //--//

        //-- bntCopy
        private void bntCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }
        //--//

        //-- bntPaste
        private void btnPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }
        //--//

        //-- btnBold
        private void btnBold_Click(object sender, EventArgs e)
        {
            Bold();
            ChangeCollorsFormatButtons(this.btnBold);
        }
        //--//

        //-- btnItalic
        private void btnItalic_Click(object sender, EventArgs e)
        {
            Italic();
            ChangeCollorsFormatButtons(this.btnItalic);
        }
        //--//

        //-- btnUnderline
        private void btnUnderline_Click(object sender, EventArgs e)
        {
            Underline();
            ChangeCollorsFormatButtons(this.btnUnderline);
        }
        //--//

        //-- btnAlignLeft
        private void btnLeft_Click(object sender, EventArgs e)
        {
            AlignLeft();
        }
        //--//

        //-- btnAlignCenter
        private void btnCenter_Click(object sender, EventArgs e)
        {
            AlignCenter();
        }
        //--//

        //-- btnAlignRight
        private void btnRight_Click(object sender, EventArgs e)
        {
            AlignRight();
        }
        //--//

        //-- btnJustify
        private void bntJustify_Click(object sender, EventArgs e)
        {
            AlignJustify();
        }
        //
        //--//

        //-- Methods()
        private void NewFile()
        {
            if(rtxbFile.Text != "")
            {
                if (MessageBox.Show("Do you want to save changes to this files?", "Text-Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveFile();
                }
                else
                {
                    rtxbFile.Clear();
                    rtxbFile.Focus();
                }
            }
            else
            {
                rtxbFile.Clear();
                rtxbFile.Focus();
            }
            
        }
        private void SaveFile()
        {
            try
            {
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                    StreamWriter streamWriter = new StreamWriter(file);

                    streamWriter.Flush();

                    streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    streamWriter.Write(this.rtxbFile.Text);

                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error during the save: {error.Message}", "Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OpenFile()
        {
            this.openFileDialog.Title = "Open File";
            openFileDialog.InitialDirectory = @"C:\\Users\\Davi Teixeira\\Desktop";

            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream file = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader streamReader = new StreamReader(file);
                    streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.rtxbFile.Text = "";
                    String line = streamReader.ReadLine();
                    while(line != null)
                    {
                        this.rtxbFile.Text += line + "\n";
                        line = streamReader.ReadLine();
                    }
                    streamReader.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Error reading file: {error.Message}", "READING ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
        }
        private void Copy()
        {
            if (rtxbFile.SelectionLength > 0)
            {
                rtxbFile.Copy();
            }
        }
        private void Paste()
        {
            rtxbFile.Paste();
        }
        private void Bold()
        {
            String fontName = rtxbFile.Font.Name;
            float fontSize = rtxbFile.Font.Size;
            bool bold = rtxbFile.SelectionFont.Bold;
            bool underline = rtxbFile.SelectionFont.Underline;
            bool italic = rtxbFile.SelectionFont.Italic;

            if (bold == false)
            {
                if (italic == true & underline == true)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    bold = true;
                }
                else if (italic == true & underline == false)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Italic);
                    bold = true;
                }
                else if (italic == false & underline == true)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Underline);
                    bold = true;
                }
                else if (italic == false & underline == false)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold);
                    bold = true;
                }
            }
            else
            {
                if (italic == true && underline == true)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular | FontStyle.Italic | FontStyle.Underline);
                    bold = false;
                }
                else if (italic == true && underline == false)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular | FontStyle.Italic);
                    bold = false;
                }
                else if (italic == false && underline == true)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular | FontStyle.Underline);
                    bold = false;
                }
                else if (italic == false && underline == false)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular);
                    bold = false;
                }
            }
        }
        private void Italic()
        {
            String fontName = rtxbFile.Font.Name;
            float fontSize = rtxbFile.Font.Size;
            bool bold = rtxbFile.SelectionFont.Bold;
            bool underline = rtxbFile.SelectionFont.Underline;
            bool italic = rtxbFile.SelectionFont.Italic;

            if (italic == false)
            {
                if (bold == true & underline == true)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
                    italic = true;
                }
                else if (bold == true & underline == false)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic | FontStyle.Bold);
                    italic = true;
                }
                else if (bold == false & underline == true)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic | FontStyle.Underline);
                    italic = true;
                }
                else if (bold == false & underline == false)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic);
                    italic = true;
                }
            }
            else
            {
                if (bold == true && underline == true)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular | FontStyle.Bold | FontStyle.Underline);
                    italic = false;
                }
                else if (bold == true && underline == false)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular | FontStyle.Bold);
                    italic = false;
                }
                else if (bold == false && underline == true)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular | FontStyle.Underline);
                    italic = false;
                }
                else if (bold == false && underline == false)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular);
                    italic = false;
                }
            }
        }
        private void Underline()
        {
            String fontName = rtxbFile.Font.Name;
            float fontSize = rtxbFile.Font.Size;
            bool bold = rtxbFile.SelectionFont.Bold;
            bool underline = rtxbFile.SelectionFont.Underline;
            bool italic = rtxbFile.SelectionFont.Italic;

            if (underline == false)
            {
                if (bold == true & italic == true)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic);
                    underline = true;
                }
                else if (bold == true & underline == false)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Underline | FontStyle.Bold);
                    underline = true;
                }
                else if (bold == false & italic == true)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Underline | FontStyle.Italic);
                    underline = true;
                }
                else if (bold == false & italic == false)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Underline);
                    underline = true;
                }
            }
            else
            {
                if (bold == true && italic == true)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular | FontStyle.Bold | FontStyle.Italic);
                    underline = false;
                }
                else if (bold == true && italic == false)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular | FontStyle.Bold);
                    underline = false;
                }
                else if (bold == false && italic == true)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular | FontStyle.Italic);
                    underline = false;
                }
                else if (bold == false && italic == false)
                {
                    rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular);
                    underline = false;
                }
            }
        }
        private void ChangeCollorsFormatButtons(ToolStripButton tsbutton)
        {
            if(tsbutton.BackColor == System.Drawing.SystemColors.AppWorkspace)
            {
                tsbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            }
            else
            {
                tsbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            }  
        }
        private void AlignLeft()
        {
            rtxbFile.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void AlignCenter()
        {
            rtxbFile.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void AlignRight()
        {
            rtxbFile.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void AlignJustify()
        {
            ///In development
        }
        //--//
    }  
}
