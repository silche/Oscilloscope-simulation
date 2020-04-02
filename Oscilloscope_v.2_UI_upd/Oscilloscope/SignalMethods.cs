using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Oscilloscope
{
    class SignalMethods
    {
        public SignalMethods()
        {
            col = Color.Green;
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

        public Color col
        {
            get;
            set;
        }
        
        #region Методы создания и изменения сигналов
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
        public void SignalIsChanged(SignalObj s, int y)
        {
            if (s == null)
                return;
            s.listP.Clear();
            if (s.Garm == 1)
                s.CalculateSin(y, -width, width);
            else if (s.Garm == 0)
                s.CalculateImp(y, -width, width);
        }
        #endregion

        #region Методы рисования
        //Метод отрисовки заземленного сигнала
        public void DrawGroundSignal(Graphics g, int x, int y)
        {//3 пера для создания более красивой кривой сигнала
            Pen penFun1; Pen penFun2; Pen penFun3;
            penFun1 = new Pen(Color.FromArgb(100, col), 5);
            penFun2 = new Pen(Color.FromArgb(200, col), 2);
            penFun3 = new Pen(Color.FromArgb(180, Color.White), 1);

            g.DrawLine(penFun2, -width + x, y, width + x, y);
            g.DrawLine(penFun1, -width + x, y, width + x, y);
            g.DrawLine(penFun3, -width + x, y, width + x, y);

            penFun1.Dispose(); penFun2.Dispose(); penFun3.Dispose();
        }
        //Метод отрисовки включенного сигнала
        public void DrawCurveSignal(SignalObj signal, Graphics g)
        {//3 пера для создания более красивой кривой сигнала
            Pen penFun1; Pen penFun2; Pen penFun3;
            penFun1 = new Pen(Color.FromArgb(100, col), 5);
            penFun2 = new Pen(Color.FromArgb(200, col), 2);
            penFun3 = new Pen(Color.FromArgb(180, Color.White), 1);

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
            penFun1.Dispose(); penFun2.Dispose(); penFun3.Dispose();
        }
        #endregion

        #region Методы смещения сигналов
        //Смещение кривой сигнала
        public void moving(SignalObj s, int dx, int dy)
        {
            if (s == null)
                return;
            PointF pnt;
            //сдвиг каждой точки в списке с помощью цикла
            for (int i = 0; i < s.listP.Count; i++)
            {
                pnt = s.listP[i];
                pnt = new PointF(s.listP[i].X + dx, s.listP[i].Y + dy);
                s.listP[i] = pnt;
            }
        }

        //Определение попадания курсора в линию
        public bool IsIntoGround(int eY, int y)
        {
            bool ok = false;
            int i;
            for (i = eY; i < eY + 7; i++)
            {
                if (i == y)//проверка попадания
                    ok = true;
            }
            if (ok != true)
                for (i = eY; i > eY - 7; i--)
                {
                    if (i == y)
                    {
                        ok = true;
                        break;
                    }
                }

            if (ok == true)
                return true;//возвращаем конечное значение
            else
                return false;
        }

        //Определение попадания курсора в кривую сигнала
        public bool IsIntoSignal(SignalObj s, int x, int y)
        {
            Point p = new Point(x, y);
            bool ok = false;
            int index = 0;
            for (int i = 0; i < s.listP.Count; i++)
            {
                if (p.X == s.listP[i].X)//определение точки Х, при которой
                {//координата Х курсора мыши будет равна точке Х в списке 
                    index = i;//чтобы затем не перебирать точки в списке
                    break;//от нулевого элемента
                }
            }
            int j = 0;
            int k = 0;
            if (s.Garm == 1)//сигнал гармонический
            {
                for (int i = index; i < s.listP.Count - 1; i++)
                {
                    if (ok) break;
                    for (j = p.X; j < p.X + 7; j++)
                    {
                        if (ok) break;//если ок уже тру, то останавливаем цикл
                        for (k = p.Y; k < p.Y + 7; k++)
                        {
                            if (j == s.listP[i].X && k == (int)s.listP[i].Y)
                            {//если нашлась нужная точка (попали)
                                ok = true;
                                break;
                            }
                        }
                    }
                    if (ok != true)
                        for (j = p.X; j > p.X - 7; j--)
                        {
                            if (ok) break;
                            {
                                for (k = p.Y; k > p.Y - 7; k--)
                                    if (j == s.listP[i].X && k == (int)s.listP[i].Y)
                                    {
                                        ok = true;
                                        break;
                                    }
                            }
                        }
                }
            }
            else if (s.Garm == 0)//сигнал импульсный
            {
                for (int i = index; i < s.listP.Count - 1; i = i + 2)
                {
                    for (j = p.Y; j < p.Y + 7; j++)
                    {
                        if (j == s.listP[i].Y)
                        {//если нашлась нужная точка (попали)
                            ok = true;
                            break;
                        }
                    }
                    if (ok != true)
                        for (j = p.Y; j < p.Y - 7; j--)
                        {
                            if (j == s.listP[i].Y)
                            {
                                ok = true;
                                break;
                            }
                        }
                }
            }

            if (ok == true)//возвращаем конечное значение
                return true;
            else
                return false;
        }
        #endregion

        #region Открытие/сохранение сигнала
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
        #endregion
    }
}
