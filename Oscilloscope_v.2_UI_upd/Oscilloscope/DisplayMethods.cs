using System.Drawing;
using System.Windows.Forms;

namespace Oscilloscope
{
    class DisplayMethods
    {
        public Rectangle area
        {
            get;
            set;
        }

        public int X; public int Y;
        //максимальные и минимальные значения осей
        public float MinX { get { return -X / 2; } }
        public float MaxX { get { return X / 2; } }
        public float MinY { get { return -Y / 2; } }
        public float MaxY { get { return Y / 2; } }

        // Преобразование виртуальных координат в пикселы
        public float XToPixels(float x)
        {
            return area.Width * (x - MinX) / (MaxX - MinX);
        }

        public float YToPixels(float y)
        {
            return area.Height * (y - MinY) / (MaxY - MinY);
        }

        public PointF center
        {
            get
            {
                return center = new PointF(area.Left + XToPixels(0), area.Bottom - YToPixels(0));
            } // PointF для float   
            set { }
        }

        #region Параметры пера
        public Color col
        {
            get;
            set;
        }
        public int thckns
        {
            get;
            set;
        }
        #endregion
    }
}
