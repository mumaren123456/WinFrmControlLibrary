using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformTest
{
    public partial class Form1 : Form
    {
        ControlLibrary.ToolScriptListBox lb;
        ToolStripComboBox cb;

        ToolStripDropDown tsd;
        public Form1()
        {
            InitializeComponent();
            tsd=new ToolStripDropDown();
            cb = new ToolStripComboBox();
            comboBoxEx1.ComboBox.DataSource = new string[] { "1", "2" };
            lb = new ControlLibrary.ToolScriptListBox();
            tsd.Items.Add(cb);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("id");
            DataColumn dc2 = new DataColumn("name");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            DataRow dr1 = dt.NewRow();
            dr1["id"] = "1";
            dr1["name"] = "aaaaaa";
            DataRow dr2 = dt.NewRow();
            dr2["id"] = "2";
            dr2["name"] = "bbbbbb";
            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            cb.ComboBox.DataSource = dt;
            cb.ComboBox.ValueMember = "id";
            cb.ComboBox.DisplayMember = "name";
            tsd.Show();
        }
    }
    public class Info
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
