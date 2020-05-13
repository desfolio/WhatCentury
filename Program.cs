using System;

namespace WhatCentury
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a four digit year: ");
                var year = Convert.ToInt32(Console.ReadLine());
                var century = year / 100;

                if (year % 100 != 0)
                {
                    century += 1;
                }

                Console.WriteLine($"{year} is in Century {century}.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a valid year.");
            }
            
        }
    }
}
