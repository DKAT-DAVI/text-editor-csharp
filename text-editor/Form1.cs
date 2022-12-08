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

        }
        //--//

        //-- tmnuAlignCenter
        private void tmnuAlignCenter_Click(object sender, EventArgs e)
        {

        }
        //--//

        //-- tmnuAlignRight
        private void tmnuAlignRight_Click(object sender, EventArgs e)
        {

        }
        //--//

        //-- tmnuAlignJustify
        private void tmnuAlignJustify_Click(object sender, EventArgs e)
        {

        }
        //
        //--//

        //-- Bold
        private void tmnuBold_Click(object sender, EventArgs e)
        {
            Bold();
        }
        //--//

        //-- Italic
        private void tmnuItalic_Click(object sender, EventArgs e)
        {
            Italic();
        }
        //--//

        //-- Underline
        private void tmnuUnderline_Click(object sender, EventArgs e)
        {
            Underline();
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
        }
        //--//

        //-- btnItalic
        private void btnItalic_Click(object sender, EventArgs e)
        {
            Italic();
        }
        //--//

        //-- btnUnderline
        private void btnUnderline_Click(object sender, EventArgs e)
        {
            Underline();
        }
        //--//

        //-- btnAlignLeft
        private void btnLeft_Click(object sender, EventArgs e)
        {

        }
        //--//

        //-- btnAlignCenter
        private void btnCenter_Click(object sender, EventArgs e)
        {

        }
        //--//

        //-- btnAlignRight
        private void btnRight_Click(object sender, EventArgs e)
        {

        }
        //--//

        //-- btnJustify
        private void bntJustify_Click(object sender, EventArgs e)
        {

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

            if (bold == false)
            {
                rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold);
                bold = true;
            }
            else
            {
                rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular);
            }
        }
        private void Italic()
        {
            String fontName = rtxbFile.Font.Name;
            float fontSize = rtxbFile.Font.Size;
            bool italic = rtxbFile.SelectionFont.Italic;

            if (italic == false)
            {
                rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic);
                italic = true;
            }
            else
            {
                rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular);
            }
        }
        private void Underline()
        {
            String fontName = rtxbFile.Font.Name;
            float fontSize = rtxbFile.Font.Size;
            bool underline = rtxbFile.SelectionFont.Underline;

            if (underline == false)
            {
                rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Underline);
                underline = true;
            }
            else
            {
                rtxbFile.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular);
            }
        }
        //--//
    }  
}
