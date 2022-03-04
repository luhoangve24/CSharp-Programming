using System;

namespace Chuong01
{
    class Phanso
    {
        public int tu;
        public int mau;

        public Phanso()
        {
            tu = 0;
            mau = 1;
        }
        public Phanso(int tu, int mau)
        {
            this.tu = tu;
            if(mau==0)
            {
                Console.WriteLine("Under not 0, set default to 1");
                this.mau = 1;
            }
            else
                this.mau = mau;
        }

        public int UCLN(int a, int b)
        {
            if(a==0)
                return b;
            return UCLN(b%a,a);
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap tu: ");
            tu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap mau: ");
            do
            {
                mau = Convert.ToInt32(Console.ReadLine());
                if(mau==0)
                    Console.WriteLine("Sai, nhap lai");
            }while(mau==0);
        }

        public void Xuat()
        {
            Console.WriteLine("Phan so: {0}/{1}", tu, mau);
        }

        public Phanso Tong(Phanso hai)
        {
            Phanso Total = new Phanso();
            Total.tu = (tu*hai.mau + hai.tu*mau);
            Total.mau = mau*hai.mau;
            return Total;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Phanso Minh = new Phanso(2, 3);
            Phanso Vu = new Phanso(2, 4);
            Minh.Xuat();
            Vu.Xuat();
            (Vu.Tong(Minh)).Xuat();
        }
    }
}
