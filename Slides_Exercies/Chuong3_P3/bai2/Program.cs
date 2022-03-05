using System;

namespace bai2
{
    abstract class Xe
    {
        abstract public void Nhap();
        abstract public void Xuat();
        abstract public double TinhTien(double sogio);
    }

    class XeTai : Xe
    {
        string _Bien;
        double _TrongTai;
        public override void Nhap()
        {
            Console.WriteLine("Nhap bien so: ");
            _Bien = Console.ReadLine();
            Console.WriteLine("Nhap trong tai (kg): ");
            _TrongTai = Convert.ToDouble(Console.ReadLine());
        }

        public override void Xuat()
        {
            Console.WriteLine("\t - Bien so {0}", _Bien);
            Console.WriteLine("\t - Trong tai {0} kg", _TrongTai);
        }

        public override double TinhTien(double sogio)
        {
            if (sogio<=1)
            {
                return 220000;
            }
            else
            {
                return 220000 + (sogio - 1)*85000;
            }
        }

    }

    
    class XeKhach : Xe
    {
        string _Bien;
        int _SoCho;
        public override void Nhap()
        {
            Console.WriteLine("Nhap bien so: ");
            _Bien = Console.ReadLine();

            Console.WriteLine("So cho ngoi: ");
            _SoCho = Convert.ToInt32(Console.ReadLine());
        }

        public override void Xuat()
        {
            Console.WriteLine("\t- Bien so {0}", _Bien);
            Console.WriteLine("\t- So cho {0}", _SoCho);
        }

        public override double TinhTien(double sogio)
        {
            if (sogio<=1)
            {
                return 250000;
            }
            else
            {
                return 250000 + (sogio - 1)*70000;
            }
        }

    }

    
    class Khach
    {
        string _HoTen;
        string _TenXe;
        Xe _LoaiXe;
        double _SoGio;

        public Khach(string name, string opt, double time)
        {
            _HoTen = name;
            switch(opt)
            {
                case "XK":
                {
                    _TenXe = "Xe Khach";
                    _LoaiXe = new XeKhach();
                    break;
                }
                case "XT":
                {
                    _TenXe = "Xe Tai";
                    _LoaiXe = new XeTai();
                    break;
                }
                default:
                {
                    Console.WriteLine("Khong ton tai ma xe");
                    break;
                }
            }
            _SoGio = time;
        }

        public Khach()
        {
            _TenXe = "";
            _HoTen = "";
            _SoGio = 0;
        }

        private void LuaChon(ref Xe oto)
        {
            int opts;
            Console.WriteLine("Xe: \n1.Tai \n2.Khach");
            opts = Convert.ToInt32(Console.ReadLine());
            switch(opts)
            {
                case 1:
                {
                    _TenXe = "Xe Tai";
                    oto = new XeTai();
                    oto.Nhap();
                    break;
                }

                case 2:
                {
                    _TenXe = "Xe Khach";
                    oto = new XeKhach();
                    oto.Nhap();
                    break;
                }

                default:
                {
                    Console.WriteLine("Loi, khong co xe nay");
                    break;
                }
            }
        }

        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("Nhap ho ten: ");
            _HoTen = Console.ReadLine();
            LuaChon(ref _LoaiXe);
            Console.WriteLine("Nhap so gio thue: ");
            _SoGio = Convert.ToDouble(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("-- {0} -- {1} -- {2} -- {3:C} --", _HoTen, _SoGio, _TenXe, _LoaiXe.TinhTien(_SoGio));
            _LoaiXe.Xuat();

        }

        public double TinhTien()
        {
            return _LoaiXe.TinhTien(_SoGio);
        }
    }

    
    class QuanLy
    {
        int _SL; // So luong
        Khach[] _DS; // Danh sach

        public QuanLy(int n)
        {
            _SL = n;
            _DS = new Khach[_SL];
        }

        public QuanLy()
        {
            _SL = 0;
        }

        public void Nhap()
        {
            if (_SL == 0)
            {
                Console.WriteLine("Nhap so luong khach: ");
                _SL = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < _SL; i++)
            {
                _DS[i] = new Khach();
                _DS[i].Nhap();
            }
        }

        public void Xuat()
        {
            Console.WriteLine("-- Ho ten -- So gio thue -- Loai xe thue -- Thanh tien --");
            for (int i = 0; i < _SL; i++)
            {
                _DS[i].Xuat();
            }
        }

        public void TongTien()
        {
            double TotalRevenue = 0;
            for (int i = 0; i < _SL; i++)
            {
                TotalRevenue += _DS[i].TinhTien();
            }

            Console.WriteLine("Tong doanh thu: {0:C}", TotalRevenue);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            QuanLy CTY = new QuanLy(2);
            CTY.Nhap();
            CTY.Xuat();
            CTY.TongTien();
        }
    }
}
