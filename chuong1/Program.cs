using System;

namespace chuong1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinhtoan();
        }
        
        static void Tinhtoan()
        {
            int a, b, c;
            Console.WriteLine("Nhap a va b: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            c = BoiChungNN(a, b);
            Console.WriteLine("Phan so: {0}/{1}, BCNN:{2}", a/c, b/c, c);

            Console.WriteLine("Tong: {0}", a+b);

            Console.WriteLine("Hieu: {0}", a-b);

            Console.WriteLine("Tich: {0}", a*b);

            Console.WriteLine("Thuong: {0}", a/b);
        }

        static int BoiChungNN(int a, int b)
        {
            if (a==0)
                return b;
            return BoiChungNN(b%a,a);
        }
    }
}
