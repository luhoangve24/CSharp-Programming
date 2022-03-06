using System;

namespace _49_LeHoangVu_23A4040156
{

    class Nguoi
    {
        string HT_HoangVu;
        DateTime NS_HoangVu;

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ho ten: ");
            HT_HoangVu = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            NS_HoangVu = Convert.ToDateTime(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.Write("-- {0} -- {1} -- ", HT_HoangVu, NS_HoangVu.ToShortDateString());
        }
    }


    class NhanVien : Nguoi
    {
        string _MNV, _ChucVu, _PhongBan;
        double _HSL;

        public override void Nhap()
        {
            Console.Clear();
            base.Nhap();
            Console.WriteLine("Nhap MNV: ");
            _MNV = Console.ReadLine();
            Console.WriteLine("Chon chuc vu: \n1.Truong phong \n2.Nhan vien");
            int opt;
            opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    {
                        _ChucVu = "Truong phong";
                        break;
                    }

                case 2:
                    {
                        _ChucVu = "Nhan vien";
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Loi! Khong ton tai lua chon");
                        _ChucVu = "Nhan vien";
                        break;
                    }
            }

            Console.WriteLine("Nhap Phong ban: ");
            _PhongBan = Console.ReadLine();
            Console.WriteLine("Nhap He so luong: ");
            _HSL = Convert.ToDouble(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4:C} --", _MNV, _ChucVu, _PhongBan, _HSL, TinhLuong(_ChucVu));
        }

        public double TinhLuong(string CV)
        {
            if (CV == "Truong phong")
            {
                return _HSL * 1150000 + 500000;
            }
            else
            {
                return _HSL * 1150000;
            }
        }
    }


    class DanhSachNhanVien
    {
        int _SL;
        NhanVien[] _DS;

        public DanhSachNhanVien(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Dau vao khong hop le! Mac dinh So luong = 0");
                _SL = 0;
            }
            else
            {
                _SL = n;
                _DS = new NhanVien[_SL];
            }
        }

        public DanhSachNhanVien()
        {
            _SL = 0;
        }

        public void Nhap()
        {
            if (_SL == 0)
            {
                Console.WriteLine("Nhap so luong: ");
                _SL = Convert.ToInt32(Console.ReadLine());
                while (_SL <= 0)
                {
                    Console.WriteLine("So luong khong hop le, nhap lai!");
                    Console.WriteLine("Nhap so luong: ");
                    _SL = Convert.ToInt32(Console.ReadLine());
                }
                _DS = new NhanVien[_SL];
            }

            for (int i = 0; i < _SL; i++)
            {
                _DS[i] = new NhanVien();
                _DS[i].Nhap();
            }
        }

        public void Xuat()
        {
            Console.WriteLine("-- Ho va Ten -- Ngay sinh -- Ma NV -- Chuc vu -- Phong ban -- He so luong -- Luong --");
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
            DanhSachNhanVien HTTTQL = new DanhSachNhanVien(2);
            HTTTQL.Nhap();
            HTTTQL.Xuat();
        }
    }
}
