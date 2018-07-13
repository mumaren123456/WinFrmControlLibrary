using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Text;

namespace ControlLibrary
{

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class IconSkin
    {
        // Fields
        private static readonly PrivateFontCollection _pfc;
        private Control _owner;
        private int _iconSize;
        private string _iconString;
        private string _iconCode;
        private Font _iconFont;
        private Point _iconPoint;
        static IconSkin()
        {
            _pfc = new PrivateFontCollection();
        }
        public IconSkin(Control owner)
        {
            this._iconSize = 18;
            this._iconString = _iconCode = String.Empty;
            _iconPoint = new Point(4,4);
            this._owner = owner;
            byte[] fontbts = Properties.Resources.fontawesome_webfont;
            var fontData = Marshal.AllocCoTaskMem(fontbts.Length);
            Marshal.Copy(fontbts, 0, fontData, fontbts.Length);
            _pfc.AddMemoryFont(fontData, fontbts.Length);
            Marshal.FreeCoTaskMem(fontData);
            _iconFont = new Font(_pfc.Families[0], this._iconSize);
        }

        // Properties
        [Category("自定义"), Description("ICON字体"), Browsable(false)]
        public Font IconFont{get{return _iconFont;}}
        [Category("自定义"), Description("ICON大小"), Browsable(true)]
        public int IconSize
        {
            get { return _iconSize; }
            set
            {
                if (_iconSize != value)
                {
                    _iconSize = value;
                    _iconFont = new Font(_pfc.Families[0], this._iconSize);
                    this._owner.Invalidate();
                }
            }
        }
        [Category("自定义"), Description("获取或者设置ICON图标(16进制代码)"), Browsable(true)]
        public string IconString
        {
            get { return _iconString; }
            set
            {
                if (value != _iconString)
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        this._iconCode =_iconString= value;
                    }
                    else if(CommonHelper.IsHexadecimal(value))
                    {
                        _iconString = value;
                        this._iconCode =char.ConvertFromUtf32(Convert.ToInt32(_iconString, 16));
                    }
                    this._owner.Invalidate();
                }
            }
        }
        [Browsable(false), Description("ICON代码")]
        public string IconCode { get { return _iconCode; } }
        [Category("自定义"), Description("获取或者设置ICON Point"), Browsable(true)]
        public Point IconPoint
        {
            get { return _iconPoint; }
            set
            {
                if (_iconPoint != value)
                {
                    _iconPoint = value;
                    this._owner.Invalidate();
                }
            }
        }
    }
}
