using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///i clicked the wrong thing
        }
    }
}
