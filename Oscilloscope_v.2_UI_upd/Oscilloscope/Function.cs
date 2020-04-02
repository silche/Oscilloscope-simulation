using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Oscilloscope
{
    class Function
    {
        GridChart gch = new GridChart();
        // Отображаемая функция
        public Func<double, double> Func;

        //максимальные и минимальные значения осей
        public float MaxX { get; set; }

        public float MinX { get; set; }

        public float MaxY { get; set; }

        public float MinY { get; set; }

        public Function()
        {
            //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            Func = (x) => 4 * Math.Sin(x);
            MinX = -5;
            MaxX = 5;
            MinY = -5;
            MaxY = 5;
        }

        
            //var g = e.Graphics; // == Graphics g


        public Rectangle rect
        {
              get; set; 
        }
        
        float XToPixels(float x)
        {
            return rect.Width * (x - MinX) / (MaxX - MinX);
        }

        float YToPixels(float y)
        {
            return rect.Height * (y - MinY) / (MaxY - MinY);
        }

        public void Draw(Graphics g)// этот метод скрывает наследуемый системный член OnPaint
        //чтобы переопределять эту реализацию, используется слово override
        {
            
           
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //Рисуем функцию
            if (Func != null)
            {
                var penFun1 = new Pen(Color.FromArgb(50, Color.Green), 9);
                var penFun2 = new Pen(Color.FromArgb(170, Color.Green), 5);
                var penFun3 = new Pen(Color.FromArgb(190, Color.White), 3);
                //penFun1.PenType = System.Drawing.Drawing2D.PenType.PathGradient;
                float step = 0.01F; //шаг значений функции, точность построения
                for (var x = MinX; x < MaxX; x += step)
                {
                    var y1 = (float)Func(x);
                    var y2 = (float)Func(x + step);
                    g.DrawLine(penFun2, rect.Left + XToPixels(x), rect.Bottom - YToPixels(y1), rect.Left + XToPixels(x + step), rect.Bottom - YToPixels(y2));
                    g.DrawLine(penFun1, rect.Left + XToPixels(x), rect.Bottom - YToPixels(y1), rect.Left + XToPixels(x + step), rect.Bottom - YToPixels(y2));
                    g.DrawLine(penFun3, rect.Left + XToPixels(x), rect.Bottom - YToPixels(y1), rect.Left + XToPixels(x + step), rect.Bottom - YToPixels(y2));

                }
            }
        }
    }
}
