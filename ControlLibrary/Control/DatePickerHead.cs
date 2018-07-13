using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace ControlLibrary
{
    internal class DatePickerHead : DateTimePicker
    {
        //Methods
        [DllImport("user32")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("user32")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == (int)WinMsgEnum.WM_PAINT || m.Msg == (int)WinMsgEnum.WM_ERASEBKGND)
            {
                IntPtr hDC = GetWindowDC(m.HWnd);
                if (hDC.ToInt32() == 0)
                {
                    return;
                }
                Graphics g = Graphics.FromHdc(hDC);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(this.BackColor, 1))
                {
                    g.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
                }
                m.Result = IntPtr.Zero;
                ReleaseDC(m.HWnd, hDC);
            }
        }


    }
}
