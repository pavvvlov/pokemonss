using pokemons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemons.Controllers
{
    class pokemonsController
    {
        public List<pokemon> GetAllPokemons()
        {
            using (Database1Entities ex = new Database1Entities())
            {
                return ex.pokemons.ToList();
            }
        }

        public void CreatePokemons(pokemon pokemon)
        {
            using (Database1Entities ex = new Database1Entities())
            {
                var lastPokemon = ex.pokemons.ToList().LastOrDefault();
                if (lastPokemon == null)
                {
                    lastPokemon = new pokemon();
                    lastPokemon.Id = 0;
                }
                pokemon.Id = lastPokemon.Id + 1;
                ex.pokemons.Add(pokemon);
                ex.SaveChanges();
            }
            
        }

        internal void Updatepokemon(int id, pokemon pokemon)
        {
            throw new NotImplementedException();
        }
    }
}
