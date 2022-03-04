using System;

namespace bai3
{
    class Mang1Chieu
    {
        private int n;
        int[] a;

        public Mang1Chieu(int n)
        {
            this.n = n;
            a = new int[n];
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap cac phan tu cho mang: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}]: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void Xuat()
        {
            Console.WriteLine("Duyet mang: ");
            foreach (int item in a)
            {
                Console.Write("{0} ", item);
            }
        }

        public void SapXep(int thutu)
        {
            if (thutu==0)
            {
                Array.Sort(a);
                Console.WriteLine("\nSau khi sap xep tang dan: ");
                Xuat();
            }
            else
            {
                Array.Sort(a);
                Array.Reverse(a);
                Console.WriteLine("\nSau khi sap xep giam dan: ");
                Xuat();
            }
        }

        public int TimKiem(int m)
        {
            for (int i = 0; i < n; i++)
            {
                if(a[i]==m)
                {
                    return i;
                }
            }
            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mang1Chieu Vu = new Mang1Chieu(5);
            Vu.Nhap();
            Vu.Xuat();
            Vu.SapXep(1);
            Console.WriteLine("\nTim: {0}", Vu.TimKiem(4));
        }
    }
}
