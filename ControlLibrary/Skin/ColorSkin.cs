using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace ControlLibrary
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ColorSkin
    {
        // Fields
        private Control _owner;
        private Color _nomalColor;
        private Color _activeColor;

        // Methods
        public ColorSkin(Control owner)
        {
            this._owner = owner;
            this._nomalColor = Color.Black;
            this._activeColor = Color.Red;
        }

        // Properties
        [Category("自定义"), Description("正常状态时的颜色"), Browsable(true)]
        public Color NomalColor
        {
            get { return _nomalColor; }
            set
            {
                _nomalColor = value;
                this._owner.Invalidate();
            }
        }
        [Category("自定义"), Description("激活状态时的颜色"), Browsable(true)]
        public Color ActiveColor
        {
            get { return _activeColor; }
            set
            {
                _activeColor = value;
                this._owner.Invalidate();
            }
        }
    }
}
