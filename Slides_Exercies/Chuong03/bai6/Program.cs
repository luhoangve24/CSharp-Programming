using System;

namespace bai6
{
    class SinhVien
    {
        internal string a_MSV, a_Que, a_Hoten;
        internal double a_LT, a_CSDL, a_DTB;
        internal DateTime a_ns;

        public SinhVien()
        {
            a_MSV = null;
            a_Que = null;
            a_Hoten = null;
            a_LT = 0.0;
            a_CSDL = 0.0;
            a_DTB = 0.0;
        }

        public SinhVien(DateTime ns, string MSV, string Que, string Hoten,
                    double LT, double CSDL)
        {
            a_ns = ns;
            a_MSV = MSV;
            a_Que = Que;
            a_Hoten = Hoten;
            a_LT = LT;
            a_CSDL = CSDL;
            a_DTB = (a_LT + a_CSDL)/2;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap MSV: ");
            a_MSV = Console.ReadLine();
            Console.WriteLine("Nhap ho ten: ");
            a_Hoten = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            a_ns = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhap que: ");
            a_Que = Console.ReadLine();
            Console.WriteLine("Nhap diem lap trinh: ");
            a_LT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap diem CSDL");
            a_CSDL = Convert.ToDouble(Console.ReadLine());
            a_DTB = (a_LT + a_CSDL)/2;
        }

        public void Xuat(int opts)
        {
            if (opts == 1)
            {
                Console.WriteLine("MSV --- Ho Ten --- Nam sinh --- Que quan --- Lap trinh --- CSDL --- DTB");
                Console.WriteLine("{0,5} {1,5} {2,10} {3,10} {4,5} {5,5} {6,5}", a_MSV, a_Hoten, a_ns.ToShortDateString(), a_Que, a_LT, a_CSDL, a_DTB);
            }
            if (opts == 2)
            {
                Console.WriteLine("{0,5} {1,5} {2,10} {3,10} {4,5} {5,5} {6,5}", a_MSV, a_Hoten, a_ns.ToShortDateString(), a_Que, a_LT, a_CSDL, a_DTB);
            }
        }
        
    }
    class DanhSach
    {
        private int n; // so luong sinh vien
        private SinhVien[] DS; // mang chua ds sinh vien

        public DanhSach(int n)
        {
            this.n = n;
            DS = new SinhVien[n];
        }

        public void Nhap()
        {
            for (int i = 0; i < n; i++)
            {
                DS[i] = new SinhVien(); // Why? Check it out: 
                                        //https://stackoverflow.com/questions/9832765/c-sharp-array-of-object-object-reference-not-set-to-an-instance-of-an-object 
                Console.WriteLine("Nhap thong tin sinh vien {0}",i+1);
                DS[i].Nhap();
            }
        }

        public void Xuat()
        {
            Console.WriteLine("MSV --- Ho Ten --- Nam sinh --- Que quan --- Lap trinh --- CSDL --- DTB");
            for (int i = 0; i < n; i++)
            {
                DS[i].Xuat(2);
            }
        }

        public void TB8()
        {
            Console.WriteLine("Danh sach sinh vien co DTB > 8.0");
            Console.WriteLine("MSV --- Ho Ten --- Nam sinh --- Que quan --- Lap trinh --- CSDL --- DTB");
            for (int i = 0; i < n; i++)
            {
                if (DS[i].a_DTB > 8)
                {
                    DS[i].Xuat(2);
                }
            }
        }

        public void msvSapxep()
        {
            SinhVien tmp = new SinhVien();
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (String.Compare(DS[i].a_MSV, DS[j].a_MSV)>0)
                    {
                        tmp = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tmp;
                    }
                }
            }

            Console.WriteLine("Sap xep theo MSV");
            Xuat();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
/*             SinhVien Vu = new SinhVien();
            Vu.Nhap();
            Vu.Xuat(1); */

            DanhSach Lop10A = new DanhSach(2);
            Lop10A.Nhap();
            Lop10A.Xuat();
            Lop10A.TB8();
            Lop10A.msvSapxep();
        }
    }
}
