using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace ControlLibrary
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BorderSkin
    {
        // Fields
        private Control _owner;
        private float _lineWidth=1;
        private DashStyle _lineStyle = DashStyle.Solid;
        private bool _showLeftLine = true;
        private bool _showRightLine=true;
        private bool _showTopLine=true;
        private bool _showBottomLine=true;
        private ColorSkin _colorSkin;

        // Methods
        public BorderSkin(Control owner)
        {
            this._owner = owner;
            this._colorSkin = new ColorSkin(owner);
        }

        // Properties
        [Category("自定义"), Description("线宽度"), Browsable(true)]
        public float LineWidth
        {
            get { return _lineWidth; }
            set
            {
                if (_owner is TextBox)
                {
                    return;
                }
                else
                {
                    _lineWidth = value;
                    this._owner.Invalidate();
                }
            }
        }
        [Category("自定义"), Description("线样式"), Browsable(true)]
        public DashStyle LineStyle
        {
            get { return _lineStyle; }
            set
            {
                _lineStyle = value;
                this._owner.Invalidate();
            }
        }
        [Category("自定义"), Description("左边线是否显示"), Browsable(true)]
        public bool ShowLeftLine
        {
            get { return _showLeftLine; }
            set
            {
                _showLeftLine = value;
                this._owner.Invalidate();
            }
        }
        [Category("自定义"), Description("右边线是否显示"), Browsable(true)]
        public bool ShowRightLine
        {
            get { return _showRightLine; }
            set
            {
                _showRightLine = value;
                this._owner.Invalidate();
            }
        }
        [Category("自定义"), Description("上边线是否显示"), Browsable(true)]
        public bool ShowTopLine
        {
            get { return _showTopLine; }
            set
            {
                _showTopLine = value;
                this._owner.Invalidate();
            }
        }
        [Category("自定义"), Description("下边线是否显示"), Browsable(true)]
        public bool ShowBottomLine
        {
            get { return _showBottomLine; }
            set
            {
                _showBottomLine = value;
                this._owner.Invalidate();
            }
        }
        [Category("自定义"), Description("边线颜色样式"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ColorSkin ColorSkin { get { return _colorSkin; } }
    }
}
