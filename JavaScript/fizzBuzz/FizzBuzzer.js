
// when a FizzBuzzer object gets instantiated, it will have a limit of nums to operate on from the start
class FizzBuzzer {
    constructor(numLimit) {
        this.numLimit = numLimit;
    };


    // method
     fizzBuzz(numLimit) {  

        for(i = 0; i < numLimit.length; i++) {

            if(numLimit[i] % 3 == 0){
                console.log('Fizz');

                if(numLimit[i] % 5 == 0){
                    console.log('Fizz Buzz');
                }
            }
            else if(numLimit[i] % 5 == 0 ){
                console.log('Buzz');
            }
        }
    }
};

export default FizzBuzzer;