using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP
{
    internal class param_arr
    {
        public static void Main()
        {
             mul(1,2,3);
            
            
        }
        
        public static int mul(params int[] num)
        {
            for(int i=1;i<=num.Length;i++)
            {
                for(int j=1;j<=10;j++)
                {
                    Console.WriteLine("{0} * {1}= {2}\t", i, j, i*j);
                }
            }
            return 0;
        }


    }
}
