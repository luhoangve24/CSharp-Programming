using System;

namespace bai3
{
    class NhanVien
    {
        string _HoTen, _DiaChi;
        DateTime _NgaySinh;

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ho ten: ");
            _HoTen = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            _DiaChi = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            _NgaySinh = Convert.ToDateTime(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("\n----Thong tin nhan vien----");
            Console.WriteLine("Ho va ten: " + _HoTen);
            Console.WriteLine("Dia chi: " + _DiaChi);
            Console.WriteLine("Ngay sinh: {0}", _NgaySinh.ToShortDateString());
            Console.WriteLine("---------------------------");
        }

        public virtual void Luong()
        {
        }
    }
    

    class NhanVietSanXuat : NhanVien
    {
        int _SoSP;

        public override void Nhap()
        {
            base.Nhap();
             Console.WriteLine("So luong SP: ");
             _SoSP = Convert.ToInt32(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So SP: {0}",_SoSP);
            Luong();
        }

        public override void Luong()
        {
            int luong;
            luong = _SoSP*30000;
            Console.WriteLine("Luong: {0:C}", luong);
        }
    }


    class NhanVienCongNhat : NhanVien
    {
        int _SoNgay;

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("So ngay: ");
            _SoNgay = Convert.ToInt32(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So ngay: {0}", _SoNgay);
            Luong();
        }

        public override void Luong()
        {
            int luong;
            luong = _SoNgay*90000;
            Console.WriteLine("Luong: {0:C}", luong);
        }
    }


    class NhanVienQuanLy : NhanVien
    {
        double _HeSo;
        int _LuongCB;

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap he so: ");
            _HeSo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap luong can ban: ");
            _LuongCB = Convert.ToInt32(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Luong can ban: {0:c}", _LuongCB);
            Console.WriteLine("He so: {0}", _HeSo);
            Luong();
        }

        public override void Luong()
        {
            double luong;
            luong = _HeSo*_LuongCB;
            Console.WriteLine("Luong: {0:C}", luong);
        }
    }


    class DanhSachNhanVien
    {
        int _SLNV; // So luong nhan vien
        NhanVien[] DS; // Danh sach

        public DanhSachNhanVien(int n)
        {
            _SLNV = n;
            DS = new NhanVien[_SLNV];
        }

        public void Nhap()
        {
            for (int i = 0; i < _SLNV; i++)
            {
                Console.Clear();
                LuaChon(ref DS[i]);
                Console.Clear();
                DS[i].Nhap();
            }
        }

        public void Xuat()
        {
            for (int i = 0; i < _SLNV; i++)
            { 
                DS[i].Xuat();  
            }
        }

        static void LuaChon(ref NhanVien thamchieu)
        {
            int opt;
            Console.WriteLine("Chuc vu gi ? \n1. San xuat \n2. Cong nhat \n3. Quan ly");
            opt = Convert.ToInt32(Console.ReadLine());
            switch(opt)
            {
                case 1:
                {
                    thamchieu = new NhanVietSanXuat();
                    break;
                }
                case 2:
                {
                    thamchieu = new NhanVienCongNhat();
                    break;
                }
                case 3:
                {
                    thamchieu = new NhanVienQuanLy();
                    break;
                }
                default:
                {
                    Console.WriteLine("Khong ton tai");
                    break;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachNhanVien CTY = new DanhSachNhanVien(2);
            CTY.Nhap();
            CTY.Xuat();
        }
    }
}
