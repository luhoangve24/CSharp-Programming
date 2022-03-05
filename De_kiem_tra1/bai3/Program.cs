using System;

namespace bai3
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


    class GiaoVien : Nguoi
    {
        string _MGV, _TrinhDo, _Khoa, _ChucVu;
        double _HSL;

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap MGV: ");
            _MGV = Console.ReadLine();
            Console.WriteLine("Nhap Trinh do: ");
            _TrinhDo = Console.ReadLine();
            Console.WriteLine("Nhap Khoa: ");
            _Khoa = Console.ReadLine();
            int opt;
            Console.WriteLine("Chon Chuc vu: \n1.Truong khoa\n2.Giao vien");
            opt = Convert.ToInt32(Console.ReadLine());
            switch(opt)
            {
                case 1:
                {
                    _ChucVu = "Truong khoa";
                    break;
                }

                case 2:
                {
                    _ChucVu = "Giao vien";
                    break;
                }

                default:
                {
                    Console.WriteLine("Loi !");
                    _ChucVu = "Giao vien";
                    break;
                }
            }
            Console.WriteLine("Nhap he so luong: ");
            _HSL = Convert.ToDouble(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4} -- {5:C} --", _MGV, _TrinhDo, _Khoa, _ChucVu, _HSL, ThuNhap());
        }

        public double ThuNhap()
        {
            if (_ChucVu == "Truong khoa")
            {
                return _HSL*1150000 + 1000000;
            }
            else
            {
                return _HSL*1150000;
            }
        }
    }

    

    class DanhSachGiaoVien
    {
        int _SL;
        GiaoVien[] _DS;

        public DanhSachGiaoVien(int n)
        {
            _SL = n;
            _DS = new GiaoVien[_SL];
        }

        public DanhSachGiaoVien()
        {
            _SL = 0;
        }

        public void Nhap()
        {
            if (_SL == 0)
            {
                Console.WriteLine("Nhap so luong: ");
                _SL = Convert.ToInt32(Console.ReadLine());
                _DS = new GiaoVien[_SL];
            }

            for (int i = 0; i < _SL; i++)
            {
                Console.Clear();
                _DS[i] = new GiaoVien();
                _DS[i].Nhap();
            }
        }

        public void Xuat()
        {
            Console.WriteLine("-- Ho va ten -- Ngay sinh -- MGV -- Trinh do -- Khoa -- Chuc vu -- HSL -- Luong --");
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
            DanhSachGiaoVien HTTTQL = new DanhSachGiaoVien(2);
            HTTTQL.Nhap();
            HTTTQL.Xuat();
        }
    }
}
