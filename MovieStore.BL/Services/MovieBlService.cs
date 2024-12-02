using MovieStore.BL.Interfaces;
using MovieStore.DL.Interfaces;
using MovieStore.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.BL.Services
{
    internal class MovieBlService : 
    {
        private readonly IMovieService movieService;
        private readonly IActorRepository actorRepository;
        public IEnumerable<MoviesView> GetDetailedMovies()

        {
            var result = new List<MovieView>();
            var movies:List<Movie>



                foreach (var movie in movies) {
                var movieView = new MovieView
                {
                    MovieId = movie.Id,
                    MovieTitle = movie.Title,
                    MovieYear = movie.Year,
                    Actors = new List<Actor>(capacity: movie.Actors.Count())
                };
                foreach (var id:int in movie.Actors){
                    var actorDto = _actorRepository.GetById(id);
                    actors.Add(actorDto);
                }
                movieView.Actors = actors;
                result.Add(movieView);

        }
            return result;
    }
}
