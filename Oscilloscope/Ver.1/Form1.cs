using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Oscilloscope
{
    public partial class Oscilloscope : Form
    {
        Function fn; GridChart gch;
        public Oscilloscope()
        {
            InitializeComponent();
            gch = new GridChart { Parent = this.picbox, Dock = DockStyle.Fill };
            gch.Visible = false;
            fn = new Function();
        }
        
        private void exit_Click(object sender, EventArgs e) { Close(); }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            fn.MaxY = trackBar.Value;
            picbox.Invalidate();
            picbox.Refresh();
        }

        private void picbox_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            fn.Draw(g);
            //picbox.Invalidate();
            //picbox.Refresh();
        }

        private void onoff_Click(object sender, EventArgs e)
        {
            if (radioBut.Checked == false)
            {
                gch.Visible = true;
                radioBut.Checked = true;
                onoff.Text = "ON";
            }
            else
            {
                gch.Visible = false;
                radioBut.Checked = false;
                onoff.Text = "OFF";
            }
        }
        
        private void Oscilloscope_ClientSizeChanged(object sender, EventArgs e)
        {
            Size s = new Size(this.ClientSize.Width - 410, (this.ClientSize.Height - 20));
            picbox.Size = s;
        }
    }
}