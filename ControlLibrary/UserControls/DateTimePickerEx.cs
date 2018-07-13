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
    public partial class DateTimePickerEx : UserControl
    {
        // Fields
        private BorderSkin _borderSkin;

        // Methods
        public DateTimePickerEx()
        {
            InitializeComponent();
            this._borderSkin = new BorderSkin(this);
            this.BackColor = Color.White;
        }
        // Properties
        [Category("自定义"), Description("边框"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BorderSkin BorderSkin
        {
            get
            {
                return panelBorder.BorderSkin;
            }
        }

        [Category("自定义"), Description("日期时间格式"), Browsable(true)]
        public string CustomFormat
        {
            get
            {
                return datePickerHead.CustomFormat;
            }
            set
            {
                datePickerHead.CustomFormat = value;
            }
        }

        [Category("自定义"), Description("确定时间和日期是用标准显示还是用自定义格式显示"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public DateTimePickerFormat Format
        {
            get
            {
                return datePickerHead.Format;
            }
            set
            {
                datePickerHead.Format = value;
            }
        }

        [Category("自定义"), Description("此控件的当前时间.时间值"), Browsable(true)]
        public DateTime Value
        {
            get
            {
                return datePickerHead.Value;
            }
            set
            {
               datePickerHead.Value = value;
            }
        }

        [Category("自定义"), Description("指示是否为修改控件值显示数字显示框，而不是显示下拉日历"), Browsable(true)]
        public bool ShowUpDown 
        {
            get
            {
                return this.datePickerHead.ShowUpDown;
            }
            set
            {
                this.datePickerHead.ShowUpDown = value;
            }
        }

        [Category("自定义"), Description("用于显示日历的字体"), Browsable(true)]
        public Font CalendarFont
        {
            get
            {
                return this.datePickerHead.CalendarFont;
            }
            set
            {
                this.datePickerHead.CalendarFont = value;
            }
        }

        [Category("自定义"), Description("用于显示月份中文本的颜色"), Browsable(true)]
        public Color CalendarForeColor
        {
            get
            {
                return this.datePickerHead.CalendarForeColor;
            }
            set
            {
                this.datePickerHead.CalendarForeColor = value;
            }
        }

        [Category("自定义"), Description("月份中显示的背景色"), Browsable(true)]
        public Color CalendarMonthBackground
        {
            get
            {
                return this.datePickerHead.CalendarMonthBackground;
            }
            set
            {
                this.datePickerHead.CalendarMonthBackground = value;
            }
        }

        [Category("自定义"), Description("日历标题中显示的背景色"), Browsable(true)]
        public Color CalendarTitleBackColor
        {
            get
            {
                return this.datePickerHead.CalendarTitleBackColor;
            }
            set
            {
                this.datePickerHead.CalendarTitleBackColor = value;
            }
        }
        [Category("自定义"), Description("用于显示日历标题中文本的颜色"), Browsable(true)]
        public Color CalendarTitleForeColor
        {
            get
            {
                return this.datePickerHead.CalendarTitleForeColor;
            }
            set
            {
                this.datePickerHead.CalendarTitleForeColor = value;
            }
        }

        [Category("自定义"), Description("用于显示前接日期和后续日期文本的颜色，前接日期和后续日期是指在当前月历上显示的上一个月和下一个月的日期"), Browsable(true)]
        public Color CalendarTrailingForeColor
        {
            get
            {
                return this.datePickerHead.CalendarTrailingForeColor;
            }
            set
            {
                this.datePickerHead.CalendarTrailingForeColor = value;
            }
        }

        [Category("自定义"), Description("用于显示控件背景色"), Browsable(false)]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                this.datePickerHead.BackColor= base.BackColor = value;
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
                this.datePickerHead.ForeColor = base.ForeColor = value;
            }
        }
    }
}
