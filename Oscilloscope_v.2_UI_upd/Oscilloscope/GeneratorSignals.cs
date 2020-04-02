using System;
using System.Windows.Forms;

namespace Oscilloscope
{
    public partial class GeneratorSignals : UserControl
    {
        int voltage;//напряжение
        float frequency;//частота
        float duratpulse;//длительность импульса
        public GeneratorSignals()
        {
            voltage = 1;
            frequency = 1;
            InitializeComponent();
        }
        public int U
        {
            get { return voltage; }
        }
        public float F
        {
            get { return frequency; }
        }
        public float Dp
        {
            get { return duratpulse; }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (garmon.Checked == true)
            {
                try
                {
                    voltage = Convert.ToInt32(voltagegarm.Text);
                }
                catch
                {
                    MessageBox.Show("Введенное значение не является числом!");
                    return;
                }
                try
                {
                    frequency = Convert.ToInt32(freqgarm.Text);
                }
                catch
                {
                    MessageBox.Show("Введенное значение не является числом!");
                    return;
                }
                this.Visible = false;
            }
            else if (impul.Checked == true)
            {
                try
                {
                    voltage = Convert.ToInt32(voltageimp.Text);
                }
                catch
                {
                    MessageBox.Show("Введенное значение не является числом!");
                    return;
                }
                try
                {
                    frequency = (float)Convert.ToDouble(freqimp.Text);
                }
                catch
                {
                    MessageBox.Show("Введенное значение не является числом!");
                    return;
                }
                try
                {
                    duratpulse = (float)Convert.ToDouble(duratimp.Text);
                    double x = Math.Pow(F, -1);
                    if (x < Dp)
                    {
                        MessageBox.Show("Время импульса не может быть больше периода");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Введенное значение не является числом!");
                    return;
                }
                this.Visible = false;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
