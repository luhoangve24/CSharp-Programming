using System;

namespace bai1
{
    class TamGiac
    {
        private double a, b, c;

        public TamGiac()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public TamGiac(double mot, double hai, double ba)
        {
            a = mot;
            b = hai;
            c = ba;
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap do dai 3 canh tam giac");
            Console.WriteLine("Canh 1: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Canh 2: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Canh 3: ");
            c = Convert.ToDouble(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ba canh Tam giac cua ban: {0},{1},{2}", a, b, c);
        }

        public double DienTich()
        {
            double per, area; // bien chu vi, dien tich
            per = a+b+c;
            per /= 2; // nua chu vi
            area = Math.Sqrt(per*(per-a)*(per-b)*(per-c));
            return area;
        }
    }
    

    class TuDien : TamGiac
    {
        private double chieucao;
        
        public TuDien(double mot, double hai, 
                    double ba, double cao) : base(mot, hai, ba)
        {
            chieucao = cao;
        }

        public TuDien() : base()
        {
            chieucao = 0;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap chieu cao: ");
            chieucao = Convert.ToDouble(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Chieu cao: {0}", chieucao);
        }

        public double TheTich()
        {
            double area = base.DienTich();
            return (chieucao*area)/3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TamGiac deu = new TamGiac(6,6,6);
            deu.Xuat();
            Console.WriteLine("Dien tich Tam giac: {0}", deu.DienTich());
            Console.WriteLine("====================");
            TuDien vu = new TuDien();
/*             vu.Nhap();
            vu.Xuat();
            Console.WriteLine("The tich Tu dien: {0}", vu.TheTich()); */
            vu.Xuat();
            vu.Nhap();
            vu.Xuat();
            Console.WriteLine("The tich: {0}", vu.TheTich());
        }
    }
}
