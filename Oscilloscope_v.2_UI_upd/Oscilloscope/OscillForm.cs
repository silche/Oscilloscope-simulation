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
        SignalMethods Sm;//методы для обработки действий с сигналами

        bool Channel1;//состояние канала 1
        bool Channel2;//канала 2
        bool ground1;//заземление каналов
        bool ground2;
        
        int X;//Регулировка смещения каналов по горизонтали
        int Y;
        int Y1;//Регулировка смещения канала 1 по вертикали
        int Y2;//канала 2

        bool popalG;//попадание курсором в линию земли
        bool popalG1;//попадание курсором в линию земли канала 1
        bool popalG2;//канала 2
        bool popalS1;//попадание курсором в кривую сигнала 1
        bool popalS2;//сигнала 2

        Point OldCursor;
        Size OldDisplaySize;

        public OscillForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            OldDisplaySize = display.Size;

            Sm = new SignalMethods();
            Sm.dis = display;
            Sm.width = this.Width + 230;//задаются границы сигналов
            
            popalG = false;//попадание курсором в линию земли
            popalG1 = false;//попадание курсором в линию земли канала 1
            popalG2 = false;//канала 2
            popalS1 = false;//попадание курсором в кривую сигнала 1
            popalS2 = false;

            Y = display.Height / 2 - 11;//задается смещение каналов по вертикали
            Y1 = display.Height / 2 - 23;
            Y2 = display.Height / 2 + 23;

            groudChan1combo.SelectedIndex = 1;//по умолчанию при запуске
            groudChan2combo.SelectedIndex = 1;//выставляется открытый ход (не заземлено)

            msmksTimeSweep.SelectedIndex = 0;//единицы показаний времени развертки

            scaleCh1combotoolStrip.Items.AddRange(FillControllChannel());//добавление значений развертки масштаба по вертикали канала 1
            scaleCh2combotoolStrip.Items.AddRange(FillControllChannel());//добавление значений развертки масштаба по вертикали канала 2
            
            
            sweepcombo.Items.AddRange(FillSweep());//добавление значений времени развертки каналов

            IsEnabled(false);//блокировка элементов управления
        }

        //Основной метод рисования
        private void display_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (onoffradioBut.Checked == false) { return; }//осциллограф выключен

            //Луч 
            if (Channel1 == false && Channel2 == false)
            {
                Sm.DrawGroundSignal(G, X, Y);
            }
            //Заземленный луч первого канала
            if (Channel1 == true && ground1 == true)
            {
                Sm.DrawGroundSignal(G, X, Y1);
            }
            //Заземленный луч второго канала
            if (Channel2 == true && ground2 == true)
            {
                Sm.DrawGroundSignal(G, X, Y2);
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
        public void onoff_Click(object sender, EventArgs e)
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

        //Включение/отключение компоненты
        private void IsEnabled(bool trfl)
        {
            display.Enabled = trfl;
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
        private void connectChan1toolStrip_CheckedChanged(object sender, EventArgs e)
        {
            if (connectChan1toolStrip.Checked)
                Channel1 = true;
            else
                Channel1 = false;
            display.Refresh();
        }
        private void connectChan2toolStrip_CheckedChanged(object sender, EventArgs e)
        {
            if (connectChan2toolStrip.Checked)
                Channel2 = true;
            else
                Channel2 = false;
            display.Refresh();
        }
        #endregion        

        #region Управление масштабом развертки сигналов
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
        
        //Заполнение массива регулятора чувствительности вертикального отклонения развертки значениями по умолчанию
        private string[] FillControllChannel()
        {
            string[] S = new[]{"0,1","0,2","0,25","0,3","0,5","1","1,5","2","2,5","3","3,5","4","4,5","5","5,5","6","7","8","9",
                "10","15","20","25","30","35","40","45","50","55","60","65","70","75","80","85",
                "90","95","100","110","130","150","170","190","210"};
            return S;
        }
        //Развертка канала 1
        private void scaleCh1combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (signal1 == null) { return; }
            float s = (float)Convert.ToDouble(scaleCh1combotoolStrip.Text);//берётся значение из эл-та управления "комбобокс"
            try
            {
                if (Channel1 == true)
                {
                    signal1.CoeffSweep = s;
                    Sm.SignalIsChanged(signal1, Y1);//вызов метода изменения сигнала
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
            string s = scaleCh2combotoolStrip.Text;
            try
            {
                if (Channel2 == true)
                {
                    signal2.CoeffSweep = (float)Convert.ToDouble(s);
                    Sm.SignalIsChanged(signal2, Y2);//вызов метода изменения сигнала
                }
            }
            catch
            {
                return;
            }
            display.Refresh();
        }
        #endregion

        #region Настройка времени развёртки
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
                    Sm.SignalIsChanged(signal1, Y1);
                }
                if (Channel2 == true)
                {
                    signal2.CoeffDurat = (float)Convert.ToDouble(s);
                    Sm.SignalIsChanged(signal2, Y2);
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
                Sm.SignalIsChanged(signal1, Y1);
            }
            if (signal2 != null)
            {
                signal2.micro = x;
                Sm.SignalIsChanged(signal2, Y2);
            }
        }
        #endregion
        
        #region Cохранение и открытие сигналов
        //сохранение сигналов
        public void сохранитьToolStripMenu_Click(object sender, EventArgs e)
        {
            if (Channel1 == false && Channel2 == false)
            {
                MessageBox.Show("Включители сигнал(ы), который(е) нужно сохранить");
                return;
            }
            else if ((Channel1 == true && signal1 == null) || (Channel2 == true && signal2 == null))
            {
                MessageBox.Show("Один из сигналов пустой");
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
        public void открытьToolStripMenu_Click(object sender, EventArgs e)
        {
            if (Channel1 == false && Channel2 == false)
            {
                MessageBox.Show("Выберите канал для отображения сигнала!");
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

        #region Смещение сигналов на дисплее
        //Метод, реагирующий на нажатие клавиши мыши, необходимый для опдеделения
        //попадания курсором в нужный элемент
        private void display_MouseDown(object sender, MouseEventArgs e)
        {
            if (Channel1 == false && Channel2 == false)
                if (Sm.IsIntoGround(e.Y, Y))//проверка попадания курсором в общую линию земли
                {
                    popalG = true;
                    return;
                }
            if (ground1 == true && Channel1 == true)
            {
                if (Sm.IsIntoGround(e.Y, Y1))//проверка попадания курсором в линию земли канала 1
                {
                    popalG1 = true;
                    return;
                }
            }
            if (popalG1 != true && ground2 == true && Channel2 == true)
            {
                if (Sm.IsIntoGround(e.Y, Y2))//проверка попадания курсором в линию земли канала 2
                {
                    popalG2 = true;
                    return;
                }
            }
            if (signal1 != null && Channel1 == true && ground1 == false)
            {
                if (Sm.IsIntoSignal(signal1, e.X, e.Y))//проверка попадания курсором в кривую сигнала канала 1
                {
                    popalS1 = true;
                    return;
                }
            }
            if (popalS1 != true && signal2 != null && Channel2 == true && ground2 == false)
                if (Sm.IsIntoSignal(signal2, e.X, e.Y))//проверка попадания курсором в кривую сигнала канала 2
                {
                    popalS2 = true;
                    return;
                }

            OldCursor = e.Location;//запоминаем старое положение курсора
        }
        //Метод, рагирующий на движение мыши, необходим для перемещения элементов
        private void display_MouseMove(object sender, MouseEventArgs e)
        {
            //смещение линий земли
            if (e.Button == MouseButtons.Left && popalG)
            {
                X = X + (e.X - OldCursor.X);
                Y = e.Y;
            }
            if (e.Button == MouseButtons.Left && popalG1)
            {
                X = X + (e.X - OldCursor.X);
                Y1 = e.Y;
            }
            else if (e.Button == MouseButtons.Left && popalG2)
            {
                X = X + (e.Location.X - OldCursor.X);
                Y2 = e.Y;
            }
                //смещение кривых сигналов
            else if (e.Button == MouseButtons.Left && popalS1)
                Sm.moving(signal1, e.X - OldCursor.X, e.Y - OldCursor.Y);

            else if (e.Button == MouseButtons.Left && popalS2)
                Sm.moving(signal2, e.X - OldCursor.X, e.Y - OldCursor.Y);

            OldCursor = e.Location;//запоминаем старое положение курсора
            display.Refresh();
        }

        private void display_MouseUp(object sender, MouseEventArgs e)
        {//запрещаем перемещение после отпускания клавиши мыши
            popalG = false;
            popalG1 = false;
            popalG2 = false;
            popalS1 = false;
            popalS2 = false;
        }
        #endregion

        #region Изменение сетки дисплея
        private void SetCharXtoolStripCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            display.XSize = Convert.ToInt32(SetCharXtoolStripCombo.SelectedItem);
        }
        private void SetCharYtoolStripCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            display.YSize = Convert.ToInt32(SetCharYtoolStripCombo.SelectedItem);
        }
        #endregion

        #region Настройка визульного отображения
        private void AxesColToolStrip_Click(object sender, EventArgs e)
        {
            //изменение цвета осей
            colorDialog.ShowDialog();
            display.ColorAxes = colorDialog.Color;
        }

        private void RisColToolStrip_Click(object sender, EventArgs e)
        {
            //изменение цвета рисок
            colorDialog.ShowDialog();
            display.ColorStrokes = colorDialog.Color;
        }

        private void GridColToolStrip_Click(object sender, EventArgs e)
        {
            //изменение цвета сетки
            colorDialog.ShowDialog();
            display.ColorGrid = colorDialog.Color;
        }

        private void SignalColToolStrip_Click(object sender, EventArgs e)
        {
            //изменение цвета сигнала
            colorDialog.ShowDialog();
            Sm.col = colorDialog.Color;
        }

        private void DispColToolStrip_Click(object sender, EventArgs e)
        {
            //изменение цвета фона дисплея
            colorDialog.ShowDialog();
            display.BackColor = colorDialog.Color;
        }
        
        #endregion
    }
}