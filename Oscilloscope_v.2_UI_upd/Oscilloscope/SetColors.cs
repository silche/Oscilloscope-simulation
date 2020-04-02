using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Oscilloscope
{
    public partial class SetColors : UserControl
    {
        public SetColors()
        {
            InitializeComponent();
        }

        /*
        Color col;
        #region Настройка визульного отображения

        //Ползунок для красного цвета
        private void redtrack_Scroll(object sender, EventArgs e)
        {
            col = Color.FromArgb(redtrack.Value, greentrack.Value, bluetrack.Value);
            SetColor(col);//вывоз метода изменения цвета
        }
        //Для зеленого
        private void greentrack_Scroll(object sender, EventArgs e)
        {
            col = Color.FromArgb(redtrack.Value, greentrack.Value, bluetrack.Value);
            SetColor(col);
        }
        //Для синего
        private void bluetrack_Scroll(object sender, EventArgs e)
        {
            col = Color.FromArgb(redtrack.Value, greentrack.Value, bluetrack.Value);
            SetColor(col);
        }
        //Изменение цвета
        void SetColor(Color c)
        {//проверяются какой выбран элемент
            if (axradioBut.Checked)
                display.ColorAxes = c;
            else if (risradioBut.Checked)
                display.ColorStrokes = c;
            else if (gridradioBut.Checked)
                display.ColorGrid = c;
            else if (dispradioBut.Checked)
                display.BackColor = c;
            else if (signradioBut.Checked)
            {
                Sm.col = c;
                display.Invalidate();
            }
            else if (formradioBut.Checked)
                this.BackColor = c;
        }
        //Включение (разморозка) трэкбаров (ползунков)
        private void setColorcheckB_CheckedChanged(object sender, EventArgs e)
        {
            EnableSetColor(setColorcheckB.Checked);
        }
        //Метод активации
        void EnableSetColor(bool trfl)
        {
            redtrack.Enabled = trfl;
            greentrack.Enabled = trfl;
            bluetrack.Enabled = trfl;
        }

        #endregion
        */
    }
}
