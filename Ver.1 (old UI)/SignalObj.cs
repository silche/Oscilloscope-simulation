using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Oscilloscope
{
    [Serializable]
    class SignalObj
    {
        int GarmGarm;
        float UU;//напряжение
        float ff;//частота
        float dpdp;//длительность импульса
        public List<PointF> listP;//список точек
        public float CoeffDurat;//коэффициент длительности
        public float CoeffSweep; //коэффициент развёртки
        public bool Ok;//если создается
        public int micro;//микросекунды
        public int CoeffSet;//коэффициент настройки
        double k1;//коэффициент для частоты

        public SignalObj(int coeffNastr)
        {
            listP = new List<PointF>();
            CoeffDurat = 1;
            CoeffSweep = 1;
            Garm = -1;
            micro = 1;
            this.CoeffSet = coeffNastr;
        }
        public int Garm
        {
            get { return GarmGarm; }
            set { GarmGarm = value; }
        }
        public float U
        {
            get { return UU; }
            set { UU = value; }
        }
        public float F
        {
            get { return ff; }
            set { ff = value; }
        }
        public float ti
        {
            get { return dpdp; }
            set { dpdp = value; }
        }
        public void CalculateSin(int h, int start, int end)
        {
            k1 = 2 * (Math.PI) / (1000 * CoeffSet);
            if (Garm == -1) { return; }
            float p = start;
            while (p != end)
            {
                float y = (float)Math.Sin(p * CoeffDurat * ff * k1 / micro);
                p += 1;
                y = CoeffSet * (float)1.41 * y * UU / CoeffSweep;
                listP.Add(new PointF(p, y + h));
            }
        }
        public void CalculateImp(int h, int start, int end)
        {
            float p = start;
            float x = (float)Math.Pow(ff, -1);
            float tp = (x - dpdp);
            float y = h + CoeffSet * UU / CoeffSweep;
            while (p < end)
            {
                listP.Add(new PointF(p, y));
                p += CoeffSet * dpdp * 1000 * micro / (CoeffDurat);
                listP.Add(new PointF(p, y));
                listP.Add(new PointF(p, h + 0));
                p += CoeffSet * tp * 1000 * micro / (CoeffDurat);
                listP.Add(new PointF(p, h + 0));
            }
        }
    }
}
