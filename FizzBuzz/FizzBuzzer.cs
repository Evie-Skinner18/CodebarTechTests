using System;
namespace CodebarTests
{

    public class FizzBuzzer
    {
        private readonly int _numLimit;
        private string _message = "out of the for loop";
        //private readonly int _remainder = 0;


        public FizzBuzzer(int numLimit)
        {
            _numLimit = numLimit;
        }


        public void FizzBuzz()
        {
            for(int i = 0; i < _numLimit; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                Console.WriteLine(i);

                //switch (true)
                //{
                //    case (i % 3 == 0 && i % 5 == 0):
                //        Console.WriteLine("Fizz Buzz");
                //        break;

                //    default:
                //        break;
                //}


            }
            Console.WriteLine(_message);
        }

    }
}
