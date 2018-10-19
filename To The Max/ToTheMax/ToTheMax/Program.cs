using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToTheMax
{
    class Program
    {
        static void Main()
        {
            int arrayLength = ValidateLengthNumber("Please provide a positive integer number greater than zero: ");
            double[] arr = new double[arrayLength];
            for(int i = 0; i < arrayLength; i++)
            {
                arr[i] = ValidateArrayNumber("Please provide a number for the array: ");
            }

            double maxNumber = arr[0];
            foreach(double x in arr)  //using a foreach loop instead of sort because the instructions told me to.  But this would be a lot more efficient using sort.
            {
                if (maxNumber < x)
                    maxNumber = x;
            }
            Console.WriteLine("The maximum number in the array is "+maxNumber);
        }

        static int ValidateLengthNumber(string message)
        {
            Console.Write(message);
            int number;
            while(!int.TryParse(Console.ReadLine(), out number) || number < 1)
            {
                Console.Write("Invalid number.  Try again. "+ message);
            }
            return number;
        }
        static double ValidateArrayNumber(string message)
        {
            Console.Write(message);
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input.  Try again. " + message);
            }
            return number;
        }
    }
}
