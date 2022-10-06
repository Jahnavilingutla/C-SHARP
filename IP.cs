using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP
{
    //Show the working of inheritance and protected access specifier.
   // Classes: Parent-> Bonus, Child -> Staff - > 3 times the bonus, NonStaff -> 2 times the bonus
   
     class Bonus
        {

            protected int x;

            public Bonus()
            {
                x = 10000;
            }
        }

        class  Staff:Bonus
        {

            public int getBonus()
            {
                return  3*x;
            }
        }
    class NonStaff : Bonus
    {

        public int getBonus()
        {
            return 2 * x;

        }
    }

    class IP
        {

            static void Main(string[] args)
            {
                Staff obj1 = new Staff();
                NonStaff  obj2 = new NonStaff();

               
                Console.WriteLine(" Staff Bonus is : {0}", obj1.getBonus());
                Console.WriteLine("Non Staff Bonus is : {0}", obj2.getBonus()); 
             }
    }
 }



