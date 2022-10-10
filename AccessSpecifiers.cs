using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP
{
    //Show the difference between public and internal programmatically.
    class Student
    {
        public string name = "Sheeran";
        // internal within the same Assembly
        internal string name1 = "Jahnavi";
        
    }

    internal  class AccessSpecifiers
    {
        public  static void Main()
        {

            // creating object of Student class
            Student student1 = new Student();

            // accessing name field and printing it
            Console.WriteLine("Name: " + student1.name);
            Console.WriteLine("Name: " + student1.name1);

           
        }
    }



}
