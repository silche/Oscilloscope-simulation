using System.Drawing;
using System.Windows.Forms;

namespace Oscilloscope
{
    class Strokes : DisplayMethods //Класс штрихов на осях
    {      
        //Получение значений переменных
        public void GetParameters(Rectangle r, int x, int y, Color c, int t)
        {
            area = r;
            X = x;
            Y = y;
            col = c;
            thckns = t;
        }

        //Рисуем штрихи на осях     
        public void DrawStrokes(Graphics g)
        {
            Pen pen = new Pen(Color.FromArgb(200, col), thckns);
            for (float x = MinX; x <= MaxX; x += 0.1F)
            {
                float absX = area.Left + XToPixels(x);//задаётся положение по Х координате
                g.DrawLine(pen, absX, center.Y + 3, absX, center.Y - 3);
            }
            for (float y = MinY; y <= MaxY; y += 0.1F)
            {
                float absY = area.Bottom - YToPixels(y);
                g.DrawLine(pen, center.X + 3, absY, center.X - 3, absY);
            }//штрихи по-длиннее
            for (float x = MinX; x <= MaxX; x += 0.5F)
            {
                float absX = area.Left + XToPixels(x);
                g.DrawLine(pen, absX, center.Y + 5, absX, center.Y - 5);
            }
            for (float y = MinY; y <= MaxY; y += 0.5F)
            {
                float absY = area.Bottom - YToPixels(y);
                g.DrawLine(pen, center.X + 5, absY, center.X - 5, absY);
            }
            pen.Dispose();
        }
    }
}
