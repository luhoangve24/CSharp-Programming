using System;

namespace bai1
{
    class SinhVien
    {
        string _HoTen;
        DateTime _NgaySinh;
        double _LT, _CSDL, _WEB, _DTB;

        public SinhVien(string name, DateTime ns,
                    double LT, double CSDL, double WEB)
        {
            _HoTen = name;
            _NgaySinh = ns;
            _LT = LT;
            _CSDL = CSDL;
            _WEB = WEB;
            _DTB = (_LT + _CSDL + _WEB)/3;
        }

        public SinhVien()
        {
            _HoTen = "";
            _LT = 0;
            _CSDL = 0;
            _WEB = 0;
            _DTB = 0;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap ho va ten: ");
            _HoTen = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            _NgaySinh = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhap diem Lap trinh: ");
            _LT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap diem CSDL: ");
            _CSDL = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap diem Lap trinh Web: ");
            _WEB = Convert.ToDouble(Console.ReadLine());
            _DTB = (_LT + _CSDL + _WEB)/3;
        }

        public double TrungBinh
        {
            get
            {
                return _DTB;
            }
        }

        public double LapTrinh
        {
            get
            {
                return _LT;
            }
        }

        public double Coso
        {
            get
            {
                return _CSDL;
            }
        }

        public double ltWeb
        {
            get
            {
                return _WEB;
            }
        }

        public void Xuat()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", _HoTen, _NgaySinh.ToShortDateString(), _LT, _CSDL, _WEB, _DTB);
        }
    }

    class DanhSachSV
    {
        int _SL; // So luong
        SinhVien[] _DS; // Danh sach

        public DanhSachSV(int n)
        {
            _SL = n;
            _DS = new SinhVien[_SL];
        }

        public DanhSachSV()
        {
            _SL = 0;
            Console.WriteLine("Chua nhap so luong, moi ban nhap");
            _SL = Convert.ToInt32(Console.ReadLine());
            _DS = new SinhVien[_SL];
        }

        public void Nhap()
        {
            for (int i = 0; i < _SL; i++)
            {
                Console.Clear();
                _DS[i] = new SinhVien();
                _DS[i].Nhap();               
            }
        }

        public void Xuat()
        {
            Console.WriteLine("--Ho ten--Ngay sinh--Lap trinh--CSDL--Web--DTB");
            foreach (SinhVien item in _DS)
            {
                item.Xuat();
            }
        }

        public void KhoaLuan_ChuyenDe()
        {
            Console.WriteLine("Sinh vien lam khoa luan: ");
            for (int i = 0; i < _SL; i++)
            {
                if(_DS[i].TrungBinh>=8 && _DS[i].Coso>=5 && _DS[i].LapTrinh>=5 && _DS[i].ltWeb>=5)
                {
                    _DS[i].Xuat();
                }
            }

            Console.WriteLine("Sinh vien lam chuyen de: ");
            for (int i = 0; i < _SL; i++)
            {
                if(_DS[i].TrungBinh<8 && _DS[i].Coso>=5 && _DS[i].LapTrinh>=5 && _DS[i].ltWeb>=5)
                {
                    _DS[i].Xuat();
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachSV Lop10A = new DanhSachSV(2);
            Lop10A.Nhap();
            Lop10A.Xuat();
            Lop10A.KhoaLuan_ChuyenDe();
        }
    }
}
