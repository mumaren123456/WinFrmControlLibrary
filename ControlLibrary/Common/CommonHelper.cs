using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Reflection;

namespace ControlLibrary
{
    public static class CommonHelper
    {
        #region 在工作区域绘制文字
        /// <summary>
        /// 在工作区域绘制文字
        /// </summary>
        /// <param name="g"></param>
        /// <param name="objectSize"></param>
        /// <param name="clientRectangle"></param>
        /// <param name="alignment"></param>
        /// <returns></returns>
        public static Point AlignDrawingPoint(Size objectSize, Rectangle clientRectangle, ContentAlignment alignment)
        {
            //int margin = 4;
            int margin = 4;
            int verticalmargin = Convert.ToInt32(clientRectangle.Height * 0.01);
            int horizontalmargin = Convert.ToInt32(clientRectangle.Height * 0.01);
            Point center = new Point((clientRectangle.Width >> 1) - (objectSize.Width >> 1), (clientRectangle.Height >> 1) - (objectSize.Height >> 1));
            int rightMargin = clientRectangle.Width - (objectSize.Width + margin);
            int bottomMargin = clientRectangle.Height - (objectSize.Height + margin);
            Point p = Point.Empty;
            switch (alignment)
            {
                case ContentAlignment.TopLeft:
                    p = new Point(margin, margin);
                    break;
                case ContentAlignment.TopCenter:
                    p = new Point(center.X, margin);
                    break;
                case ContentAlignment.TopRight:
                    p = new Point(rightMargin, margin);
                    break;
                case ContentAlignment.MiddleLeft:
                    p = new Point(margin, center.Y);
                    break;
                case ContentAlignment.MiddleCenter:
                    p = new Point(center.X, center.Y);
                    break;
                case ContentAlignment.MiddleRight:
                    p = new Point(rightMargin, center.Y);
                    break;
                case ContentAlignment.BottomLeft:
                    p = new Point(margin, bottomMargin);
                    break;
                case ContentAlignment.BottomCenter:
                    p = new Point(center.X, bottomMargin);
                    break;
                case ContentAlignment.BottomRight:
                    p = new Point(rightMargin, bottomMargin);
                    break;
            }
            p.Offset(clientRectangle.X, clientRectangle.Y);
            return p;
        }
        #endregion

        public static StringFormat AlignDrawingPoint(ContentAlignment alignment)
        {
            StringFormat sf=new StringFormat();
            switch (alignment)
            {
                case ContentAlignment.BottomCenter:
                    {
                        sf.LineAlignment = StringAlignment.Far;
                        sf.Alignment = StringAlignment.Center;
                        break;
                    }
                case ContentAlignment.BottomLeft:
                    {
                        sf.LineAlignment = StringAlignment.Far;
                        sf.Alignment = StringAlignment.Near;
                        break;
                    }
                case ContentAlignment.BottomRight:
                    {
                        sf.LineAlignment = StringAlignment.Far;
                        sf.Alignment = StringAlignment.Far;
                        break;
                    }
                case ContentAlignment.MiddleCenter:
                    {
                        sf.LineAlignment = StringAlignment.Center;
                        sf.Alignment = StringAlignment.Center;
                        break;
                    }
                case ContentAlignment.MiddleLeft:
                    {
                        sf.LineAlignment = StringAlignment.Center;
                        sf.Alignment = StringAlignment.Near;
                        break;
                    }
                case ContentAlignment.MiddleRight:
                    {
                        sf.LineAlignment = StringAlignment.Center;
                        sf.Alignment = StringAlignment.Far;
                        break;
                    }
                case ContentAlignment.TopCenter:
                    {
                        sf.LineAlignment = StringAlignment.Near;
                        sf.Alignment = StringAlignment.Center;
                        break;
                    }
                case ContentAlignment.TopLeft:
                    {
                        sf.LineAlignment = StringAlignment.Near;
                        sf.Alignment = StringAlignment.Near;
                        break;
                    }
                case ContentAlignment.TopRight:
                    {
                        sf.LineAlignment = StringAlignment.Near;
                        sf.Alignment = StringAlignment.Far;
                        break;
                    }
            }
            return sf;
        }

        /// <summary>
        /// 判断是否十六进制格式字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsHexadecimal(string str)
        {
            string PATTERN = @"([^A-Fa-f0-9]|\s+?)+";
            return System.Text.RegularExpressions.Regex.IsMatch(str, PATTERN);
        }
    }
}
