using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFilledSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num : ");
            int number = int.Parse(Console.ReadLine());

            PrintTopRow(number);
            PrintMiddleRow(number);
            PrintMiddleRow(number);
            PrintBottomRow(number);
        }

        private static void PrintBottomRow(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }

        private static void PrintMiddleRow(int number)
        {
            Console.Write('-');
            for (int i = 1; i < number; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        private static void PrintTopRow(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }
    }
}
