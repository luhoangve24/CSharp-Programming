using System;

namespace bai1
{
    class Nguoi
    {
        string _HoTen;
        DateTime _NgaySinh;

        public Nguoi(string hoten, DateTime ngaysinh)
        {
            _HoTen = hoten;
            _NgaySinh = ngaysinh;
        }

        public Nguoi()
        {
            _HoTen = "";
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ho va ten: ");
            _HoTen = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            _NgaySinh = Convert.ToDateTime(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.Write("-- {0} -- {1} -- ", _HoTen, _NgaySinh.ToShortDateString());
        }
    }

    
    class BenhNhan : Nguoi
    {
        string _MBN, _TenBenh;
        int _SoNgayNV;
        Boolean _BHYT;

        public BenhNhan(string name, DateTime dob,
                    string tenbenh, string mbn, int songaynv, Boolean bhyt) : base(name, dob)
        {
            _TenBenh = tenbenh;
            _MBN = mbn;
            _SoNgayNV = songaynv;
            _BHYT = bhyt;
        }

        public BenhNhan() : base()
        {
            _MBN ="";
            _TenBenh ="";
            _SoNgayNV = 0;
            _BHYT = false;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap Ma benh nhan: ");
            _MBN = Console.ReadLine();
            Console.WriteLine("Nhap Ten benh: ");
            _TenBenh = Console.ReadLine();
            Console.WriteLine("Nhap So ngay nam vien: ");
            _SoNgayNV = Convert.ToInt32(Console.ReadLine());
            int opt;
            Console.WriteLine("Co Bao hiem y te ? (1. Yes / 2.No )");
            opt = Convert.ToInt32(Console.ReadLine());
            switch(opt)
            {
                case 1:
                {
                    _BHYT = true;
                    break;
                }

                case 2:
                {
                    _BHYT = false;
                    break;
                }

                default:
                {
                    Console.WriteLine("Nhap sai so!");
                    break;
                }
            }
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4} ", _MBN, _TenBenh, _SoNgayNV, _BHYT, TongTien());
        }

        public double TongTien()
        {
            double tien;
            tien = 150000*_SoNgayNV;
            if (_BHYT == true)
            {
                tien -= tien*0.3;
                return tien;
            }
            else
            {
                return tien;
            }
        }
    }


    class DanhSachBenhNhan
    {
        int _SL;
        BenhNhan[] _DS;

        public DanhSachBenhNhan(int n)
        {
            _SL = n;
            _DS = new BenhNhan[_SL];
        }

        public DanhSachBenhNhan()
        {
            _SL = 0;
        }

        public void Nhap()
        {
            if (_SL == 0)
            {
                Console.WriteLine("Chua nhap so luong: ");
                _SL = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < _SL; i++)
            {
                Console.Clear();
                _DS[i] = new BenhNhan();
                Console.WriteLine("Benh nhan {0}", i+1);
                _DS[i].Nhap();
            }
        }

        public void Xuat()
        {
            Console.WriteLine("-- Ho va Ten -- Ngay sinh -- Ma BN -- Ten benh -- So ngay nam -- BHYT -- Tong tien");
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
            DanhSachBenhNhan BachMai = new DanhSachBenhNhan(2);
            BachMai.Nhap();
            BachMai.Xuat();
        }
    }
}
