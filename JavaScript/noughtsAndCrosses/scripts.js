

// There are two players - X and O.
// The game is played on a 3 x 3 grid.
// Players alternate to place Xs and Os on the grid until either wins.
// A player can only place their piece in an empty square.
// A player's turn is over once they have placed their piece.
// The first player to get 3 of their pieces in a row (up, down, across or diagonally) wins.
// When all 9 squares are full, the game is over. If no player has 3 pieces in a row, the game ends in a tie.

//document.write('Connected!');

// grab the elements you need
const allBoxes = document.getElementsByClassName('box');

let playerOne = true;
let playerTwo = false;

function takeTurn(){
    if(playerOne) {
        for(let i = 0; i < allBoxes.length; i++)
    }
}

// for(var i = 0; i < options.length; i++){
//     options[i].addEventListener("click", function(event){
//     var userInput = event.target.getAttribute("data-index");
//      nextLevel(userInput);
  
//    });