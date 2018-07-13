using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Design;

namespace ControlLibrary
{
    public class ToolScriptListBox : ToolStripControlHost
    {
        public ToolScriptListBox() : base(new ListBox()) { }

        public ListBox ListBoxControl
        {
            get
            {
                return Control as ListBox;
            }
        }

        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)), MergableProperty(false)]
        [Category("自定义"), Description("组合框中的项"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ListBox.ObjectCollection Items
        {
            get
            {
                return ListBoxControl.Items;
            }
        }
        public new int Width 
        {
            get
            {
                return ListBoxControl.Width;
            }
            set
            {
                this.ListBoxControl.Width = value;
            }
        }
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ListBox ComboBox
        {
            get
            {
                return ListBoxControl;
            }
        }
    }
}
