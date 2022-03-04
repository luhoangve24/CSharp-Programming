using System;

namespace bai4
{
    class MaTran
    {
        private int m; // so dong
        private int n; // so cot
        private int[,] a; // mang 2 chieu

        public MaTran(int m, int n)
        {
            this.m = m;
            this.n = n;
            a = new int[m, n];
        }

        public void Nhap()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("a[{0},{1}]", i, j);
                    a[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void Xuat()
        {
            Console.WriteLine("Ma tran vua nhap la: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", a[i,j]);
                }
                Console.WriteLine();
            }
        }

        public MaTran Tong(MaTran ngoai)
        {
            MaTran cong = new MaTran(m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    cong.a[i,j] = a[i,j] + ngoai.a[i,j];
                }
            }
            return cong;
        }

        public MaTran Hieu(MaTran ngoai)
        {
            MaTran tru = new MaTran(m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tru.a[i,j] = a[i,j] - ngoai.a[i,j];
                }
            }
            return tru;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MaTran Vu = new MaTran(2, 3);
            Vu.Nhap();
            Vu.Xuat();
            MaTran Minh = new MaTran(2, 3);
            Minh.Nhap();
            Minh.Xuat();
            Vu.Tong(Minh).Xuat();
            Vu.Hieu(Minh).Xuat();
        }
    }
}
