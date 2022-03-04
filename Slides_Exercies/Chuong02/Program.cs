using System;

namespace Chuong02
{
        // Bai 1
/*             class Tinhtoan
        {
            public double firstNumber;
            public double secondNumber;

            public Tinhtoan(double firstNumber, double secondNumber)
            {
                this.firstNumber = firstNumber;
                this.secondNumber = secondNumber;
            }

            public double Tong()
            {
                return firstNumber + secondNumber;
            }
            
            public double Hieu()
            {
                return firstNumber - secondNumber;
            }

            public double Tich()
            {
                return firstNumber * secondNumber;
            }

            public double Thuong()
            {
                return firstNumber / secondNumber;
            }

            public void Options()
            {
                int stoppoint = 0;
                string luachon = null;
                while(stoppoint == 0)
                {
                    Console.Write("Nhap su lua chon cua ban");
                    luachon = Console.ReadLine();
                    switch(luachon)
                    {
                        case "Tong":
                        {
                            Console.WriteLine(Tong());
                            break;
                        }
                        case "Hieu":
                        {
                            Console.WriteLine(Hieu());
                            break;
                        }
                        case "Tich":
                        {
                            Console.WriteLine(Tich());
                            break;
                        }
                        case "Thuong":
                        {
                            Console.WriteLine(Thuong());
                            break;
                        }
                        default:
                        {
                            Console.WriteLine("Chiu");
                            break;
                        }
                    }

                    Console.WriteLine("Ban co muon nhap tiep ?");
                    stoppoint = Convert.ToInt32(Console.ReadLine());
                }
            } */

        // Bai 2
/*             class So
        {
            public double a;
            public double b;

            public So()
            {
                this.a = 0;
                this.b = 0;
            }
        }
        class PTB2
        {
            public So so = new So();

            public PTB2(double mot, double hai)
            {
                so.a = mot;
                so.b = hai;
            }

            public void Giai()
            {
                if (so.a != 0)
                    Console.WriteLine("Nghiem la: {0}", -so.b/so.a);
                else
                    Console.WriteLine("Sai");
            }
        }
 */
        // Bai 7
/*         class Dayso
        {
            public int n;
            public int[] mang = null;

            public Dayso(int n)
            {
                this.n = n;
            }

            public void Nhap()
            {
                mang = new int[n];
                for(int i=0; i<n; i++)
                {
                    Console.WriteLine("Nhap [{0}]: ", i);
                    mang[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            public void Xuat()
            {
                foreach (int i in mang)
                {
                    Console.Write("{0} ", i);
                }
            }

            public void Sapxep()
            {
                int tmp = 0;
                for (int i=0; i<n-1; i++)
                    for (int j=i+1; j<n; j++)
                    {
                        if(mang[i]<mang[j])
                        {
                            tmp = mang[i];
                            mang[i] = mang[j];
                            mang[j] = tmp;
                        }
                    }
            }
        } */
    class Program
    {

        static void Main(string[] args)
        {
            // Bai 1
/*             Tinhtoan bai1 = new Tinhtoan(1,2);
            bai1.Options(); */

            // Bai 2
/*             PTB2 Vu = new PTB2(0, 4.45);
            Vu.Giai(); */

            // Bai 3
/*             Dayso Vu = new Dayso(5);
            Vu.Nhap();
            Vu.Xuat();
            Array.Sort(Vu.mang);
            //Vu.Sapxep();
            Vu.Xuat(); */
        }
    }
}
