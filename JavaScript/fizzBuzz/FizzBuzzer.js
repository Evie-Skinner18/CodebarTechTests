
// when a FizzBuzzer object gets instantiated, it will have a limit of nums to operate on from the start
class FizzBuzzer {
    constructor(numLimit) {
        this.numLimit = numLimit;
    };


    // method
     fizzBuzz() {  

        let result = '';
        let i = 0;

        for(i ; i < this.numLimit; i++) {

            if(i % 5 == 0 && i % 3 == 0){
                //result = 'Fizz Buzz';
                console.log('Fizz Buzz');
            }

            else if(i % 3 == 0){
                //result = 'Fizz';
                console.log('Fizz');                
            }

            else if(i % 5 == 0 ){
               // result = 'Buzz';
               console.log('Buzz');
            }

            else {
                console.log(i);
            }
            //return result;
        }
    }
};

module.exports = FizzBuzzer;