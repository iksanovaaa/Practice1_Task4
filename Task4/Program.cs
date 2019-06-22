using System;

namespace Task4
{
    public class Program
    {
        public static Random rnd = new Random();
        public static double[] a, b;
        public static int n;
        public static double x, y;
        public static Complex complXY;
        public static void Main(string[] args)
        {
            bool end = false;
            do
            {
                n = rnd.Next(1, 5);
                x = rnd.Next(-10, 10);
                y = rnd.Next(-10, 10);
                Console.WriteLine("n = {0}; x = {1}; y = {2}", n, x, y);
                complXY = Complex.Create(x, y);
                a = new double[n + 1]; b = new double[n + 1];
                a = CreateArr();
                b = CreateArr();
                PrintArr("a", a);
                PrintArr("b", b);
                Console.WriteLine("Значение многочлена, вычисленное по схеме Горнера: ");
                Complex.PrintLine(Gorner());
                end = CheckKey();
            } while (!end);
        }

        //формирование массивов
        public static double[] CreateArr()
        {
            double[] arr = new double[n + 1];
            for (int i = 0; i < n+1; i++)
            {
                arr[i] = rnd.Next(-10, 10);
            }
            return arr;
        }
        
        //вывод массивов
        public static void PrintArr(string s, double[] arr)
        {
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write("{0}{1} = {2}; ", s, i, arr[i]);
            }
            Console.WriteLine();
        }

        //вычисление значения многочлена по схеме Горнера
        public static Complex Gorner()
        {
            Complex res = Complex.Create(0, 0);
            for (int i = n; i > 0; i--)
            {
                Complex mult1 = Complex.Create(a[i], b[i]);
                Complex mult2 = Complex.Pow(complXY, i);
                res = Complex.Sum(res, Complex.Multiplication(mult1, mult2));
            }
            Complex tmp = Complex.Create(a[0], b[0]);
            res = Complex.Sum(res, tmp);
            return res;
        }
        //выход из программы или формирование новой последоватльности
        public static bool CheckKey()
        {
            bool next, end = false;
            int keyNum;
            Console.WriteLine("Для выхода из программы нажмите Esc, для вычисления значения другого многочлена нажмите Enter.");
            do
            {
                keyNum = Console.ReadKey().KeyChar;
                next = (keyNum == 27) || (keyNum == 13);
            } while (!next);
            if (keyNum == 27) end = true;
            Console.Clear();
            return end;
        }
    }
}
