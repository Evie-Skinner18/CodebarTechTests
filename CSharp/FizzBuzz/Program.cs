using System;

namespace CodebarTests
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the Fizz Buzzer! Please enter a number and I will give you its " +
                              "message. Type exit to leave.");
            var userNum = Console.ReadLine();

            while (userNum != "exit")
            {
                var fizzBuzzer = new FizzBuzzer(Int32.Parse(userNum));
                Console.WriteLine(fizzBuzzer.FizzBuzz());
                userNum = Console.ReadLine();
            }

            Console.WriteLine("Ciao!");
        }
    }
}
