using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;
using System.Drawing.Design;
using System.Drawing;

namespace ControlLibrary
{
    [DefaultEvent("SelectedIndexChanged")]
    public class ComboBoxEx:TextBoxBtnEx
    {
        // Fields
        private ListBox _listbox;
        private ToolStripControlHost _toolStripControlHost;
        private ToolStripDropDown _toolStripDropDown;
        private int _maxDropDownItems;

        //Events
        [Category("自定义"), Description("SelectIndex值更改时发生"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public event EventHandler SelectedIndexChanged
        {
            add { this._listbox.SelectedIndexChanged += value; }
            remove { this._listbox.SelectedIndexChanged -= value; }
        }

        // Methods
        public ComboBoxEx():base()
        {
            this._listbox = new ListBox();
            this.Controls.Add(_listbox);
            this._toolStripControlHost = new ToolStripControlHost(this._listbox);
            this._toolStripDropDown = new ToolStripDropDown();
            this._toolStripControlHost.Margin = Padding.Empty;
            this._toolStripControlHost.Padding = Padding.Empty;
            this._toolStripControlHost.AutoSize = false;
            this._toolStripDropDown.Padding = Padding.Empty;
            this._toolStripDropDown.Items.Add(this._toolStripControlHost);
            this._listbox.SelectedIndexChanged += new EventHandler(this.listbox_SelectedIndexChanged);
            base.BtnContent.Click += new EventHandler(this.ComboBoxEx1_BtnContent_Click);
            base.ReadOnly = true;
            _maxDropDownItems = 8;
        }
        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_toolStripDropDown != null)
            {
                this.Text = _listbox.GetItemText(_listbox.SelectedItem);
                _toolStripDropDown.Close();
            }
        }
        private void ComboBoxEx1_BtnContent_Click(object sender, EventArgs e)
        {
            this._listbox.Size = new Size(base.Width, this._listbox.ItemHeight * (_maxDropDownItems + 1));
            this._toolStripDropDown.Show(this, 0, this.Height+1);
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
        [Category("自定义"), DefaultValue((string)null), RefreshProperties(RefreshProperties.Repaint), AttributeProvider(typeof(IListSource))]
        public object DataSource
        {
            get
            {
                return this._listbox.DataSource;
            }
            set
            {
                this._listbox.DataSource = value;
            }
        }
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Category("自定义"), Description("指示要为此控件中的项显示的属性"),DefaultValue(""), Browsable(true)]
        public string DisplayMember
        {
            get
            {
                return this._listbox.DisplayMember;
            }
            set
            {
                this._listbox.DisplayMember = value;
            }
        }
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Category("自定义"), Description("指示用作控件中项的实际值的属性"), DefaultValue(""), Browsable(true)]
        public string ValueMember
        {
            get
            {
                return this._listbox.ValueMember;
            }
            set
            {
                this._listbox.ValueMember = value; 
            }
        }
        [Category("自定义"), Description("指示此控件的选择项"), Browsable(false), Bindable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem 
        {
            get
            {
                return this._listbox.SelectedItem;
            }
            set
            {
                this._listbox.SelectedItem = value;
            }
        }
        [Category("自定义"), Description("当前选定项的从零开始的索引"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get
            {
                return this._listbox.SelectedIndex;
            }
            set
            {
                this._listbox.SelectedIndex = value;
            }
        }
        [Category("自定义"), Description("获取或设置一个值，该值指示 System.Windows.Forms.ListBox 中的项是否按字母顺序排序"),DefaultValue(false), Browsable(true)]
        public bool Sorted 
        {
            get
            {
                return this._listbox.Sorted;
            }
            set
            {
                this._listbox.Sorted = value;
            }
        }
        [Category("自定义"), Description("控制组合框的外观和功能"),Browsable(true)]
        public ComboBoxStyle DropDownStyle
        {
            get
            {
                return this.ReadOnly == true ? ComboBoxStyle.DropDownList : ComboBoxStyle.DropDown;
            }
            set
            {
                this.ReadOnly = value == ComboBoxStyle.DropDownList ? true : false;
            }
        }

        [Category("自定义"), Description("如果此属性为true,FormatString的值则用来将DisplayMember转换为可以显示的值"), Browsable(true)]
        public bool FormattingEnabled
        {
            get
            {
                return this._listbox.FormattingEnabled;
            }
            set
            {
                this._listbox.FormattingEnabled = value;
            }
        }

        [Category("自定义"), Description("格式说明符，指示显示值的方式"), Browsable(true)]
        public string FormatString
        {
            get
            {
                return this._listbox.FormatString;
            }
            set
            {
                this._listbox.FormatString = value;
            }
        }

        [Category("自定义"), Description("在下拉列表中显示最多的项"), Browsable(true)]
        public int MaxDropDownItems
        {
            get
            {
                return _maxDropDownItems;
            }
            set
            {
                _maxDropDownItems = value;
            }
        }

        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                if (this._listbox != null)
                {
                    this._listbox.Font = value;
                }
            }
        }
    }
}
