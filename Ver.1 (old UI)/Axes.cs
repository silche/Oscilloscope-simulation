using System.Drawing;
using System.Windows.Forms;

namespace Oscilloscope
{
    class Axes //Класс осей
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
        float XToPixels(float x)
        {
            return area.Width * (x - MinX) / (MaxX - MinX);
        }

        float YToPixels(float y)
        {
            return area.Height * (y - MinY) / (MaxY - MinY);
        }

        PointF center//Нахождение центра
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
        public void GetParameters(Rectangle r, int x, int y, Color c)
        {
            area = r;//прямоугольная область
            X = x;
            Y = y;
            col = c;
            thckns = 2;
        }

        //Рисуем оси     
        public void DrawAxes(Graphics g)
        {
            Pen pen = new Pen(Color.FromArgb(150, col), thckns);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;//форма линий в виде стрелки
            g.DrawLine(pen, center.X, area.Bottom, center.X, area.Top - 7);
            g.DrawLine(pen, area.Left, center.Y, area.Right + 7, center.Y);
        }
    }
}
