using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_SHARP
{
    //Get the student details(sid, sname, sdep) using out keyword.
    internal class out_keyword
    {
        public static void Main()
        {
            int sid;
            string sname;
            string sdep;
            pass(out sid, out sname,out sdep);
            Console.WriteLine(sid + " " + sname + " " + sdep); 
        }
        public static void pass(out int stu_id, out string stu_name,out string stu_dept)
        {

            Console.WriteLine("Enter student ID");
            stu_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student name");
            stu_name = Console.ReadLine();
            Console.WriteLine("Enter dept name");
            stu_dept = Console.ReadLine();



        }
    }
}
