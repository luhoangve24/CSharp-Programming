using System;

namespace bai2
{
    class Diem
    {
        private double x;
        private double y;

        public Diem()
        {
            x = 0;
            y = 0;
        }

        public Diem(double a, double b)
        {
            x = a;
            y = b;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap hoanh do: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap tung do: ");
            y = Convert.ToDouble(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Toa do vua nhap ({0},{1})", x, y);
        }

        public void KhoangCach(Diem ngoai)
        {
            double distance;
            distance = Math.Sqrt((x-ngoai.x)*(x-ngoai.x) + (y-ngoai.y)*(y-ngoai.y));
            Console.WriteLine("Khoang cach: {0}", distance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Diem A = new Diem(2, 3);
            Diem B = new Diem(10, -1);
            A.Xuat();
            B.Xuat();
            A.KhoangCach(B);
        }
    }
}
