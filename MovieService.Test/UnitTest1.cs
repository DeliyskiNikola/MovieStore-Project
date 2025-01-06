using System.Reflection;
using Microsoft.VisualBasic;
using Moq;

namespace MovieService.Test
{
    public class BusinessServiceTests
    {



        private Mock<IActorRepository> _actorRepository;
        private Mock<IMovieRepository> _movieRepository;

        private List<Movie> _movies = new List<Movie>
        {
            new Movie()
            {
               Id = Guid.NewGuid().ToString(),
               Title = "Movie 1",
               Year = 2021,
               Actors = ["Actor 1","Actor 2"]


            }




        };

        [Fact]
        public void Test1()
        {

        }
    }
}