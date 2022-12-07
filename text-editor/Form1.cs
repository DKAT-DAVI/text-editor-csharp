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
        StreamReader reading = null;

        public Form1()
        {
            InitializeComponent();
        }

        //-- tmnuNew
        private void tmnuNew_Click(object sender, EventArgs e)
        {
            NewFile();
        }
        //--//

        //-- tmnuSave
        private void tmnuSave_Click(object sender, EventArgs e)
        {
            SaveFile();
               
        }
        //--//

        //-- btnSave
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        //

        //-- rtxbFile
        private void btnNew_Click(object sender, EventArgs e)
        {
            NewFile();
        }
        //--//
        
        //-- Methods()
        private void NewFile()
        {
            rtxbFile.Clear();
            rtxbFile.Focus();
        }
        private void SaveFile()
        {
            try
            {
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                    StreamWriter cfb_streamWriter = new StreamWriter(file);

                    cfb_streamWriter.Flush();

                    cfb_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    cfb_streamWriter.Write(this.rtxbFile.Text);

                    cfb_streamWriter.Flush();
                    cfb_streamWriter.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error during the save: {error.Message}", "Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //--//
    }
}
