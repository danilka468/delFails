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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        FolderBrowserDialog FBD;
        public Form1()
        {
            InitializeComponent();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                tbFolder.AppendText(FBD.SelectedPath);
            }
        }

        private void btAct_Click(object sender, EventArgs e)
        {
            String path = tbFolder.Text;

            if (cbUse.Checked)
            {
                {
                                   
                    
                }
            }


        }       

        private void tbTimer_TextChanged_1(object sender, EventArgs e)
        {
            String path = tbFolder.Text;
            String t = tbTimer.Text;
            int time = Convert.ToInt32(t);
             
            while (cbUse.Checked)
            {
                Directory.Delete(path, true); //true - если директория не пуста (удалит и файлы и папки)
                Directory.CreateDirectory(path);
                rtb1.AppendText(time.ToString());
            }            
        }
    }
}

