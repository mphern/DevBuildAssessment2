using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOneOut
{
    class Program
    {
        static void Main()
        {
            int range = ValidateNumber("Please provide a positive integer number greater than 0: ");
            int odds = 0;
            CalculateAverage(CalculateOddSum(range, ref odds), odds);

        }
        static int ValidateNumber(string message)
        {
            Console.Write(message);
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
            {
                Console.Write("Invalid number.  Try again. " + message);
            }
            return number;
        }
        static int CalculateOddSum(int range, ref int odds)
        {
            int sum = 0;
            for(int i = 1; i < range+1; i+=2)
            {
                odds += 1;
                sum += i;
            }
            Console.WriteLine("The sum of the odd numbers from 1 to "+range+" is "+sum);
            return sum;
        }

        static void CalculateAverage(int sum, int count)
        {
            double average = (double)sum / count;
            Console.WriteLine("The average of the odds is "+average);
        }
    }
}
