﻿using System;

namespace CodebarTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzzer(10);

            Console.WriteLine("Welcome to the Fizz Buzzer!");
            fizzBuzzer.FizzBuzz();
            Console.ReadKey();
        }
    }
}
