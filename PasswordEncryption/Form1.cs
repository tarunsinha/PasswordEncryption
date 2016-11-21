using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMI.MRM.Business;

namespace PasswordEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecurityBL secBL = new SecurityBL();
            textBox3.Text = secBL.ComputeHash(textBox2.Text,textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.SelectAll();
            textBox3.Copy();
            ToolTip toolTip = new ToolTip();
            toolTip.Show(String.Empty, textBox2,2000);
            toolTip.Show("Copied Selection",textBox2);
        }
    }
}
