using System;

namespace chuong3
{
/*     struct ps
    {
        public int tu;
        public int mau;
    } */
    class Phanso
    {
        // private ps a;
        public int Tuso;
        public int Mauso;

        public Phanso()
        {
            Tuso = 0;
            Mauso = 1;
        }

        public Phanso(int Tuso, int Mauso)
        {
            this.Tuso = Tuso;
            this.Mauso = Mauso;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap tu so va mau so: ");
            Tuso = Convert.ToInt32(Console.ReadLine());
            Mauso = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phan so vua nhap la: {0}/{1} ", Tuso, Mauso);
        }

        public void In()
        {
            Console.Write("Phan so vua nhap la: {0}/{1} ", Tuso, Mauso);
        }

        public int ucln(int Tu, int Mau)
        {
            if(Tu==0)
                return Mau;
            return ucln(Mau%Tu, Tu);
        }

        public void Rutgon()
        {
            int c = ucln(Tuso, Mauso);
            Tuso = Tuso/c;
            Mauso = Mauso/c;
            Console.WriteLine("\nPhan so sau khi rut gon la: {0}/{1}", Tuso, Mauso);
        }

        public void Tong(Phanso b)
        {
            Phanso c = new Phanso();
            c.Tuso = Tuso*b.Mauso + Mauso*b.Tuso;
            c.Mauso = Mauso*b.Mauso;
            Console.WriteLine("{0}/{1}",c.Tuso, c.Mauso);
        }
    }

    class Program
    {
            static void Main(string[] args)
        {
            Phanso PScuatoi = new Phanso(2,4);
            PScuatoi.In();
            PScuatoi.Rutgon();
            
            Phanso PScuatoi2 = new Phanso(3,5);
            PScuatoi2.In();
            PScuatoi2.Tong(PScuatoi);
        }
    }
}
