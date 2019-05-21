// Write a short program that prints each number from 1 to 100 on a new line.

// For each multiple of 3, print "Fizz" instead of the number.
// For each multiple of 5, print "Buzz" instead of the number.
// For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.
// For all other numbers, print the number itself.

console.log('fizzBuzz is running');
const FizzBuzzer = require('./FizzBuzzer.js');

let fizzBuzzer = new FizzBuzzer(10);
fizzBuzzer.fizzBuzz();