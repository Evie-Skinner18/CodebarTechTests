using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodebarTests;

namespace CodebarTestsTests
{
    [TestClass]
    public class CSharpFizzBuzz
    {
        [TestMethod]
        public void CanReturnFizzBuzzFor0_ShouldReturnTrue()
        {
            var fizzBuzzer = new FizzBuzzer(0);
            var message = fizzBuzzer.FizzBuzz();

            Assert.AreNotEqual(message, null);
            Assert.AreEqual(message, "Fizz Buzz");
        }

        [TestMethod]
        public void CanReturnFizzFor3_ShouldReturnTrue()
        {
            var fizzBuzzer = new FizzBuzzer(3);
            var message = fizzBuzzer.FizzBuzz();

            Assert.AreNotEqual(message, null);
            Assert.AreEqual(message, "Fizz");
        }

        [TestMethod]
        public void CanReturnBuzzFor5_ShouldReturnTrue()
        {
            var fizzBuzzer = new FizzBuzzer(5);
            var message = fizzBuzzer.FizzBuzz();

            Assert.AreNotEqual(message, null);
            Assert.AreEqual(message, "Buzz");
        }

        [TestMethod]
        public void CanNotReturnFizzBuzzOrFizzBuzzFor7_ShouldReturnTrue()
        {
            var fizzBuzzer = new FizzBuzzer(7);
            var message = fizzBuzzer.FizzBuzz();

            Assert.AreNotEqual(message, null);

            Assert.AreNotEqual(message, "Fizz");
            Assert.AreNotEqual(message, "Buzz");
            Assert.AreNotEqual(message, "Fizz Buzz");

            Assert.AreEqual(message, "7");
        }
    }
}
