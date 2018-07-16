using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinformTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxEx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("123");
        }
    }
}
