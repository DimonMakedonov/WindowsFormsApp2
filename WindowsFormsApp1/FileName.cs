using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FileName : Form
    {
        public string fileName = "";

        public FileName()
        {
            InitializeComponent();
        }

        private void FileName_FormClosing(object sender, FormClosingEventArgs e)
        {
            fileName = textBox1.Text;
        }
    }
}
