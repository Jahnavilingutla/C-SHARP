using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP
{
    internal class Control_stmts
    {
        public static void Main()
        {
            //if condition
            int num = 10;
            if (num % 2 == 0)
            {
                Console.WriteLine("It is even number");
            }
            //if else condition
            int num1 = 11;
            if (num1 % 2 == 0)
            {
                Console.WriteLine("It is even number");
            }
            else
            {
                Console.WriteLine("It is odd number");
            }
            //FOR LOOP
            int n;
            int i;
            int sum = 0;
            Console.WriteLine("Enter the value of n");
            n = Convert.ToInt32(Console.ReadLine()); 
           
            for (i = 1; i <= n; i++) 
            {
                sum += i; 
               

            }
            Console.WriteLine("Sum is:{0}", sum); 

            //WHILE LOOP
            Console.WriteLine("WHILE");
            int j = 1;
            while (j < 5) 
            {
                Console.WriteLine("The value is:{0}", j); 
                j++;
            }

            //DO-WHILE LOOP
            Console.WriteLine("DO-WHILE");
            int k = 1;
            do
            {
               
                Console.WriteLine("The value is:{0}", k);
                k++;
            } while (k < 1);

            //foreach
            Console.WriteLine("FOREACH");
            string course = "CSHARP";
            foreach (char c in course)
            {
                Console.WriteLine(c);
                //break and continue
                //break;
                //continue;
                if (c == 'A')
                {
                    //break;
                    continue;
                }
                Console.WriteLine("Hello");
            }

        }


    }
}
