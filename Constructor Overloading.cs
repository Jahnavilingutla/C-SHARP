using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Show the working of Constructor Overloading:
//add(int, int),add(float, float),add(string, string)
namespace C_SHARP
{
    internal class ADD
    {
        
        int x, y;
        float f1, f2;
        string s1,s2;

        // 1st constructor
        public ADD(int a, int b)
        {
            x = a;
            y = b;
            Console.WriteLine("1st constructor (int + int): {0} ",
                                                           (x + y));
        }

        // 2nd constructor
        public ADD(float c,float d)
        {
          f1= c;
          f2= d;
          Console.WriteLine("1st constructor (float + float): {0} ",
                                                             (f1+f2));
        }
        // 3rd constructor
        public ADD(string e, string f)
        {
           s1= e;
           s2 = f;
           Console.WriteLine("1st constructor (string+string): {0} ",
                                                              (s1 + " "+s2));

        }

        
    }

    // Driver Class
    class MO
    {

        // Main Method
        static void Main()
        {

            // Creating instance and
            // passing arguments
            // It will call the first constructor
            ADD g = new ADD(10, 20);
            ADD q = new ADD(10.5f, 20.0f);
            ADD r = new ADD("janu", "sai");

        }
    }
}

