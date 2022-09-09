let url = "https://pokeapi.co/api/v2/pokemon";
const pokemons = [];

$.get(
  url,
  function (pokeapi) {
    pokeapi["results"].forEach(function (pokemon) {
      pokemons.push(pokemon);
    });

    let lastPoke = pokemons[pokemons.length - 1];
    $("#lastPoke").text(lastPoke["name"]);
  },
  "json"
);
