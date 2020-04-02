using System.Drawing;
using System.Windows.Forms;


namespace Oscilloscope
{
    class Grid //Класс сетки
    {
        Rectangle area
        {
            get;
            set;
        }

        int X; int Y;
        //максимальные и минимальные значения осей
        float MinX { get { return -X / 2; } }
        float MaxX { get { return X / 2; } }
        float MinY { get { return -Y / 2; } }
        float MaxY { get { return Y / 2; } }

        // Преобразование виртуальных координат в пикселы
        public float XToPixels(float x)
        {
            return area.Width * (x - MinX) / (MaxX - MinX);
        }

        public float YToPixels(float y)
        {
            return area.Height * (y - MinY) / (MaxY - MinY);
        }

        PointF center
        {
            get
            {
                return center = new PointF(area.Left + XToPixels(0), area.Bottom - YToPixels(0));
            } // PointF для float   
            set { }
        }

        #region Параметры пера
        Color col
        {
            get;
            set;
        }
        int thckns//толщина пера
        {
            get;
            set;
        }
        #endregion


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
        }
    }
}
