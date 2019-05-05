using System;
namespace CodebarTests
{

    public class FizzBuzzer
    {
        private readonly int _numLimit;

        public FizzBuzzer(int numLimit)
        {
            _numLimit = numLimit;
        }


        public void FizzBuzz()
        {
            for(int i = 0; i < _numLimit; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("Fizz Buzz");

                else if (i % 3 == 0) Console.WriteLine("Fizz");

                else if (i % 5 == 0) Console.WriteLine("Buzz");

                else Console.WriteLine(i);
            }
        }
    }
}
