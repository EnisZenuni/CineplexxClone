using Domain.Domain.Models;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Implementation
{
    public class MovieService : IMovieService
    {
        public readonly IMovieRepository<Movie> _movieRepository;

        public MovieService(IMovieRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public void CreateNewMovie(Movie m)
        {
            this._movieRepository.Insert(m);
        }

        public void DeleteMovie(int id)
        {
            var ticket = _movieRepository.Get(id);
            this._movieRepository.Delete(ticket);
        }

        public List<Movie> GetAllMovies()
        {
            return _movieRepository.GetAll().ToList();
        }

        public Movie GetDetailsForMovies(int id)
        {
            return this._movieRepository.Get(id);

        }

        public void UpdateExistingMovie(Movie m)
        {
            this._movieRepository.Update(m);
        }
    }
}
