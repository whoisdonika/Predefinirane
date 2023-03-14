using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num : ");
            double number = double.Parse(Console.ReadLine());
            Console.Write("Enter power : ");
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPowers(number, power));
        }

        private static double RaiseToPowers(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
