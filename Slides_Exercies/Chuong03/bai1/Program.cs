using System;

namespace bai1
{
    class Phanso
    {
        private int TuSo;
        private int MauSo;

        public Phanso()
        {
            TuSo = 0;
            MauSo = 1;
        }

        public Phanso(int a, int b)
        {
            TuSo = a;
            MauSo = b;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap tu so: ");
            TuSo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            MauSo = Convert.ToInt32(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Phan so ban vua nhap la {0}/{1}", TuSo, MauSo);
        }

        public int ucln(int a, int b)
        {
            if (a==0)
                return b;
            return ucln(b%a, a);
        }

        public void RutGon()
        {
            int c = ucln(TuSo, MauSo);
            TuSo /= c;
            MauSo /= c;
            Console.WriteLine("Phan so sau khi rut gon la: {0}/{1}", TuSo, MauSo);
        }

        public Phanso Tong(Phanso ngoai)
        {
            Phanso Total = new Phanso();
            Total.TuSo = TuSo*ngoai.MauSo + ngoai.TuSo*MauSo;
            Total.MauSo = MauSo*ngoai.MauSo;
            return Total;
        }

        public Phanso Hieu(Phanso ngoai)
        {
            Phanso Tru = new Phanso();
            Tru.TuSo = TuSo*ngoai.MauSo - ngoai.TuSo*MauSo;
            Tru.MauSo = MauSo*ngoai.MauSo;
            return Tru;
        }

        public Phanso Thuong(Phanso ngoai)
        {
            Phanso Chia = new Phanso();
            Chia.TuSo = TuSo*ngoai.MauSo;
            Chia.MauSo = MauSo*ngoai.TuSo;
            return Chia;
        }

        public Phanso Tich(Phanso ngoai)
        {
            Phanso Nhan = new Phanso();
            Nhan.TuSo = TuSo*ngoai.TuSo;
            Nhan.MauSo = MauSo*ngoai.MauSo;
            return Nhan;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Phanso A = new Phanso(2, 3);
            Phanso B = new Phanso(5, 6);
            A.Tong(B).Xuat();
            A.Tich(B).Xuat();
            A.Thuong(B).Xuat();
            A.Hieu(B).Xuat();
        }
    }
}
