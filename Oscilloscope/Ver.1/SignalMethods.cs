using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Oscilloscope
{
    class SignalMethods
    {
        Pen penFun1; Pen penFun2; Pen penFun3;

        public SignalMethods()
        {
            col = Color.Green;
            penFun3 = new Pen(Color.FromArgb(180, Color.White), 1);
        }

        public int width
        {
            get;
            set;
        }

        public Display dis
        {
            get;
            set;
        }

        #region Регулировка смещения каналов
        public int Y
        {
            get
            {
                return Y = dis.Height / 2 - 11;
            }
            set { }
        }
        public int Y1
        {
            get
            {
                return Y1 = dis.Height / 2 - 23;
            }
            set { }
        }
        public int Y2
        {
            get
            {
                return Y2 = dis.Height / 2 + 23;
            }
            set { }
        }

        public Color col
        {
            get;
            set;
        }

        #endregion

        //Cоздание нового сигнала
        public void CreateNewSignal(int y, SignalObj sg, GeneratorSignals gs)
        {
            //гармонический сигнал
            if (gs.garmon.Checked == true & sg != null)
            {
                sg.Garm = 1;
                sg.U = gs.U;
                sg.F = gs.F;
                sg.listP.Clear();
                sg.CalculateSin(y, -width, width);
            }
            //импульсный сигнал
            if (gs.impul.Checked == true)
            {
                sg.Garm = 0;
                sg.U = gs.U;
                sg.F = gs.F;
                sg.ti = gs.Dp;
                sg.CalculateImp(y, -width, width);
            }
        }

        //Изменение сигнала
        public void SignalIsChanged(int z, SignalObj s)
        {
            if (s == null)
                return;
            s.listP.Clear();
            if (s.Garm == 1)
                s.CalculateSin(z, -width, width);
            else if (s.Garm == 0)
                s.CalculateImp(z, -width, width);
        }

        //Метод отрисовки включенного сигнала
        public void DrawCurveSignal(SignalObj signal, Graphics g)
        {
            penFun1 = new Pen(Color.FromArgb(100, col), 5);
            penFun2 = new Pen(Color.FromArgb(200, col), 2);

            if (signal.Garm == 1)//сигнал гармонический
            {
                g.DrawLines(penFun2, signal.listP.ToArray());
                g.DrawLines(penFun1, signal.listP.ToArray());
                g.DrawLines(penFun3, signal.listP.ToArray());
            }
            else if (signal.Garm == 0)//сигнал импульсный
            {
                for (int i = 0; i < signal.listP.Count - 1; i = i + 2)
                {
                    g.DrawLine(penFun2, signal.listP[i], signal.listP[i + 1]);
                    g.DrawLine(penFun1, signal.listP[i], signal.listP[i + 1]);
                    g.DrawLine(penFun3, signal.listP[i], signal.listP[i + 1]);
                }
            }
        }
        //Метод отрисовки заземленного сигнала
        public void DrawGroundSignal(Graphics g, int y)
        {
            penFun1 = new Pen(Color.FromArgb(100, col), 5);
            penFun2 = new Pen(Color.FromArgb(200, col), 2);

            g.DrawLine(penFun2, -width, y, width, y);
            g.DrawLine(penFun1, -width, y, width, y);
            g.DrawLine(penFun3, -width, y, width, y);
        }

        //Метод сохранения сигнала
        public void SaveSignal(SignalObj sn)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "dat |*.dat";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            FileStream fs = new FileStream(sfd.FileName,
            FileMode.Create);
            if (fs == null) return;
            BinaryFormatter BFormater = new BinaryFormatter();
            BFormater.Serialize(fs, sn);
            fs.Close();
        }

        //Метод открытия сигнала
        public SignalObj OpenSignal()
        {
            SignalObj sn = new SignalObj(dis.XSize);
            string str;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "dat |*.dat";
            if (ofd.ShowDialog() != DialogResult.OK)
                return null;
            ofd.FilterIndex = 1;
            str = ofd.FileName;
            FileStream bfs = File.OpenRead(str);
            BinaryFormatter bf = new BinaryFormatter();
            object оb;
            try
            {
                оb = bf.Deserialize(bfs);
            }
            catch
            {
                MessageBox.Show("Данный файл не соответствует структуре сигнала");
                return null;
            }
            bfs.Close();
            //Убеждаемся в том, что объект нужного нам типа
            sn = оb as SignalObj;
            if (sn != null)
            {
                return sn;
            }
            else
            {
                MessageBox.Show("Данный файл не соответствует структуре сигнала");
                return null;
            }
        }
    }
}
