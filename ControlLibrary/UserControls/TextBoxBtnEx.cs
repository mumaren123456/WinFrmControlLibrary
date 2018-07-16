using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Design;

namespace ControlLibrary
{
    [DefaultEvent("RightBtnClick")]
    [DesignerAttribute(typeof(UserControlDesigner))]
    public partial class TextBoxBtnEx : UserControlEx
    {
        // Fields
        private BorderSkin _borderSkin;
        private bool _readOnly;

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
        [Category("自定义"), Description("右边按钮点击时所引发的事件"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public event EventHandler RightBtnClick
        {
            add { this.btnContent.Click += value; }
            remove { this.btnContent.Click -= value; }
        }

        // Methods
        public TextBoxBtnEx()
        {
            InitializeComponent();
            this._borderSkin = new BorderSkin(this);
            _readOnly = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            if (this.BorderStyle == BorderStyle.None)
            {
                using (var p = new Pen(this._borderSkin.ColorSkin.NomalColor, this._borderSkin.LineWidth))
                {
                    g.DrawRectangle(p, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                }
            }
            this.btnContent.Width = this.btnContent.Height = this.txtContent.Height;
            this.txtContent.Width = (base.ClientSize.Width - this.btnContent.Width) - 20;
        }

        //Properties
        [Category("自定义"), Description("边框样式(BorderStyle为None时有效)"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BorderSkin BorderSkin { get { return _borderSkin; } }
        [Category("自定义"), Description("按钮内容框属性"), Browsable(false)]
        public ButtonEx BtnContent { get { return btnContent; } }
        [Category("自定义"), Description("颜色样式"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ColorSkin ColorSkin { get { return this.btnContent.ColorSkin; } }
        [Category("自定义"), Description("指示是否能够编辑控件中的文本"), Browsable(true)]
        public bool ReadOnly
        {
            get
            {
                return txtContent.ReadOnly;
            }
            set 
            {
                if (_readOnly != value)
                {
                    _readOnly = value;
                }
                txtContent.ReadOnly = _readOnly;
            }
        }
        [Category("自定义"), Description("ICON样式"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IconSkin IconSkin { get { return this.btnContent.IconSkin; } }
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
        [Category("自定义"), Description("与控件关联的文本"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Localizable(true), Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public override string Text
        {
            get
            {
                return txtContent.Text;
            }
            set
            {
                txtContent.Text = value;
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
                this.txtContent.ForeColor = base.ForeColor = value;
            }
        }
        public override bool Focused
        {
            get
            {
                return this.txtContent.Focused;
            }
        }
        [Category("自定义"), Description("获取或设置文本框中选定的文本起始点"), Browsable(false)]
        public int SelectionStart
        {
            get
            {
                return this.txtContent.SelectionStart; ;
            }
            set
            {
                txtContent.SelectionStart = value;
            }
        }
        [Category("自定义"), Description("获取或设置文本框中选定的字符数"), Browsable(false)]
        public int SelectionLength
        {
            get
            {
                return this.txtContent.SelectionLength; ;
            }
            set
            {
                txtContent.SelectionLength = value;
            }
        }
    }
}
