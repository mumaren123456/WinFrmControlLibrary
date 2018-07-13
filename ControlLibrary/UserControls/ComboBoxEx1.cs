using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Design;

namespace ControlLibrary
{
    public class ComboBoxEx1 : TextBoxBtnEx
    {
        private ToolScriptListBox _listbox;
        private ToolStripDropDown _toolStripDropDown;

        public ComboBoxEx1()
        {
            this._listbox = new ToolScriptListBox();
            this._listbox.Font = this.Font;
            this._listbox.Margin = Padding.Empty;
            this._listbox.Padding = Padding.Empty;
            this._listbox.AutoSize = false;
            this._listbox.ComboBox.DataSource = new object[] { "1","2","3"};
            this._toolStripDropDown = new ToolStripDropDown();
            this._toolStripDropDown.Padding = Padding.Empty;
            this._toolStripDropDown.Items.Add(this._listbox);
            object str = this._listbox.ComboBox.DataSource;
            base.BtnContent.Click += new EventHandler(this.ComboBoxEx1_BtnContent_Click);
            base.ReadOnly = true;
        }

        private void ComboBoxEx1_BtnContent_Click(object sender, EventArgs e)
        {
            this._listbox.Width = this.Width;
            this._toolStripDropDown.Show(this, 0, this.Height);
            this._toolStripDropDown.Focus();
        }

        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)), MergableProperty(false)]
        [Category("自定义"), Description("组合框中的项"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ListBox.ObjectCollection Items
        {
            get
            {
                return _listbox.Items;
            }
        }
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ListBox ComboBox
        {
            get
            {
                return this._listbox.ComboBox;
            }
        }
    }
}
