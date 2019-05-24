using System;

namespace CodebarTests
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the Fizz Buzzer! Please enter a number to be the limit: ");
            var numLimit = Int32.Parse(Console.ReadLine());

            var fizzBuzzer = new FizzBuzzer(numLimit);
            fizzBuzzer.FizzBuzz();

            Console.ReadKey();
        }
    }
}
