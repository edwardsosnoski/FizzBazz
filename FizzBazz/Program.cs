﻿using System;

namespace FizzBazz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz FizzBuzzWoof = new FizzBuzz();

            for (int i = 1; i <101; i++)
            {
                Console.WriteLine(FizzBuzzWoof.FizzBuzzWoof(i));
            }
        }
    }
}