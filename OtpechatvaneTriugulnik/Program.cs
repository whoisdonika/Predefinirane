﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtpechatvaneTriugulnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num : ");
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }

        private static void PrintTriangle(int number)
        {
            for (int i = 0; i < number; i++)
            {
                PrintLine(1, i);
            }

            PrintLine(1, number);

            for (int i = number - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        private static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}

