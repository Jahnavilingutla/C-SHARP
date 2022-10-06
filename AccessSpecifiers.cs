using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP
{
    //Show the difference between public and internal programmatically.
    public class AS1
    {
        double GetArea(double length, double width)
        {
            return length * width;
        }
        public void Display(double length, double width)
        {
            Console.WriteLine("Length:", length);
            Console.WriteLine("Width:", width);
            Console.WriteLine("Area:", GetArea(length,width));
        }
    }
    internal class AccessSpecifiers
    {

       
        double GetArea1(double length, double width)
        {
            return length * width;
        }
        public void Display1(double length,double width)
        {
            double l = length;
            double w = width;
            Console.WriteLine("Area:", GetArea1(l,w));
        }
       

    }
    internal class ABC
    {
        public static void Main()
        {
            AS1 AS1 = new AS1();
            AS1.Display(10.0,20.0);
            AccessSpecifiers AS = new AccessSpecifiers();
            AS.Display1(30.0, 40.0);

        }
    }

}
