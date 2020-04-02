using System.Drawing;
using System.Windows.Forms;

namespace Oscilloscope
{
    class Strokes //Класс штрихов на осях
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
        int thckns
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
        }
    }
}
