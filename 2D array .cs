using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP
{
    internal class _2D_array
    {
        public static void Main()
        {
            int i, j, n;
            int[,] arr1 = new int[,] { {1,2,3},{4,5,6},{1,2,3 } };
            int[,] arr2 = new int[,] { {7,8,9 }, {10,11,12},{ 4,5,6} };
            int[,] arr3 = new int[3,3];
            n = 3;
          
           
      for (i = 0; i < arr1.GetLength(0); i++)
      for (j = 0; j < arr2.GetLength(0); j++)
      arr3[i, j] = arr1[i, j] + arr2[i, j];
      Console.Write("\nAdding two matrices: \n");
      for (i = 0; i < n; i++) {
         Console.Write("\n");
         for (j = 0; j < n; j++)
         Console.Write("{0}\t", arr3[i, j]);
      }
      Console.Write("\n\n");


        }
    }
}
