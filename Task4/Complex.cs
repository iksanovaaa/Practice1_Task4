using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Complex  //класс для работы с комплексными числами
    {
        public double r, i; //действительная и мнимая части

        //формирование комплексного числа
        public static Complex Create(double real, double im)
        {
            Complex res = new Complex();
            res.r = real;
            res.i = im;
            return res;
        }

        //сложение комплексных чисел
        public static Complex Sum(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r + b.r;
            res.i = a.i + b.i;
            return res;
        }

        //умножение комплексных чисел
        public static Complex Multiplication(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r * b.r;
            res.i = a.i * b.i;
            return res;
        }
        
        //возведение комплексного числа в степень
        public static Complex Pow(Complex a, int n)
        {
            Complex res = new Complex();
            for (int i = 0; i < n; i++)
            {
                res.r = a.r * a.r;
                res.i = a.i * a.i;
            }
            return res;
        }

        //вычитание комплексных чисел
        public static Complex Subtract(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r - b.r;
            res.i = a.i - b.i;
            return res;
        }

        public static void Print(Complex a)
        {
            if (a.i < 0) Console.Write("{0} - i{1}", a.r, Math.Abs(a.i));
            else Console.Write("{0} + i{1}", a.r, a.i);
        }

        public static void PrintLine(Complex a)
        {
            if (a.i < 0) Console.WriteLine("{0} - i{1}", a.r, Math.Abs(a.i));
            else Console.WriteLine("{0} + i{1}", a.r, a.i);
        }

    }
}
