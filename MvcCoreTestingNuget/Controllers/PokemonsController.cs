using Microsoft.AspNetCore.Mvc;
using PokemonGOLibrary.Models;
using PokemonGOLibrary.Repositories;

namespace MvcCoreTestingNuget.Controllers
{
    public class PokemonsController : Controller
    {
        private RepositoryPokemon repo;

        public PokemonsController(RepositoryPokemon repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Pokemon> bichos = this.repo.GetPokemons();
            return View(bichos);
        }

        [HttpPost]
        public IActionResult Index(string nombre)
        {
            List<Pokemon> bichos = this.repo.SearchPokemons(nombre);
            return View(bichos);
        }
    }
}
