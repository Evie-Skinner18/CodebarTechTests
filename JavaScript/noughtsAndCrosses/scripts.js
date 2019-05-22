


// Players alternate to place Xs and Os on the grid until either wins.
// The first player to get 3 of their pieces in a row (up, down, across or diagonally) wins.
// When all 9 squares are full, the game is over. If no player has 3 pieces in a row, the game ends in a tie.


// grab the elements you need
const allBoxes = document.getElementsByClassName('box');
const h2 = document.querySelector('h2');

// winning rows
const row1 = [
    allBoxes[0],
    allBoxes[1],
    allBoxes[2]
];
const row2 = [
    allBoxes[3],
    allBoxes[4],
    allBoxes[5]
];
const row3 = [
    allBoxes[6],
    allBoxes[7],
    allBoxes[8]
];
// winning cols
const col1 = [
    allBoxes[0],
    allBoxes[3],
    allBoxes[6]
];
const col2 = [
    allBoxes[1],
    allBoxes[4],
    allBoxes[7]
];
const col3 = [
    allBoxes[2],
    allBoxes[5],
    allBoxes[8]
];
// winning diagonals
const diagonal1 = [
    allBoxes[2],
    allBoxes[4],
    allBoxes[6]
];
const diagonal2 = [
    allBoxes[0],
    allBoxes[4],
    allBoxes[8]
];


// playerOne is true from the start because we'll start with this one
let playerOne = true;
let playerTwo = false;
let hasWon = false;
let playerPiece = '';


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
        hasWon = checkForAWinner('O');
        if(hasWon) {
            h2.innerHTML = `${playerOneName} is the winner! Well done ${playerOneName}.`;    
        }

        h2.innerHTML = `It's ${playerTwoName}'s turn!`;    
    }
    // player two is crosses
    else {

        allBoxes[boxIndex].innerHTML = 'X';
        
        playerOne = true;
        playerTwo = false;   
        hasWon = checkForAWinner('X');
        if(hasWon) {
            h2.innerHTML = `${playerTwoName} is the winner! Well done ${playerTwoName}.`;    
        }

        h2.innerHTML = `It's ${playerOneName}'s turn!`;
    }
}

function checkForAWinner(playerPiece){

}



