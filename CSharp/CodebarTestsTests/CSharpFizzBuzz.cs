using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodebarTests;

namespace CodebarTestsTests
{
    [TestClass]
    public class CSharpFizzBuzz
    {
        [TestMethod]
        public void CanReturnFizzBuzz_ShouldReturnTrue()
        {
            var fizzBuzzer = new FizzBuzzer(0);
            var message = fizzBuzzer.FizzBuzz();
        }
    }
}
