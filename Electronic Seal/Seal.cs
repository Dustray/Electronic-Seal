using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_Seal
{
    class Seal
    {
        private Bitmap bitmap;
        private int bitmapWidth, bitmapHeight;
        private int frameWidth, frameHeight;
        public Seal(Bitmap bitmap)
        {
            this.bitmap = bitmap;
            
            bitmapWidth = bitmap.Width;
            bitmapHeight = bitmap.Height;

        }
        public void CreateFrame(int width, int height,int frameSize)
        {
            frameWidth = width;
            frameHeight = height;

            Pen pen = new Pen(Color.Red, frameSize);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            GraphicsPath gp = new GraphicsPath();
            Rectangle r = new Rectangle();
            r.Width = width;
            r.Height = height;
            r.X = bitmapWidth / 2 - width / 2;
            r.Y = bitmapHeight / 2 - height / 2;

            gp.AddRectangle(r);
            g.DrawPath(pen, gp);
        }

        public void CreateText(string text,int fontSize)
        {
            Graphics g = Graphics.FromImage(bitmap);

            Font font = new Font("黑体", fontSize);
            
            SizeF sif = TextRenderer.MeasureText( text, font);
            float textWidth = sif.Width;
            float textHeight = sif.Height;
            Brush brush = new SolidBrush(Color.Red);
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            int actualPositionY = (bitmapHeight  - Convert.ToInt32(textHeight )) / 2;
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center; //居中
            g.DrawString(text, font, brush, bitmapWidth/2, actualPositionY,format);

        }
        public void DrawImpurity()
        {
            someDot(bitmap, 2000, 2,Color.White);
            someDot(bitmap, 700, 3, Color.White);
        }
        private void someDot(Bitmap bit ,int count,int size,Color color)
        {
            Graphics g = Graphics.FromImage(bitmap);

            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                RectangleF r = new RectangleF();

                int ranPositionX = random.Next(bitmap.Width);
                int ranPositionY = random.Next(bitmap.Height);

                r.Width = random.Next(size) + 2;
                r.Height = random.Next(size) + 2;
                r.X = ranPositionX;
                r.Y = ranPositionY;
                Brush brush = new SolidBrush(color);
                g.FillEllipse(brush, r);
            }
        }

    }
}
