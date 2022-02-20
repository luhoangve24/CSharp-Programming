using System;

namespace chuong3donggoi
{
    class TamGiac
    {
        private float a, b, c;

        public TamGiac()
        {
            a = 1;
            b = 1;
            c = 1;
        }

        public TamGiac(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void In()
        {
            Console.WriteLine("3 canh cua tam giac la: {0}, {1}, {2}",a,b,c);
        }

        public void Dientich()
        {
            double area, perimeter;
            perimeter = a+b+c;
            perimeter /= 2;
            area = Math.Sqrt(perimeter*(perimeter-a)*(perimeter-b)*(perimeter-c));
            Console.WriteLine("Dien tich {0}",area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TamGiac Vu = new TamGiac(3,4,5);
            Vu.Dientich();
        }
    }
}
