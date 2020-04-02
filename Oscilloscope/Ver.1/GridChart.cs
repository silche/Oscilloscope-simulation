using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Oscilloscope
{
    public class GridChart : Control
    {
        // Отступы
        [DefaultValue(10)]
        public int Indent { get; set; }

        //максимальные и минимальные значения осей
        public float MaxX { get; set; }

        public float MinX { get; set; }

        public float MaxY { get; set; }

        public float MinY { get; set; }

        // Шаг сетки
        //public float GridStep { get; set; }


        public GridChart()
        {
            //подавление мерцаний,включение плавности
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            Indent = 10;
            MinX = -5;
            MaxX = 5;
            MinY = -5;
            MaxY = 5;
            //GridStep = 1;
        }

        //private PictureBox
        public Rectangle Area
        {
            get
            {
                var rect = ClientRectangle; // == Rectangle rect (объявление)
                rect.Inflate(-Indent, -Indent);
                return rect;
            }
        }

        // Преобразование виртуальных координат в пикселы
        public float XToPixels(float x)
        {
            return Area.Width * (x - MinX) / (MaxX - MinX);
        }

        public float YToPixels(float y)
        {
            return Area.Height * (y - MinY) / (MaxY - MinY);
        }



        // Отрисовка
        protected override void OnPaint(PaintEventArgs e)// этот метод скрывает наследуемый системный член OnPaint
        //чтобы переопределять эту реализацию, используется слово override
        {
            var rect = Area; // == Rectangle rect
            var g = e.Graphics; // == Graphics g

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            
            //Рисуем оси
            var center = new PointF(rect.Left + XToPixels(0), rect.Bottom - YToPixels(0)); // PointF для float                     
            var penXY = new Pen(Color.FromArgb(123, Color.Navy), 3);
            {
                penXY.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                g.DrawLine(penXY, center.X, rect.Bottom, center.X, rect.Top - 7);
                g.DrawLine(penXY, rect.Left, center.Y, rect.Right + 7, center.Y);
            }

            //Рисуем сетку                
            var pen = new Pen(Color.FromArgb(70, Color.Navy), 1);
            var font = new Font(Font.FontFamily, 8f);
            {
                for (var x = MinX; x <= MaxX; x += 1)
                {
                    var absX = rect.Left + XToPixels(x);
                    g.DrawLine(pen, absX, rect.Bottom, absX, rect.Top);
                    g.DrawString(x.ToString("0.0"), font, Brushes.Navy, absX - 7, center.Y + 5);
                }

                for (var y = MinY; y <= MaxY; y += 1)
                {
                    var absY = rect.Bottom - YToPixels(y);
                    g.DrawLine(pen, rect.Left, absY, rect.Right + 5, absY);
                    g.DrawString(y.ToString("0.0"), font, Brushes.Navy, center.X - 25, absY - 5);
                }
            }

            Function fn = new Function();
            fn.rect = Area;
            fn.Draw(g);
            /*
                        private void picbox_Paint(object sender, PaintEventArgs e)
                        {
                            Graphics g = picbox.CreateGraphics();
                            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                            Pen pen = new Pen(Color.Gray, 3);
                            Pen pen1 = new Pen(Color.Gray, 1);
                            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            int w = picbox.Size.Width;//размеры клиентской области
                            int h = picbox.Size.Height;//размеры клиентской области
                            g.DrawLine(pen, w / 2, h, w / 2, 0);
                            g.DrawLine(pen, 0, h / 2, w, h / 2);

                            int widthLines = w / 15;//Ширина клетки
                            int heightLines = h / 15;//Высота клетки
                            for (int i = 0; i < 5; i++)
                            {
                                w = (w / 2);
                                //Вертикальные линии
                                g.DrawLine(pen1, new Point(2 * w, 0), new Point(2 * w, h));
                                //g.DrawLine(pen1, new Point(3*w, 0), new Point(3*w, h));
                                //g.DrawLine(pen1, new Point(5* w, 0), new Point(5* w, h));
                                //g.DrawLine(pen1, new Point(7 * w, 0), new Point(7 * w, h));
                                g.DrawLine(pen1, new Point(picbox.Size.Width - w * 2, 0), new Point(picbox.Size.Width - w * 2, h));
                                //g.DrawLine(pen1, new Point(picbox.Size.Width - 3*w, 0), new Point(picbox.Size.Width - 3*w, h));
                                //g.DrawLine(pen1, new Point(picbox.Size.Width - w, 0), new Point(picbox.Size.Width - w, h));
                                //Горизонтальные линии
                                //h = h / 2;
                                //g.DrawLine(new Pen(Brushes.BlueViolet), new Point(0, h), new Point(w, h));

                            }/*
                        Point p11 = new Point(picbox.Size.Width / 2, 0);
                        Point p12 = new Point(picbox.Size.Width / 2, picbox.Size.Height);
                        Point p21 = new Point(p11.X/ 2, 0);
                        Point p22 = new Point(p12.X/ 2, picbox.Size.Height);
                        Point[] points = { p11, p12, p21, p22 };
                        g.DrawLines(pen, points);
                            picbox.Refresh();
                        }
                        */
            
        }

    }
}
