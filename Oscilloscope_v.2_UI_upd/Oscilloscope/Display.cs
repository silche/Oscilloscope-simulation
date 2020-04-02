using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Oscilloscope
{
    public partial class Display : UserControl
    {
        Axes ax; Grid gd; Strokes st; SignalMethods cv;

        int X;//число значений по горизонтали
        int Y;//число значений по вертикали
        int Thickness;//толщина линий
        Color ColAx;//цвет осей
        Color ColGr;//цвет сетки
        Color ColStr;//цвет штрихов
        Color backCol;

        public Display()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
  
            ax = new Axes();
            gd = new Grid();
            st = new Strokes();
            cv = new SignalMethods();

            Indent = 10;
            X = 10;
            Y = 10;
            Thickness = 1;
            ColAx = Color.Black;
            backCol = ColorTranslator.FromHtml("#F4F7FC");
            BackColorGrid = backCol;
            InitializeComponent();
        }

        [Category("Сетка"), DefaultValue(10)]
        public int XSize
        {
            get { return X; }
            set { X = value; ChangeProperties(); }
        }
        [Category("Сетка"), DefaultValue(10)]
        public int YSize
        {
            get { return Y; }
            set { Y = value; ChangeProperties(); }
        }
        [Category("Сетка"), DefaultValue(1)]
        public int ThicknessLine
        {
            get { return Thickness; }
            set { Thickness = value; ChangeProperties(); }
        }
        [Category("Сетка")]
        public Color ColorAxes
        {
            get { return ColAx; }
            set { ColAx = value; ChangeProperties(); }
        }
        [Category("Сетка")]
        public Color ColorStrokes
        {
            get { return ColStr; }
            set { ColStr = value; ChangeProperties(); }
        }
        [Category("Сетка")]
        public Color ColorGrid
        {
            get { return ColGr; }
            set { ColGr = value; ChangeProperties(); }
        }
        [Category("Дисплей")]
        public Color BackColorGrid
        {
            get { return BackColor; }
            set { BackColor = value; ChangeProperties(); }
        }        

        [DefaultValue(10)]
        public int Indent { get; set; }

        //Уменьшение прямоугольной области
        private Rectangle InflateRect
        {
            get
            {
                var rect = ClientRectangle;
                rect.Inflate(-Indent, -Indent);
                return rect;
            }
        }

        Rectangle Area
        {
            get;
            set;
        }              

        protected override void OnPaint(PaintEventArgs e)// этот метод скрывает наследуемый системный член OnPaint
        //чтобы переопределять эту реализацию, используется слово override
        {
            Area = InflateRect;
            Graphics G = e.Graphics;
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            //Рисуем оси  
            ax.GetParameters(Area, X, Y, ColorAxes);
            ax.DrawAxes(G);
            
            //Рисуем штрихи на осях   
            st.GetParameters(Area, X, Y, ColorStrokes, Thickness);
            st.DrawStrokes(G);
            
            //Рисуем сетку  
            gd.GetParameters(Area, X, Y, ColorGrid, Thickness);
            gd.DrawGrid(G);  
  
	    //Рисуем кривую сигнала
            base.OnPaint(e);        
        }

        private void ChangeProperties()
        {
            Invalidate();
        }
    }
}
