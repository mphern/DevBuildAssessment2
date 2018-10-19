using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDimension
{
    class Program
    {
        static void Main()
        {
            int[,] arr = new int[,] {{5,-4,3,0},
                                     {5,1,-2,-1},
                                     {8,6,-7,4},
                                     {-2,1,-5,2}};

            sumDiagonal(arr);
        }
        static void sumDiagonal(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                sum += arr[i,i];
            Console.WriteLine("The sum of the diagonal is "+sum);
        }
    }
}
