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
    [DefaultEvent("ValueChanged")]
    public partial class NumericUpDownEx : UserControl
    {
        // Fields
        private BorderSkin _borderSkin;

        //Events
        [Category("自定义"), Description("在up-down控件值更改时发生"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public event EventHandler ValueChanged
        {
            add { this.numContent.ValueChanged += value; }
            remove { this.numContent.ValueChanged -= value; }
        }
        public new event EventHandler Leave
        {
            add { this.numContent.Leave += value; }
            remove { this.numContent.Leave -= value; }
        }

        // Methods
        public NumericUpDownEx()
        {
            InitializeComponent();
            this._borderSkin = new BorderSkin(this);
            this._borderSkin.ColorSkin.NomalColor = Color.LightGray;
        }

        // Properties
        [Category("自定义"), Description("边框样式"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BorderSkin BorderSkin
        {
            get
            {
                return panelBorder.BorderSkin;
            }
        }
        [Category("自定义"), Description("数值up-down控件的当前值"), Browsable(true)]
        public decimal Value
        {
            get 
            {
                return this.numContent.Value;
            }
            set
            {
                this.numContent.Value = value;
            }
        }
        [Category("自定义"), Description("指示要显示的小数位数"), Browsable(true)]
        public int DecimalPlaces 
        {
            get
            {
                return this.numContent.DecimalPlaces;
            }
            set
            {
                this.numContent.DecimalPlaces = value;
            }
        }
        [Category("自定义"), Description("指示数值up-down控件的值是否以16进制显示"), Browsable(true)]
        public bool Hexadecimal
        {
            get
            {
                return this.numContent.Hexadecimal;
            }
            set
            {
                this.numContent.Hexadecimal = value;
            }
        }
        [Category("自定义"), Description("指示每单击一下增加减少的数量"), Browsable(true)]
        public decimal Increment
        {
            get
            {
                return this.numContent.Increment;
            }
            set
            {
                this.numContent.Increment = value;
            }
        }
        [Category("自定义"), Description("指示当按下上箭头键和下箭头键时,up-down控件是否增加和减少该值"), Browsable(true)]
        public bool InterceptArrowKeys
        {
            get
            {
                return this.numContent.InterceptArrowKeys;
            }
            set
            {
                this.numContent.InterceptArrowKeys = value;
            }
        }
        [Category("自定义"), Description("指示up-down控件的最大值"), Browsable(true)]
        public decimal Maximum
        {
            get
            {
                return this.numContent.Maximum;
            }
            set
            {
                this.numContent.Maximum = value;
            }
        }
        [Category("自定义"), Description("指示up-down控件的最小值"), Browsable(true)]
        public decimal Minimum
        {
            get
            {
                return this.numContent.Minimum;
            }
            set
            {
                this.numContent.Minimum = value;
            }
        }
        [Category("自定义"), Description("指示编辑框是否为只读的"), Browsable(true)]
        public bool ReadOnly 
        {
            get
            {
                return this.numContent.ReadOnly;
            }
            set
            {
                this.numContent.ReadOnly = value;
            }
        }
        [Category("自定义"), Description("指示文本在编辑框中的对齐方式"), Browsable(true)]
        public HorizontalAlignment TextAlign
        {
            get
            {
                return this.numContent.TextAlign;
            }
            set
            {
                this.numContent.TextAlign = value;
            }
        }
        [Category("自定义"), Description("指示是否在每三位10进制数之间插入千位分隔符"), Browsable(true)]
        public bool ThousandsSeparator
        {
            get
            {
                return this.numContent.ThousandsSeparator;
            }
            set
            {
                this.numContent.ThousandsSeparator = value;
            }
        }

        [Category("自定义"), Description("指示up-down控件如何相对于其编辑框定位“上移”和“下移”按钮"), Browsable(true)]
        public LeftRightAlignment UpDownAlign
        {
            get
            {
                return this.numContent.UpDownAlign;
            }
            set
            {
                this.numContent.UpDownAlign = value;
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
                this.numContent.BackColor = base.BackColor = value;
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
                this.numContent.ForeColor = base.ForeColor = value;
            }
        }
    }
}
