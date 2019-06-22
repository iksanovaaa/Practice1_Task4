using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() //тестирование класса Complex
        {
            Complex c1 = Complex.Create(4.5, -5.6);
            Assert.AreEqual(c1.r, 4.5);
            Assert.AreEqual(c1.i, -5.6);
            Complex c2 = Complex.Create(5.5, 6.6);
            Complex sum = Complex.Sum(c1, c2);
            Assert.AreEqual(sum.r, 10);
            Assert.AreEqual(sum.i, 1);
            Complex c3 = Complex.Create(2, 3);
            Complex c4 = Complex.Create(-1, 4);
            Complex mult = Complex.Multiplication(c3, c4);
            Assert.AreEqual(mult.r, -14);
            Assert.AreEqual(mult.i, 5);
            Complex c5 = Complex.Create(1, 2);
            Complex pow = Complex.Pow(c5, 3);
            Assert.AreEqual(pow.r, -11);
            Assert.AreEqual(pow.i, -2);
            Complex.Print(pow);
            Complex.Print(c3);
            Complex.PrintLine(pow);
            Complex.PrintLine(c3);
        }
        [TestMethod]
        public void TestMethod2() //тестирование класса Program
        {
            Program.n = 4;
            Program.a = Program.CreateArr();
            Assert.AreEqual(Program.a.Length, Program.n + 1);
            Program.PrintArr("a", Program.a);
            Program.n = 2;
            Program.x = -4;
            Program.y = 8;
            Program.a = new double[3] { 6, -8, -1 };
            Program.b = new double[3] { -5, -9, -4 };
            Program.complXY = Complex.Create(Program.x, Program.y);
            Complex res = Complex.Create(0, 0);
            res = Program.Gorner();
            Assert.AreEqual(res.r, -98);
            Assert.AreEqual(res.i, 223);
        }
    }
}
