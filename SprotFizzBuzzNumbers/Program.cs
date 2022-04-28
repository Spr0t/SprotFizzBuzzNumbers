﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotFizzBuzzNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int[] collection = new int [100];
            for (int i = 0; i < collection.Length; i++)
            {
                collection [i] = number;
                number++;
            }

            foreach (int i in collection)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            
            Console.ReadLine();



        }
    }
}
