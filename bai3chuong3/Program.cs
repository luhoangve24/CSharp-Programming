using System;

namespace bai3chuong3
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

        public void Nhap_mang()
        {
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Phan tu thu {0}: ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void Xuat_mang()
        {
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Phan tu {0}: {1}",i, a[i]);
            }
        }

        public void sapxep(int thutu)
        {
            Console.WriteLine("\n\tSau khi sap xep:");
            if (thutu==0)
                Array.Sort(a);
            else
            {
                Array.Sort(a);
                Array.Reverse(a);
            }
        }

        public int timkiem(int m)
        {
            int check = -1;
            for (int i=0; i<n; i++)
            {
                if(m==i)
                {
                    check = i;
                    break;
                }
            }
            return check;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mang1Chieu Vu = new Mang1Chieu(4);
            Vu.Nhap_mang();
            Vu.Xuat_mang();
            Vu.sapxep(1);
            Vu.Xuat_mang();
            int tim;
            tim = Vu.timkiem(2);
            Console.WriteLine("{0}",tim);
        }
    }
}
