

// There are two players - X and O.
// The game is played on a 3 x 3 grid.
// Players alternate to place Xs and Os on the grid until either wins.
// A player can only place their piece in an empty square.
// A player's turn is over once they have placed their piece.
// The first player to get 3 of their pieces in a row (up, down, across or diagonally) wins.
// When all 9 squares are full, the game is over. If no player has 3 pieces in a row, the game ends in a tie.


// grab the elements you need
const allBoxes = document.getElementsByClassName('box');
const h2 = document.querySelector('h2');

// playerOne is true from the start because we'll start with this one
let playerOne = true;
let playerTwo = false;

let playerOneName = prompt('Welcome to Noughts and Crosses! Player One, please enter your name:');
let playerTwoName = prompt('Player Two, please enter your name:');

// template literals bookended with backticks
h2.innerHTML = `Let the games begin! ${playerOneName}, GO`;


// make each box listen out for a click from the user and store the index of the box they've clicked in a var
for(let i = 0; i < allBoxes.length; i++){
    allBoxes[i].addEventListener("click", function(event){
        var userInput = i;
        console.log(userInput);
        takeTurn(userInput);  
    });
}

// this will get called using the index of the box the user has clicked
function takeTurn(boxIndex){
    // player 1 is noughts
    if(playerOne) {
        allBoxes[boxIndex].innerHTML = 'O';

        playerOne = false;
        playerTwo = true; 
        h2.innerHTML = `It's ${playerTwoName}'s turn!`;      
    }
    else {
        allBoxes[boxIndex].innerHTML = 'X';

        playerOne = true;
        playerTwo = false;   
        h2.innerHTML = `It's ${playerOneName}'s turn!`;
    }
}


//takeTurn();

