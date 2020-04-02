using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Oscilloscope
{
    class Signal : Methods
    {        
        public Func<double, double> Func;// Отображаемая функция
        
        public Signal()
        {
            Func = (x) => 4*Math.Sin(x);
        }
        public void Borders(float miX, float maX, float miY, float maY)
        {
            MinX = miX;
            MaxX = maX;
            MinY = miY;
            MaxY = maY;
        }

        public void DrawSignals(Graphics g, Rectangle area)
        {
            Rect = Area(area);           

            //Рисуем функцию
            if (Func != null)
            {
                Pen penFun1 = new Pen(Color.FromArgb(70, Color.Green), 8);
                Pen penFun2 = new Pen(Color.FromArgb(190, Color.Green), 4);
                Pen penFun3 = new Pen(Color.FromArgb(210, Color.White), 2);
                //penFun1.PenType = System.Drawing.Drawing2D.PenType.PathGradient;
                float step = 0.01F; //шаг значений функции, точность построения
                for (var x = MinX; x < MaxX; x += step)
                {
                    float y1 = (float)Func(x);
                    float y2 = (float)Func(x + step);
                    g.DrawLine(penFun2, Rect.Left + XToPixels(x), Rect.Bottom - YToPixels(y1), Rect.Left + XToPixels(x + step), Rect.Bottom - YToPixels(y2));
                    g.DrawLine(penFun1, Rect.Left + XToPixels(x), Rect.Bottom - YToPixels(y1), Rect.Left + XToPixels(x + step), Rect.Bottom - YToPixels(y2));
                    g.DrawLine(penFun3, Rect.Left + XToPixels(x), Rect.Bottom - YToPixels(y1), Rect.Left + XToPixels(x + step), Rect.Bottom - YToPixels(y2));

                }
            }
        }
    }
}
