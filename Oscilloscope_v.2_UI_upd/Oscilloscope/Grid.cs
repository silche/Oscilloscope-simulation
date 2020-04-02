using System.Drawing;
using System.Windows.Forms;

namespace Oscilloscope
{
    class Grid : DisplayMethods //Класс сетки
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

        //Рисуем сетку     
        public void DrawGrid(Graphics g)
        {
            Pen pen = new Pen(Color.FromArgb(135, col), thckns);
            Font font = new Font("Arial", 7.5f);
            for (float x = MinX; x <= MaxX; x++)
            {
                float absX = area.Left + XToPixels(x);
                g.DrawLine(pen, absX, area.Bottom, absX, area.Top);
                g.DrawString(x.ToString("0"), font, Brushes.Black, absX - 9, center.Y + 5);//подпись оси цифрами
            }

            for (float y = MinY; y <= MaxY; y += 1)
            {
                float absY = area.Bottom - YToPixels(y);
                g.DrawLine(pen, area.Left, absY, area.Right, absY);
                if (y != 0) g.DrawString(y.ToString("0"), font, Brushes.Black, center.X - 17, absY - 5);
            }
            pen.Dispose();
            font.Dispose();
        }
    }
}
