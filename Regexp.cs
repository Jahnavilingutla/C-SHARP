using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_SHARP
{
    // Using Regular expression validate a 10 digit mobile number.
    // Note: First digit must be(9or8or7)
    internal class Regexp
    {
        public static void Main()
        {
            
            mobile();

        }
       
        
        /// <summary>
        /// mobile validation
        /// </summary>
        public static void mobile()
        {
            Console.WriteLine("mobile validation");
            string mobile = "9502683776";
            var validate_mobile = Regex.IsMatch(mobile, @"^{9|8|7}[0-9]{10}$");
            Console.WriteLine(mobile +" is" + validate_mobile);
        }
    }
}
