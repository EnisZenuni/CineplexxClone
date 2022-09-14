using Domain.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie GetDetailsForMovies(int id);
        void CreateNewMovie(Movie m);
        void UpdateExistingMovie(Movie m);

        void DeleteMovie(int id);
    }

}
