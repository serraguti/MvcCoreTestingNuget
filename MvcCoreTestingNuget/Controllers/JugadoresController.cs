using Microsoft.AspNetCore.Mvc;
using JugadoresNugetPGS.Repositories;
using JugadoresNugetPGS.Models;

namespace MvcCoreTestingNuget.Controllers
{
    public class JugadoresController : Controller
    {
        private RepositoryJugadores repo;

        public JugadoresController(RepositoryJugadores repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Jugador> players = this.repo.GetJugadores();
            return View(players);
        }
    }
}
