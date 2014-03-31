/*=============================================================================================
            DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE
                    Version 2, December 2004

 Everyone is permitted to copy and distribute verbatim or modified
 copies of this license document, and changing it is allowed as long
 as the name is changed.

            DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE
   TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION

  0. You just DO WHAT THE FUCK YOU WANT TO.

	NON-WARRANTY CLAUSE:
	This program is free software. It comes without any warranty, to
	the extent permitted by applicable law. You can redistribute it
	and/or modify it under the terms of the Do What The Fuck You Want
	To Public License, Version 2, as published by Sam Hocevar. See
	http://www.wtfpl.net/ for more details. 
 * =============================================================================================
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UDKSnip
{
    public partial class PreviewPanel : UserControl
    {
        public Image m_DisplayImage;
        public string m_PreviewText;
        public string m_Title;

        private Font m_TitleFont;
        private Font m_PreviewFont;
        private SolidBrush m_FrontText;
        private SolidBrush m_ShadowText;
        private SolidBrush m_DarkenZoneBrush;

        public PreviewPanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            this.m_PreviewText = "";
            this.m_Title = "";

            this.m_TitleFont = new Font("Tahoma", 16.0f);
            this.m_PreviewFont = new Font("Tahoma", 8.0f);

            this.m_FrontText = new SolidBrush(Color.White);
            this.m_ShadowText = new SolidBrush(Color.Black);
            this.m_DarkenZoneBrush = new SolidBrush(Color.FromArgb(128, 0, 0, 0));

        }

        private void PreviewPanel_Paint(object sender, PaintEventArgs e)
        {
            if (m_DisplayImage != null)
            {
                // CHECK RATIOS
                float v_ImageRatio = (float)m_DisplayImage.Width / (float)m_DisplayImage.Height;
                float v_PanelRatio = (float)this.Width / (float)this.Height;
                Rectangle v_Bounds;
                Size v_NewSize;

                if (v_ImageRatio > v_PanelRatio) // CROP LATERAL
                {
                    v_NewSize = new Size((int)(this.Height * v_ImageRatio), (int)this.Height);
                    v_Bounds = new Rectangle(new Point((int)(-(v_NewSize.Width - this.Width) / 2), 0), v_NewSize);
                }
                else // CROP TOP DOWN
                {
                    v_NewSize = new Size((int)this.Width, (int)(int)(this.Width / v_ImageRatio));
                    v_Bounds = new Rectangle(new Point(0,(int)(-(v_NewSize.Height - this.Height) / 2)), v_NewSize);
                }
                

                e.Graphics.DrawImage(m_DisplayImage, v_Bounds);
            }

            // Measure
            SizeF v_PreviewSize = e.Graphics.MeasureString(m_PreviewText, m_PreviewFont, this.Width - 32);

            // Draw BG
            e.Graphics.FillRectangle(this.m_DarkenZoneBrush, new Rectangle(0, 0, this.Width, (int)v_PreviewSize.Height +48+16));

            // Shadows
            e.Graphics.DrawString(m_Title, m_TitleFont, m_ShadowText, new PointF(18.0f, 18.0f));
            e.Graphics.DrawString(m_PreviewText, m_PreviewFont, m_ShadowText, new RectangleF(17.0f, 49.0f, this.Width - 32.0f, this.Height - 48.0f));
            // Text
            e.Graphics.DrawString(m_Title, m_TitleFont, m_FrontText, new PointF(16.0f, 16.0f));
            e.Graphics.DrawString(m_PreviewText, m_PreviewFont, m_FrontText, new RectangleF(16.0f, 48.0f, this.Width - 32.0f, this.Height - 48.0f));
        }
    }
}
