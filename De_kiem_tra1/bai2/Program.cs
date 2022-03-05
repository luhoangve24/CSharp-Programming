using System;

namespace bai2
{
    class Nguoi
    {
        string _HoTen;
        DateTime _NgaySinh;

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ho ten: ");
            _HoTen = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            _NgaySinh = Convert.ToDateTime(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.Write("-- {0} -- {1} -- ", _HoTen, _NgaySinh.ToShortDateString());
        }
    }


    class SinhVien : Nguoi
    {
        string _MSV, _Lop, _Khoa;
        double _DTB, _DRL;

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap MSV: ");
            _MSV = Console.ReadLine();
            Console.WriteLine("Nhap Lop: ");
            _Lop = Console.ReadLine();
            Console.WriteLine("Nhap Khoa: ");
            _Khoa = Console.ReadLine();
            Console.WriteLine("Nhap DTB: ");
            _DTB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap DRL: ");
            _DRL = Convert.ToDouble(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4} -- {5}", _MSV, _Lop, _Khoa, _DTB, _DRL, TotNghiep());
        }

        public Boolean TotNghiep()
        {
            if (_DTB >= 5 && _DRL>=50)
                return true;
            else
                return false;
        }
    }


    class DanhSachSinhVien
    {
        int _SL;
        SinhVien[] _DS;

        public DanhSachSinhVien(int n)
        {
            _SL = n;
            _DS = new SinhVien[_SL];
        }

        public DanhSachSinhVien()
        {
            _SL = 0;
        }

        public void Nhap()
        {
            if (_SL==0)
            {
                Console.WriteLine("Nhap so luong: ");
                _SL = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < _SL; i++)
            {
                Console.Clear();
                _DS[i] = new SinhVien();
                _DS[i].Nhap();
            }
        }

        public void Xuat()
        {
            Console.WriteLine("-- Ho va Ten -- Ngay sinh -- Ma sinh vien -- Lop -- Khoa -- DTB -- DRL -- Duoc tot nghiep --");
            for (int i = 0; i < _SL; i++)
            {
                _DS[i].Xuat();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachSinhVien Lop12E = new DanhSachSinhVien(2);
            Lop12E.Nhap();
            Lop12E.Xuat();
        }
    }
}
