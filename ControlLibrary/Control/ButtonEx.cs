using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ControlLibrary
{
    public class ButtonEx : Button
    {
        //Fields
        private MouseActionEnum _maction;   //按钮当前状态
        private string _toolTipText;
        private ToolTip _toolTip;       //鼠标移动上去的提示文字
        private int _groupNum;
        private int _activeleftLineSize;
        private bool _keepPressColor;
        private BorderSkin _borderSkin;
        private IconSkin _iconSkin;
        private ColorSkin _colorSkin;
        private Color _activeBackColor;
        private bool _btnPressState;

        // Methods
        public ButtonEx()
        {
            this.Size = new Size(130, 63);
            this._toolTip = new ToolTip();
            this._toolTipText = "";
            this._activeleftLineSize = 5;
            this._borderSkin = new BorderSkin(this);
            this._iconSkin = new IconSkin(this);
            this._colorSkin = new ColorSkin(this);
            this._activeBackColor = Color.Transparent;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            base.OnPaintBackground(e);
            Graphics g = e.Graphics;
            using (SolidBrush sb = new SolidBrush(this._colorSkin.NomalColor))
            {
                if (_maction == MouseActionEnum.Enter || _maction == MouseActionEnum.Down || (this.BtnPressState && _keepPressColor))
                {
                    using (Pen pen = new Pen(this._activeBackColor, this.ClientRectangle.Width))
                    {
                        g.DrawRectangle(pen, this.ClientRectangle);
                    }
                    sb.Color = this._colorSkin.ActiveColor;
                    if (this._activeleftLineSize > 0)
                    {
                        using (Pen pen = new Pen(this._colorSkin.ActiveColor, this._activeleftLineSize))
                        {
                            g.DrawLine(pen, new Point(0, 0), new Point(0, this.Height));
                        }
                    }
                }
                g.DrawString(this.Text, this.Font, sb, this.ClientRectangle, CommonHelper.AlignDrawingPoint(this.TextAlign));
                g.DrawString(this._iconSkin.IconCode, this._iconSkin.IconFont, sb, this._iconSkin.IconPoint);
                using (Pen pen = new Pen(this._borderSkin.ColorSkin.NomalColor, this._borderSkin.LineWidth))
                {
                    if (this._borderSkin.ShowLeftLine)
                        g.DrawLine(pen, new Point(0, 0), new Point(0, this.Height));
                    if (this._borderSkin.ShowTopLine)
                        g.DrawLine(pen, new Point(0, 0), new Point(this.Width, 0));
                    if (this._borderSkin.ShowBottomLine)
                        g.DrawLine(pen, new Point(0, this.Height - 1), new Point(this.Width, this.Height - 1));
                    if (this._borderSkin.ShowRightLine)
                        g.DrawLine(pen, new Point(this.Width - 1, 0), new Point(this.Width - 1, this.Height));
                }
                this._toolTip.ReshowDelay = 1000;
                this._toolTip.SetToolTip(this, this.ToolTipText);
            }
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Invalidate(false);
            this._maction = MouseActionEnum.Leave;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Invalidate(false);
            this._maction = MouseActionEnum.Enter;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            //注意：这里如果用MouseClick，则会出现重绘无效，即使加上立即重绘也不行，必须禁用鼠标右键，否则左竖线会不消失
            if (e.Button == MouseButtons.Left)
            {
                base.OnMouseDown(e);
                this._maction = MouseActionEnum.Down;
                Graphics g = this.CreateGraphics();
                if (this.Parent != null)
                {
                    foreach (Control ctl in this.Parent.Controls)
                    {
                        if (ctl is ButtonEx && ((ButtonEx)ctl).GroupNum > 0 && ((ButtonEx)ctl).GroupNum == this.GroupNum && ((ButtonEx)ctl).Name != this.Name)
                        {
                            ((ButtonEx)ctl).BtnPressState = false;
                        }
                    }
                }
                this.BtnPressState = true;
            }
        }

        // Properties
        [Category("自定义"), Description("边框样式"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BorderSkin BorderSkin { get { return _borderSkin; } }
        [Category("自定义"), Description("ICON样式"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IconSkin IconSkin { get { return _iconSkin; } }
        [Category("自定义"), Description("颜色样式"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ColorSkin ColorSkin { get { return _colorSkin; } }
        [Category("自定义"), Description("获取或者设置按钮组序号,父控件相同且按钮组序号大于0有效"), Browsable(true)]
        public int GroupNum
        {
            get { return _groupNum; }
            set
            {
                if (_groupNum != value)
                {
                    _groupNum = value;
                    base.Invalidate();
                }
            }
        }
        [Category("自定义"), Description("获取或者设置按钮左竖线宽度，大于0有效"), Browsable(true)]
        public int ActiveLeftLineSize
        {
            get { return _activeleftLineSize; }
            set
            {
                if (_activeleftLineSize != value)
                {
                    _activeleftLineSize = value;
                    base.Invalidate();
                }
            }
        }
        [Category("自定义"), Description("获取或者设置是否按钮按下后颜色是否保持"), Browsable(true)]
        public bool KeepPressColor
        {
            get { return _keepPressColor; }
            set
            {
                if (_keepPressColor != value)
                {
                    _keepPressColor = value;
                }
            }
        }
        [Category("自定义"), Description("获取或者设置显示ToolTip"), Browsable(true)]
        public string ToolTipText
        {
            get { return _toolTipText; }
            set
            {
                if (_toolTipText != value)
                {
                    _toolTipText = value;
                    this.Invalidate();
                }
            }
        }

        [Browsable(false)]
        public bool BtnPressState
        {
            get { return _btnPressState; }
            set
            {
                if (_btnPressState != value)
                {
                    _btnPressState = value;
                    this.Invalidate();
                }
            }
        }
        [Category("自定义"), Description("获取或者设置获取焦点时的背景色"), Browsable(true)]
        public Color ActiveBackColor
        {
            get { return _activeBackColor; }
            set
            {
                if (_activeBackColor != value)
                {
                    _activeBackColor = value;
                }
            }
        }
    }
}
