using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlLibrary
{
    [DefaultEvent("TextChanged")]
    public partial class TextBoxEx : UserControl
    {
        // Fields
        private BorderSkin _borderSkin;

        //Events
        [Category("自定义"), Description("在控件上更改Text属性时所引发的事件"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new event EventHandler TextChanged
        {
            add { this.txtContent.TextChanged += value; }
            remove { this.txtContent.TextChanged -= value; }
        }
        public new event EventHandler Leave
        {
            add { this.txtContent.Leave += value; }
            remove { this.txtContent.Leave -= value; }
        }
        public new event EventHandler MouseLeave
        {
            add { this.txtContent.MouseLeave += value; }
            remove { this.txtContent.MouseLeave -= value; }
        }
        // Methods
        public TextBoxEx()
        {
            InitializeComponent();
            this._borderSkin = new BorderSkin(this);
            this._borderSkin.ColorSkin.NomalColor = this.panelBorder.BorderSkin.ColorSkin.NomalColor = Color.LightGray;
        }

         //Properties
        [Category("自定义"), Description("文本内容框"), Browsable(false)]
        public TextBox TextContent { get { return txtContent; } }
        [Category("自定义"), Description("边框样式"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BorderSkin BorderSkin { get { return panelBorder.BorderSkin; } }
        [Category("自定义"), Description("指定可以在编辑控件时输入的最大字符数"), Browsable(true)]
        public int MaxLength
        {
            get
            {
                return this.txtContent.MaxLength;
            }
            set
            {
                this.txtContent.MaxLength = value;
            }
        }
        [Category("自定义"), Description("指示将为单行编辑控件的密码输入显示的字符"), Browsable(true)]
        public char PassWordChar
        {
            get
            {
                return this.txtContent.PasswordChar;
            }
            set
            {
                this.txtContent.PasswordChar = value;
            }
        }
        [Category("自定义"), Description("指示是否能够编辑控件中的文本"), Browsable(true)]
        public bool ReadOnly
        {
            get
            {
                return txtContent.ReadOnly;
            }
            set
            {
                txtContent.ReadOnly = value;
            }
        }
        [Category("自定义"), Description("指示编辑控件的文本是否以默认的密码字符显示"), Browsable(true)]
        public bool UseSystemPasswordChar
        {
            get
            {
                return txtContent.UseSystemPasswordChar;
            }
            set
            {
                txtContent.UseSystemPasswordChar = value;
            }
        }
        [Category("自定义"), Description("与控件关联的文本"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                if (txtContent.Text.Contains("TextBoxEx"))
                {
                    txtContent.Text = "";
                }
                return this.txtContent.Text; ;
            }
            set
            {
                txtContent.Text = value;
            }
        }
        [Category("自定义"), Description("指示当编辑控件失去焦点时，应隐藏选定内容"), Browsable(true)]
        public bool HideSelection
        {
            get
            {
                return this.txtContent.HideSelection; ;
            }
            set
            {
                txtContent.HideSelection = value;
            }
        }
        [Category("自定义"), Description("指示应该如何对齐编辑控件的文本"), Browsable(true)]
        public HorizontalAlignment TextAlign
        {
            get
            {
                return this.txtContent.TextAlign; ;
            }
            set
            {
                txtContent.TextAlign = value;
            }
        }
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                this.txtContent.BackColor = base.BackColor = value;
            }
        }
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
               this.txtContent.ForeColor=base.ForeColor = value;
            }
        }
        public override bool Focused
        {
            get
            {
                return this.txtContent.Focused;
            }
        }
    }
}
