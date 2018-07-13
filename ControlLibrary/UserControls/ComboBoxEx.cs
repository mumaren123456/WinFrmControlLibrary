using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;
using System.Drawing.Design;

namespace ControlLibrary
{
    public class ComboBoxEx:TextBoxBtnEx
    {
        // Fields
        private ListBox _listbox;
        private ToolStripControlHost _toolStripControlHost;
        private ToolStripDropDown _toolStripDropDown;


        // Methods
        public ComboBoxEx()
        {
            this._listbox = new ListBox();
            this._listbox.Font = this.Font;
            this._listbox.SelectedIndexChanged += new EventHandler(this.listbox_SelectedIndexChanged);
            base.BtnContent.Click += new EventHandler(this.ComboBoxEx1_BtnContent_Click);
            base.ReadOnly = true;
        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TextContent.Text = _listbox.SelectedItem.ToString();
            _toolStripDropDown.Close();
        }
        private void ComboBoxEx1_BtnContent_Click(object sender, EventArgs e)
        {
            this._listbox.Width = base.Width;
            this._toolStripControlHost = new ToolStripControlHost(this._listbox);
            this._toolStripDropDown = new ToolStripDropDown();
            this._toolStripControlHost.Margin = Padding.Empty;
            this._toolStripControlHost.Padding = Padding.Empty;
            this._toolStripControlHost.AutoSize = false;
            this._toolStripDropDown.Padding = Padding.Empty;
            this._toolStripDropDown.Items.Add(this._toolStripControlHost);
            this._toolStripDropDown.Show(this, 0, this.Height);
            this._toolStripDropDown.Focus();
        }
        // Properties
        public ListBox Content { get { return _listbox; } }
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
                return this._listbox;
            }
        }
    }
}
