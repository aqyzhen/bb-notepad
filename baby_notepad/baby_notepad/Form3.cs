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

namespace baby_notepad
{
    public partial class Form3 : Form
    {

        public Form3()

        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] files = Directory.GetFiles(FBD.SelectedPath);
                string[] dirs = Directory.GetDirectories(FBD.SelectedPath);

                foreach(string file in files)
                {
                    listBox1.Items.Add(Path.GetFileName(file));
                }

                foreach (string dir in dirs)
                {
                    listBox1.Items.Add(Path.GetFileName(dir));
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stream myStream;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) !=null) {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    richTextBox1.Text = filetext;
                }
            }
                    
                    
                    }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    
}
