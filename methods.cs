using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP to accept all the employee details using static method and 
//display the details in an instance method:

namespace C_SHARP
{
    /// <summary>
    /// static & instance methods
    /// </summary>
    internal class methods
    {
       

        public static void Main()
        {

            Staticmethod();
            
        }
        //STATIC METHOD
        public static void Staticmethod()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Employee ID");
                int EMPID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee name");
                string Empname = Console.ReadLine();
                Console.WriteLine("Enter Employee designation");
                string Edesig = Console.ReadLine();
                methods m = new methods();
                m.Instancemethod(EMPID, Empname, Edesig);
            }

           

        }
        public void Instancemethod(int EMPID, string Empname, string Edesig)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Emp id is: " + EMPID);
                Console.WriteLine("Emp name is: " + Empname);
                Console.WriteLine("Emp desig is: " + Edesig);

            }
               

        }
    }
}
