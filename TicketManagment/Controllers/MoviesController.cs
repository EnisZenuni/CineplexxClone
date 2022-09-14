using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Service.Interface;


namespace TicketManagment.Models
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }


        // GET: Movies
        public async Task<IActionResult> Index()
        {
            return View(this._movieService.GetAllMovies());
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = _movieService.GetDetailsForMovies(id ?? 0);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieService.CreateNewMovie(movie);
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = _movieService.GetDetailsForMovies(id ?? 0);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _movieService.UpdateExistingMovie(movie);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = _movieService.GetDetailsForMovies(id ?? 0);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _movieService.DeleteMovie(id);
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _movieService.GetDetailsForMovies(id) != null;
        }

        public async Task<IActionResult> BookMovieTicket(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /* var MovieSelected = await _context.Movie
                 .Include(t => t.Tickets)
                 .FirstOrDefaultAsync(m => m.MovieId == id); */
            var MovieSelected = _movieService.GetDetailsForMovies(id);
            

            return View(MovieSelected);

        }
    }
}
