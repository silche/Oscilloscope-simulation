using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Oscilloscope
{
    public partial class OscillForm : Form
    {
        SignalObj signal1;//подаваемые сигналы
        SignalObj signal2;
        SignalMethods Sm;

        bool Channel1;//состояние каналов
        bool Channel2;
        bool ground1;//заземление каналов
        bool ground2;

        int X;//Регулировка смещения каналов по горизонтали
        int Y;//Регулировка смещения каналов по вертикали
        int Y1;
        int Y2;

        Color col;

        public OscillForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);

            Sm = new SignalMethods();//задание основных параметров границ сигнала
            Sm.dis = display;
            Sm.width = display.Width;

            Y = Sm.Y;//задается смещение каналов по вертикали
            Y1 = Sm.Y1;
            Y2 = Sm.Y2;

            groudChan1combo.SelectedIndex = 0;//по умолчанию при запуске
            groudChan2combo.SelectedIndex = 0;// выставляется земля

            msmksTimeSweep.SelectedIndex = 0;//единицы показаний времени развертки

            scaleCh1combo.Items.AddRange(FillControllChannel());//добавление значений развертки масштаба по вертикали канала 1
            scaleCh2combo.Items.AddRange(FillControllChannel());//добавление значений развертки масштаба по вертикали канала 2
            sweepcombo.Items.AddRange(FillSweep());//добавление значений времени развертки каналов

            EnableSetColor(false);
            IsEnabled(false);//блокировка элементов управления
        }

        //Основной метод рисования
        private void display_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (onoffradioBut.Checked == false) { return; }//осциллограф выключен

            G.TranslateTransform(X, 0);//смещение по горизонтали

            //Луч 
            if (Channel1 == false && Channel2 == false)
            {
                Sm.DrawGroundSignal(G, Y);
            }
            //Заземленный луч первого канала
            if (Channel1 == true && ground1 == true)
            {
                Sm.DrawGroundSignal(G, Y1);
            }
            //Заземленный луч второго канала
            if (Channel2 == true && ground2 == true)
            {
                Sm.DrawGroundSignal(G, Y2);
            }
            //Кривая первого сигнала
            if (signal1 != null && Channel1 == true && ground1 == false)
            {
                Sm.DrawCurveSignal(signal1, G);
            }
            //Кривая второго сигнала
            if (signal2 != null && Channel2 == true && ground2 == false)
            {
                Sm.DrawCurveSignal(signal2, G);
            }
        }

        #region Включение осциллогрофа
        bool RadButton
        { get; set; }
        private void onoff_Click(object sender, EventArgs e)
        {
            if (onoffradioBut.Checked)
            {
                RadButton = false;
                onoffradioBut.Checked = false;
                IsEnabled(false);
                onoff.Text = "OFF";
            }
            else
            {
                RadButton = true;
                onoffradioBut.Checked = true;
                IsEnabled(true);
                onoff.Text = "ON";
            }
        }

        //Включение/отключение компонент
        private void IsEnabled(bool trfl)
        {
            menuStrip.Enabled = trfl;
            sweepgroupBox.Enabled = trfl;
            genergroupBox.Enabled = trfl;
            channelsgroupBox.Enabled = trfl;
            controlChangroupBox.Enabled = trfl;
            display.Enabled = trfl;
            colorgroupBox.Enabled = trfl;
        }
        #endregion


        #region Генерация сигналов
        //Вызов генератора сигналов
        private void signGener_VisibleChanged(object sender, EventArgs e)
        {
            if (signGener.Visible == true)
            {
                return;
            }
            if (signal1 != null && signal1.Ok == true)
            {//вызов метода создания сигнала
                Sm.CreateNewSignal(Y1, signal1, signGener);
            }
            if (signal2 != null && signal2.Ok == true)
            {
                Sm.CreateNewSignal(Y2, signal2, signGener);
            }
            display.Refresh();
        }
        //Создание первого сигнала
        private void createSignal1_Click(object sender, EventArgs e)
        {
            signGener.Visible = true;
            signal1 = new SignalObj(display.XSize);
            signal1.Ok = true;
            if (signal2 != null)
                signal2.Ok = false;
        }
        //Создание второго сигнала
        private void createSignal2_Click(object sender, EventArgs e)
        {
            signGener.Visible = true;
            signal2 = new SignalObj(display.XSize);
            signal2.Ok = true;
            if (signal1 != null)
                signal1.Ok = false;
        }
        #endregion


        #region Подключение каналов к источникам сигналов
        private void channel1check_CheckedChanged(object sender, EventArgs e)
        {
            if (channel1check.Checked)
                Channel1 = true;
            else
                Channel1 = false;
            display.Refresh();
        }
        private void channel2check_CheckedChanged(object sender, EventArgs e)
        {
            if (channel2check.Checked)
                Channel2 = true;
            else
                Channel2 = false;
            display.Refresh();
        }
        #endregion
        

        #region Поканальное управление выводом развертки сигналов
        //Заземление первого канала
        private void groudChan1combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groudChan1combo.SelectedIndex == 0)
            {
                ground1 = true;
            }//если канал подключен и включен режим "земля"
            else if (Channel1 == true && groudChan1combo.SelectedIndex == 1)
            {
                ground1 = false;
            }
            else if (Channel1 == false)
            {
                ground1 = false;
            }
            display.Refresh();
        }
        //Заземление второго канала
        private void groudChan2combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groudChan2combo.SelectedIndex == 0)
            {
                ground2 = true;
            }
            else if (Channel2 == true && groudChan2combo.SelectedIndex == 1)
            {
                ground2 = false;
            }
            else if (Channel2 == false)
            {
                ground2 = false;
            }
            display.Refresh();
        }

        //Развертка канала 1
        private void scaleCh1combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (signal1 == null) { return; }
            string s = scaleCh1combo.Text;//берётся значение из эл-та управления "комбобокс"
            try
            {
                if (Channel1 == true)
                {
                    signal1.CoeffSweep = (float)Convert.ToDouble(s);
                    Sm.SignalIsChanged(Y1, signal1);//вызов метода изменения сигнала
                }
            }
            catch
            {
                return;
            }
            display.Refresh();
        }

        //Развертка канала 2
        private void scaleCh2combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (signal2 == null) { return; }
            string s = scaleCh2combo.Text;
            try
            {
                if (Channel2 == true)
                {
                    signal2.CoeffSweep = (float)Convert.ToDouble(s);
                    Sm.SignalIsChanged(Y2, signal2);//вызов метода изменения сигнала
                }
            }
            catch
            {
                return;
            }
            display.Refresh();
        }

        //Заполнение массива регулятора чувствительности вертикального отклонения развертки значениями по умолчанию
        private string[] FillControllChannel()
        {
            string[] S = new[]{"0,1","0,2","0,25","0,3","0,5","1","1,5","2","2,5","3","3,5","4","4,5","5","5,5","6","7","8","9",
                "10","15","20","25","30","35","40","45","50","55","60","65","70","75","80","85",
                "90","95","100","110","130","150","170","190","210"};
            return S;
        }
        //Регулировка положения по вертикали (вертикального смещения) первого канала
        private void channel1track_ValueChanged(object sender, EventArgs e)
        {
            if (Channel1 == false && Channel2 == false && ground1 == false && ground2 == false)
            {
                Y = Sm.Y;
            }
            Y1 = Sm.Y1 - channel1track.Value;
            Sm.SignalIsChanged(Y1, signal1);
            display.Refresh();
        }

        //Регулировка положения по вертикали (вертикального смещения) первого канала
        private void channel2track_ValueChanged(object sender, EventArgs e)
        {
            if (Channel1 == false && Channel2 == false && ground1 == false && ground2 == false)
            {
                Y = Sm.Y;
            }
            Y2 = Sm.Y2 - channel2track.Value;
            Sm.SignalIsChanged(Y2, signal2);
            display.Refresh();
        }

        #endregion


        #region Настройка времени развёртки и управление её положением по оси Х
        //Заполнение массива развертки значениями по умолчанию
        private string[] FillSweep()
        {
            string[] S = new[] { "0,1", "0,2", "0,5", "1", "2", "5", "10", "20", "50", };
            return S;
        }
        //Изменение времени развертки
        private void sweepcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (signal1 == null && signal2 == null) { return; }
            string s = sweepcombo.Text;
            try
            {
                if (Channel1 == true)
                {
                    signal1.CoeffDurat = (float)Convert.ToDouble(s);
                    Sm.SignalIsChanged(Y1, signal1);
                }
                if (Channel2 == true)
                {
                    signal2.CoeffDurat = (float)Convert.ToDouble(s);
                    Sm.SignalIsChanged(Y2, signal2);
                }
            }
            catch
            {
                return;
            }
            display.Refresh();
        }
        //Выбор единиц времени развертки
        private void msmksTimeSweep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (msmksTimeSweep.SelectedIndex == 0)//если выбраны миллисекунды
                msORmks(1);
            else if (msmksTimeSweep.SelectedIndex == 1)//микросекунды
                msORmks(1000);
            display.Refresh();
        }//Переключение на микросекунды и обратно (вызов метода изменения сигнала)
        private void msORmks(int x)
        {
            if (signal1 != null)
            {
                signal1.micro = x;
                Sm.SignalIsChanged(Y1, signal1);
            }
            if (signal2 != null)
            {
                signal2.micro = x;
                Sm.SignalIsChanged(Y2, signal2);
            }
        }

        //Смещение развертки по горизонтали
        private void smeschXtrack_Scroll(object sender, EventArgs e)
        {
            //задается смещение каналов по горизонтали
            X = smeschXtrack.Value;
            /*
            Sm.Xbeg = Xbeg + smeschXtrack.Value;
            Sm.Xend = Xend + smeschXtrack.Value;
            if (signal1 != null)
            Sm.SignalIsChanged(Y1, signal1);
            if (signal2 != null)
            Sm.SignalIsChanged(Y2, signal2);*/
            display.Refresh();
        }
        #endregion


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


        #region Cохранение и открытие сигналов
        //сохранение сигналов
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Channel1 == false && Channel2 == false)
            {
                MessageBox.Show("Включители сигнал(ы), который(е) нужно сохранить");
                return;
            }
            else if ((Channel1 == true && signal1 == null) || (Channel2 == true && signal2 == null))
            {
                MessageBox.Show("Первый сигнал пустой");
                return;
            }
            if (Channel1 == true && signal1 != null)
            {
                Sm.SaveSignal(signal1);
            }
            if (Channel2 == true && signal2 != null)
            {
                Sm.SaveSignal(signal2);
            }
        }

        //открытие сигнала
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Channel1 == false && Channel2 == false)
            {
                MessageBox.Show("выберите канал для отображения сигнала");
                return;
            }
            if (Channel1 == true)
            {
                signal1 = Sm.OpenSignal();
            }
            if (Channel2 == true)
            {
                signal2 = Sm.OpenSignal();
            }
            display.Refresh();
        }

        #endregion


        private void Oscilloscope_ClientSizeChanged(object sender, EventArgs e)
        {
            //display.Size = new Size(ClientSize.Width - 280, (ClientSize.Height - 24));
            display.Refresh();
        }


        private void exit_Click(object sender, EventArgs e) { Close(); }


    }
}