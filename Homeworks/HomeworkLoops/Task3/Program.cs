﻿using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            do
            {
                {
                    Console.WriteLine(counter);
                }
                counter++;
            } while (counter <= n);

            Console.WriteLine("The End!");
        }
    }
}