using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Oscilloscope
{
    public partial class Oscilloscope : Form
    {
        Axes ax; Chart chr; Signal sg;
        public Oscilloscope()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);

            //Indent = 10;
            /*MinX = -7;
            MaxX = MaxX;
            MinY = -5;
            MaxY = 5;*/
            //GridStep = 1;
        }

        private void Oscilloscope_Load(object sender, EventArgs e)
        {
            ax = new Axes();
            chr = new Chart();
            chr.Visible = false;
            sg = new Signal();
            sg.Visible = false;
        }

        private void picbox_Paint(object sender, PaintEventArgs e)
        {/*
            Graphics G = e.Graphics;
            Rectangle picbrect = picbox.ClientRectangle;

            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            ax.Borders(MinX, MaxX, MinY, MaxY);
            ax.DrawAxes(G, picbrect);

            chr.Borders(MinX, MaxX, MinY, MaxY);
            chr.DrawChart(G, picbrect);
            sg.Borders(MinX, MaxX, MinY, MaxY);

            if (RadButton) sg.DrawSignals(G, picbrect);
            //Methods mds = new Methods(); mds.Visible = false;*/
        }

        //максимальные и минимальные значения осей
        public float MinX { get { return -trackBar1.Value; } }
        public float MaxX { get { return trackBar1.Value; } }
        public float MinY { get { return -trackBar2.Value; } }
        public float MaxY { get { return trackBar2.Value; } }

        // Шаг сетки
        //public float GridStep { get; set; }

        bool RadButton
        { get; set; }
        private void onoff_Click(object sender, EventArgs e)
        {
            if (radioBut.Checked)
            {
                RadButton = false;
                radioBut.Checked = false;
                onoff.Text = "OFF";
            }
            else
            {
                RadButton = true;
                radioBut.Checked = true;
                onoff.Text = "ON";
            }
            picbox.Invalidate();
        }

        private void Oscilloscope_ClientSizeChanged(object sender, EventArgs e)
        {
            picbox.Size = new Size(ClientSize.Width - 280, (ClientSize.Height - 24));
            picbox.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            picbox.Invalidate();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            picbox.Invalidate();
        }

        private void exit_Click(object sender, EventArgs e) { Close(); }
    }
}