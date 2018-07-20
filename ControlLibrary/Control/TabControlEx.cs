using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace ControlLibrary
{
    public class TabControlEx:TabControl
    {
        // Fields
        private BorderSkin _borderSkin;
        private Color _backgroundColor;

        // Methods
        public TabControlEx()
        {
            _borderSkin = new BorderSkin(this);
            this._backgroundColor = Color.White;
            this._borderSkin.ColorSkin.ActiveColor = Color.FromArgb(254, 139, 37);
            this._borderSkin.ColorSkin.NomalColor = Color.FromArgb(47, 53, 58);

            base.SetStyle(
                ControlStyles.UserPaint |                      // 控件将自行绘制，而不是通过操作系统来绘制  
                ControlStyles.OptimizedDoubleBuffer |          // 该控件首先在缓冲区中绘制，而不是直接绘制到屏幕上，这样可以减少闪烁  
                ControlStyles.AllPaintingInWmPaint |           // 控件将忽略 WM_ERASEBKGND 窗口消息以减少闪烁  
                ControlStyles.ResizeRedraw |                   // 在调整控件大小时重绘控件  
                ControlStyles.SupportsTransparentBackColor,    // 控件接受 alpha 组件小于 255 的 BackColor 以模拟透明  
                 true);                                         // 设置以上值为 true  
            base.UpdateStyles();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.SelectedIndex != -1)
            {
                using (SolidBrush sb = new SolidBrush(this._backgroundColor), sbfont = new SolidBrush(this._borderSkin.ColorSkin.NomalColor), sbacfont = new SolidBrush(this._borderSkin.ColorSkin.ActiveColor))
                {
                    e.Graphics.FillRectangle(sb, this.ClientRectangle);

                    for (int i = 0; i < this.TabCount; i++)
                    {
                        Rectangle bounds = this.GetTabRect(i);
                        PointF textPoint = new PointF();
                        SizeF textSize = TextRenderer.MeasureText(this.TabPages[i].Text, this.Font);

                        // 注意要加上每个标签的左偏移量X  
                        textPoint.X = bounds.X + (bounds.Width - textSize.Width) / 2;
                        textPoint.Y = bounds.Bottom - textSize.Height - this.Padding.Y;
                        if (i == this.SelectedIndex)
                        {
                            e.Graphics.DrawLine(new Pen(sbacfont, 2), bounds.X, bounds.Y + bounds.Height, bounds.X + bounds.Width, bounds.Y + bounds.Height);
                            e.Graphics.DrawString(this.TabPages[i].Text, this.Font, sbacfont, textPoint.X, textPoint.Y);
                        }
                        else
                        {
                            e.Graphics.DrawString(this.TabPages[i].Text, this.Font, sbfont, textPoint.X, textPoint.Y);
                        }
                    }
                }
            }
        }
        // Properties
        [Category("自定义"), Description("边框样式"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BorderSkin BorderSkin
        {
            get
            {
                return _borderSkin;
            }
        }

        [Category("自定义"), Description("获取或者设置获取焦点时的背景色"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BackGroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
            }
        }
    }
}
