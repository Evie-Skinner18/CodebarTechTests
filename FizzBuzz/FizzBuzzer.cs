using System;
namespace CodebarTests
{

    public class FizzBuzzer
    {
        private readonly int _numLimit;
        private string _message = "out of the for loop";


        public FizzBuzzer(int numLimit)
        {
            _numLimit = numLimit;
        }


        public string FizzBuzz()
        {
            for (int i = 0; i < _numLimit; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    return "Fizz Buzz";
                }

                if (i % 3 == 0)
                {
                    return "Fizz";
                }

                if (i % 5 == 0)
                {
                    return "Buzz";
                }

                return i.ToString();
            }
            return _message;
        }

    }
}
