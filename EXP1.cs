using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP
{
    internal class EXP1
    {
       public  static void Main(string[] args)
        {
            int Number1, Number2, Result;
            try
            {
                Console.WriteLine("Enter First Number");
                Number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                Number2 = int.Parse(Console.ReadLine());
                Result = Number1 / Number2;
                Console.WriteLine($"Result: {Result}");

            }

            catch (DivideByZeroException DBZE)
            {
                Console.WriteLine("Second Number Should Not Be Zero");
                Console.WriteLine(DBZE.Message);
                Console.WriteLine(DBZE.Source);
                Console.WriteLine(DBZE.StackTrace);
                Console.WriteLine(DBZE.TargetSite);
                Console.WriteLine(DBZE.HelpLink);
                Console.WriteLine(DBZE.InnerException);
            }
            catch (FormatException FE)
            {
                Console.WriteLine("Enter Only Integer Numbers");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Catch Block...");
                
            }
           
            Console.ReadKey();
        }
    }
}
