


// When all 9 squares are full, the game is over. If no player has 3 pieces in a row, the game ends in a tie.


// grab the elements you need
const allBoxes = document.getElementsByClassName('box');
const h2 = document.querySelector('h2');

//2D array of all the winning combinations
const winningCombinations = [
    // winning rows
    // 0
    [ allBoxes[0], allBoxes[1], allBoxes[2] ],
    // 1
    [ allBoxes[3], allBoxes[4], allBoxes[5] ],
    //2
    [ allBoxes[6], allBoxes[7], allBoxes[8] ],
    // winning cols
    // 3
    [ allBoxes[0], allBoxes[3], allBoxes[6] ],
    // 4
    [ allBoxes[1], allBoxes[4], allBoxes[7] ],
    // 5
    [ allBoxes[2], allBoxes[5], allBoxes[8] ],
    // winning diagonals
    //6
    [ allBoxes[2], allBoxes[4], allBoxes[6] ],
    // 7
    [ allBoxes[0], allBoxes[4], allBoxes[8] ]

];



// playerOne is true from the start because we'll start with this one
let playerOne = true;
let playerTwo = false;
let hasWon = false;
let playerPiece = '';
let numberOfPieces = 0;


let playerOneName = prompt('Welcome to Noughts and Crosses! Player One, please enter your name:');
let playerTwoName = prompt('Player Two, please enter your name:');

// template literals bookended with backticks
h2.innerHTML = `Let the games begin! ${playerOneName}, GO`;


// make each box listen out for a click from the user and store the index of the box they've clicked in a var
for(let i = 0; i < allBoxes.length; i++){
    allBoxes[i].addEventListener("click", function(){
        var userInput = i;
        console.log(userInput);
        takeTurn(userInput);  
    });
}

// this will get called using the index of the box the user has clicked
function takeTurn(boxIndex){
    // first, check if a nought or cross is already in the given box
    if(allBoxes[boxIndex].innerHTML == 'O' || allBoxes[boxIndex].innerHTML == 'X') {

        h2.innerHTML = `Sorry babber, someone's already put a ${allBoxes[boxIndex].innerHTML} there.`;
    }
    // player 1 is noughts
    else if(playerOne) {

        allBoxes[boxIndex].innerHTML = 'O';

        playerOne = false;
        playerTwo = true; 

        if(boardIsFull()) {
            return h2.innerHTML = `Ooh... It's a draw!`;             
        }

        else  {
            hasWon = checkForAWinner('O');
            if(hasWon) {
                allBoxes[boxIndex].removeEventListener("click", function(){
                    var userInput = i;
                    console.log(userInput);
                    takeTurn(userInput);  
                });
                return h2.innerHTML = `${playerOneName} is the winner! Well done ${playerOneName}.`;
            }

            h2.innerHTML = `It's ${playerTwoName}'s turn!`;
        }
           
    }
    // player two is crosses
    else {

        allBoxes[boxIndex].innerHTML = 'X';
        
        playerOne = true;
        playerTwo = false;
        
        if(boardIsFull()) {
            return h2.innerHTML = `Ooh... It's a draw!`;           
        }
        
        else {
            hasWon = checkForAWinner('X');
            if(hasWon) {
                allBoxes[boxIndex].removeEventListener("click", function(){
                    var userInput = i;
                    console.log(userInput);
                    takeTurn(userInput);  
                });
                return h2.innerHTML = `${playerTwoName} is the winner! Well done ${playerTwoName}.`;    
            }

            h2.innerHTML = `It's ${playerOneName}'s turn!`;            
        }    
    }
}

// loop through all the possible combinations to check for three in a row
function checkForAWinner(playerPiece){

    winningCombinations.forEach(combination => {
        // is there any way of simplifying this? When num of pieces == 3, it currently returns
        // true 8 times because 8 combinations
        if(numberOfPieces == 3) {
            return true;
        }

       numberOfPieces = 0;
       for(let i = 0; i < combination.length; i++) {
           if(combination[i].innerHTML == playerPiece) {
               numberOfPieces++ ;               
           }
       }              
    });  

    return numberOfPieces == 3? true : false;  
}

function boardIsFull(){
    let numberOfFullBoxes = 0;

    for (let i = 0; i < allBoxes.length; i++) {
        if(allBoxes[i].innerHTML.includes('X') || allBoxes[i].innerHTML.includes('O')) {
            numberOfFullBoxes ++ ;
        }
    }

    return numberOfFullBoxes == 9 ? true : false;
}



