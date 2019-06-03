using System;
namespace CodebarTests
{

    public class FizzBuzzer
    {
        private readonly int _num;
        public string Message;

        public FizzBuzzer(int num)
        {
            _num = num;
        }


        public string FizzBuzz()
        {
            if (_num % 3 == 0 && _num % 5 == 0) Message = "Fizz Buzz";

            else if (_num % 3 == 0) Message = "Fizz";

            else if (_num % 5 == 0) Message = "Buzz";

            else Message = _num.ToString();
          

            return Message;
        }
    }
}
