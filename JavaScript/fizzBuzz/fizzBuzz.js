// JS equivalent of using statements
const FizzBuzzer = require('./FizzBuzzer.js');
const readline = require('readline');


console.log('fizzBuzz is running');

// in node you have to istantiate a readline object in order to take user input
let lineReader = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
    prompt: 'Welcome to the Fizz Buzzer! Enter a number and I will tell you if it is a Fizz, a Buzz,' +
    ' or a Fizz Buzz.'
});

// lineReader.question(('Welcome to the Fizz Buzzer! Enter a number and I will tell you if it is a Fizz, a Buzz,' +
// ' or a Fizz Buzz.', (answer) => {
//     let userNumber = parseInt(answer);
//     let fizzBuzzer = new FizzBuzzer(userNumber);
//     fizzBuzzer.fizzBuzz();

//     lineReader.close();
// }))

lineReader.prompt();
lineReader.on('line', (line) => {
    let userNumber = parseInt(line);
    let fizzBuzzer = new FizzBuzzer(userNumber);
    fizzBuzzer.fizzBuzz();    
},
    lineReader.close());


//console.log(userInput);


