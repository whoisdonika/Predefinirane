﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZnakCqloChislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num : ");
            int number = int.Parse(Console.ReadLine());

            PrintSign(number);
        }

        private static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is negative.");
            }
            else
            {
                Console.WriteLine($"{number} is zero.");
            }
        }
    }
}
