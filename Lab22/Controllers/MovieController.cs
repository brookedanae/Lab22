using Lab22.Database;
using Lab22.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab22.Controllers
{
    public class MovieController : Controller
    {
        private IMovieDatabase _database;

        public MovieController(IMovieDatabase database)
        {
            _database = database;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SearchResultGenre(MovieSearchViewModel model)
        {
            var list = _database.Get().Where(x => x.Genre == model.Genre);
            return View(list);
        }

        public IActionResult SearchResultTitle(MovieSearchViewModel model)
        {
            var list = _database.Get().Where(x => x.Title == model.Title);
            return View(list);
        }
    }
}
