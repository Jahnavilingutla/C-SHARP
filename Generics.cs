using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP
{
    internal class Generics
    {
        public delegate T SampleDelegate<T>(T a);
        class Area
        {
            public int Square(int a)
            {
                return a * a;
            }
            public int Cube(int x)
            {
                return x * x * x;
            }
            public double Circle(double x)
            {
                return Math.PI * x * x;
            }
            public double Square(double a)
            {
                return a * a;
            }
            public double Cube(double x)
            {
                return x * x * x;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Area a = new Area();

                SampleDelegate<int> dlgt = new SampleDelegate<int>(a.Square);
                Console.WriteLine("SquareArea Result for int: " + dlgt(10));
                dlgt = a.Cube;
                Console.WriteLine("CubeArea Result for int: " + dlgt(12));

                SampleDelegate<double> dlgt1 = new SampleDelegate<double>(a.Square);
                Console.WriteLine("Square Area Result for double: " + Math.Round(dlgt1(10.5), 2));
                dlgt1 = a.Cube;
                Console.WriteLine("Cube Area Result for double: " + Math.Round(dlgt1(10.2), 2));
                dlgt1 = a.Circle;
                Console.WriteLine("Circle Area Result for double: " + Math.Round(dlgt1(8.6), 2));
                Console.ReadLine();

            }

        }
    }
}
