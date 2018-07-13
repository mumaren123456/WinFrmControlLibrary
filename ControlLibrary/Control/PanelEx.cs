using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace ControlLibrary
{
    public class PanelEx:Panel
    {
        // Fields
        private BorderSkin _borderSkin;

        // Methods
        public PanelEx()
        {
            this._borderSkin = new BorderSkin(this);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            if (this.BorderStyle == BorderStyle.None)
            {
                using (var pen = new Pen(this._borderSkin.ColorSkin.NomalColor, this._borderSkin.LineWidth))
                {
                    g.DrawRectangle(pen, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
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
    }
}
