using System;

namespace bai5
{
    class NhanVien
    {
        private string HoTen;
        private DateTime NamSinh;
        private string DiaChi;
        private double Luong;
        private double HeSo;
        private double PhuCap;
        private double TongTien;

        public NhanVien()
        {
            HoTen = null;
            DiaChi = null;
            Luong = 0.0;
            HeSo = 0.0;
            PhuCap = 0.0;
            TongTien = 0.0;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap Ho va ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            NamSinh = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.WriteLine("Nhap he so: ");
            HeSo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap luong: ");
            Luong = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap phu cap: ");
            PhuCap = Convert.ToDouble(Console.ReadLine());
            TongTien = TinhLuong();
        }

        public double TinhLuong()
        {
            TongTien = Luong * HeSo + PhuCap;
            return TongTien; 
        }

        public void Xuat()
        {
            Console.WriteLine("--- Ho ten --- Nam sinh --- Dia chi --- Luong --- He so --- Phu cap --- Tong tien");
            Console.WriteLine("{0,5} {1,10} {2,10} {3,12} {4,10} {5,8} {6,12}", 
                                HoTen, NamSinh.ToShortDateString(), DiaChi, Luong, HeSo, PhuCap, TongTien);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien Vu = new NhanVien();
            Vu.Nhap();
            Vu.Xuat();
        }
    }
}
