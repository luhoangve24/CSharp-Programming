using System;

namespace bai2
{
    class TienDien
    {
        string _TenChu, _DiaChi;
        double _truocCT, _hientaiCT;

        public TienDien()
        {
            _TenChu = "";
            _DiaChi = "";
            _truocCT = 0;
            _hientaiCT = 0;
        }

        public TienDien(string name, string loca, 
                    double truocCT, double hientaiCT)
        {
            _TenChu = name;
            _DiaChi = loca;
            _truocCT = truocCT;
            _hientaiCT = hientaiCT;
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Ten chu ho: ");
            _TenChu = Console.ReadLine();
            Console.WriteLine("Dia chi cua chu ho: ");
            _DiaChi = Console.ReadLine();
            Console.WriteLine("Nhap so Cong-to thang truoc va hien tai");
            Console.Write("\tThang truoc: ");
            _truocCT = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\tHien tai: ");
            _hientaiCT = Convert.ToDouble(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("---------Thong tin khach hang----------");
            Console.WriteLine("\tHo ten: "+ _TenChu);
            Console.WriteLine("\tDia chi: "+ _DiaChi);
            Console.WriteLine("\tCT thang truoc: {0}", _truocCT);
            Console.WriteLine("\tCT hien tai: {0}", _hientaiCT);
            Console.WriteLine("----------------------------------------");
        }

        public double _dadungCT
        {
            get
            {
                return _hientaiCT - _truocCT;
            }
        }

        public virtual void TongTien()
        {
            Console.WriteLine("Tien dien: {0}", _dadungCT*500);
        }
    }

    
    class TienDienMoi : TienDien
    {
        double _DinhMuc;
        public TienDienMoi(string name, string loca, 
                    double truocCT, double hientaiCT, double dinhmuc) : base(name, loca, truocCT, hientaiCT)
        {
            _DinhMuc = dinhmuc;
        }

        public TienDienMoi() : base()
        {
            _DinhMuc = 0;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap dinh muc: ");
            _DinhMuc = Convert.ToDouble(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Dinh muc: {0}", _DinhMuc);
        }

        public override void TongTien()
        {
            double tien;
            if (base._dadungCT > _DinhMuc)
            {
                tien = (base._dadungCT - _DinhMuc)*600 + _DinhMuc*500;
            }
            else
            {
                tien = base._dadungCT*500;
            }
            Console.WriteLine("Tong tien: {0}", tien);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            TienDien nhaVu = new TienDien("Le Hoang Vu", "Soc Son", 64, 100);
            nhaVu.Xuat();
            nhaVu.TongTien();

            TienDienMoi nhaMinh = new TienDienMoi("Le Hoang Minh", "Soc Son, Ha Noi", 60, 100, 30);
            nhaMinh.Xuat();
            nhaMinh.TongTien();
        }
    }
}
