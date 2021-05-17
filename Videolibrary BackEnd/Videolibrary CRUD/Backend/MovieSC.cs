using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videolibrary_CRUD.DataAccess;
using Videolibrary_CRUD.Models;

namespace Videolibrary_CRUD.Backend
{
    public class MovieSC
    {
        protected VideolibraryContext dbContext = new VideolibraryContext();

        public IQueryable<Movie> GetAllMovies()
        {
            return dbContext.Movies.Select(s => s);
        }
        public Movie GetMovieById(int id)
        {
            var movie = GetAllMovies().Where(w => w.Id == id).FirstOrDefault();

            if (movie == null)
                throw new Exception("No exiten coincidencias con el id solicitado.");

            return movie;
        }

        public void DeleteMovieById(int id)
        {
            var movie = GetMovieById(id);
            dbContext.Movies.Remove(movie);
            dbContext.SaveChanges();
        }

        public void UpdateMovieById(int id,MovieModel newMovie)
        {
            Movie currentMovie = GetMovieById(id);

            if(currentMovie == null)
                throw new Exception("No exiten coincidencias con el id solicitado.");

            currentMovie.Title = newMovie.title;
            currentMovie.Director = newMovie.director;
            currentMovie.Genre = newMovie.genre;
            currentMovie.ReleaseDate = newMovie.releaseYear;
            currentMovie.Rating = newMovie.rating;
            dbContext.SaveChanges();
        }

        public void AddMovie(MovieModel newMovie)
        {
            var newMovieRegister = new Movie()
            {
                Title = newMovie.title,
                Director = newMovie.director,
                Genre = newMovie.genre,
                ReleaseDate = newMovie.releaseYear,
                Rating = newMovie.rating
            };
            dbContext.Movies.Add(newMovieRegister);
            dbContext.SaveChanges();
        }
    }
}
