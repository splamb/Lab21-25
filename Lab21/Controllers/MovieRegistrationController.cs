using Lab21.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21.Controllers
{
    public class MovieList
    {
        public static List<Movie> Movies = new List<Movie>();
    }

    public class MovieRegistrationController : Controller
    {
        private List<Movie> _allMovies;

        public MovieRegistrationController()
        {
            _allMovies = MovieList.Movies;
        }

        public List<Movie> testMovies;

        // GET: MovieRegistrationController
        public ActionResult Index()
        {
            return View(_allMovies);
        }

        public ActionResult IndexSpecific(Movie newMovie)
        {
            ViewData["Message"] = $"{newMovie.Title} has been successfully registered.";
            return View("Index", _allMovies);
        }

        // GET: MovieRegistrationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieRegistrationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieRegistrationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("ID", "Title", "Genre", "Year", "Actors", "Directors")]Movie newMovie)
        {
            try
            {
                MovieList.Movies.Add(newMovie);
                
                return RedirectToAction(nameof(IndexSpecific), newMovie);
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieRegistrationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieRegistrationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieRegistrationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieRegistrationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
