var url = "https://pokeapi.co/api/v2/pokemon/";
var whichPokemon;
const movesArray = new Array();

function searchPokemon() {
    whichPokemon = document.getElementById("searchbar").value;
    whichPokemon = whichPokemon.toLowerCase();
    url = "https://pokeapi.co/api/v2/pokemon/"
    url += whichPokemon; // url = url + pokemon
    fetch(url)
        .then(response => response.json())
        .then(pokemon => {
            var parent = document.getElementById('parent');
            whichPokemon = pokemon.name.toUpperCase();
           // parent.innerHTML = '<p>' + pokemon.name + '</p>';    
            parent.innerHTML = "<img src=" + pokemon.sprites.back_shiny + ">";
            
               for (let i = 0; i < 4; i++)
               {
                   movesArray[i] = pokemon.moves[i];     //getting & assigning pokemon object to movesArray
                   //console.log(movesArray[i]);
               };
           
            displayMoves();
            // console.log(pokemon);
            document.getElementById("pokemonName").innerHTML = whichPokemon;

        }).catch(err => console.log(err))

    function displayMoves() {

        document.getElementById("pokemonMoves1").innerHTML = movesArray[0].move.name;   //getting names of moves
        document.getElementById("pokemonMoves2").innerHTML = movesArray[1].move.name;
        document.getElementById("pokemonMoves3").innerHTML = movesArray[2].move.name;
        document.getElementById("pokemonMoves4").innerHTML = movesArray[3].move.name;

    }
  
}