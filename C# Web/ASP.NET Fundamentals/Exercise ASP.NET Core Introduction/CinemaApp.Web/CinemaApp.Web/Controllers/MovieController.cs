using CinemaApp.Data;
using CinemaApp.Data.Models;
using CinemaApp.Web.ViewModels.Movie;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace CinemaApp.Web.Controllers
{
    public class MovieController : Controller
    {
        private readonly CinemaDbContext dbContext;

        public MovieController(CinemaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Movie> allMovies = dbContext
                .Movies
                .ToList();

            return View(allMovies);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(AddMovieInputModel inputModel)
        { 
            bool isReleasedDateValid = DateTime.TryParseExact(inputModel.ReleaseDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime releaseDate);

            if (!isReleasedDateValid)
            {
                ModelState.AddModelError(nameof(inputModel.ReleaseDate), "The Released Date must be in the following format: dd/MM/yyyy");
                return View(inputModel);
            }

            if (ModelState.IsValid)
            {
                return View(inputModel);
            }

            Movie movie = new Movie()
            {
                Title = inputModel.Title,
                Genre = inputModel.Genre,
                Director = inputModel.Director,
                Duration = inputModel.Duration,
                ReleaseDate = releaseDate,
                Description = inputModel.Description
            };

            dbContext.Movies.Add(movie);
            dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Details(string id)
        {
            bool isValid = Guid.TryParse(id, out Guid guidId);

            if (!isValid)
            {
                return RedirectToAction(nameof(Index));
            }

            Movie? movie = dbContext
                .Movies
                .FirstOrDefault(m => m.Id == guidId);

            if (movie == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(movie);
        }
    }
}
