
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

            if(this.numLimit[i] % 3 == 0){
                result = 'Fizz';

                if(this.numLimit[i] % 5 == 0){
                    result = 'Fizz Buzz';
                }
            }
            else if(this.numLimit[i] % 5 == 0 ){
                result = 'Buzz';
            }
            return result;
        }
    }
};

module.exports = FizzBuzzer;