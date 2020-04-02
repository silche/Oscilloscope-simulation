using System.Drawing;
using System.Windows.Forms;

namespace Oscilloscope
{
    class Axes : DisplayMethods //Класс осей
    {
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
            pen.Dispose();
        }
    }
}
