using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MovieStore.DL.Interfaces;
using MovieStore.Models.Configurations;
using MovieStore.Models.DTO;

namespace MovieStore.DL.Repositories.MongoRepositories;

public class ActorMongoRepository : IActorRepository
{
    private readonly IMongoCollection<Actor> _actorRepository;
    public ActorMongoRepository(IOptionsMonitor<MongoDbConfiguration> mongoDbConfiguration)
    {
        var client = new MongoClient(mongoDbConfiguration.CurrentValue.ConnectionString);
        var database = client.GetDatabase(mongoDbConfiguration.CurrentValue.DatabaseName);
        _actorRepository = database.GetCollection<Actor>(mongoDbConfiguration.CurrentValue.DatabaseName);
    }
    public List<Actor> GetAllMovies()
    {
        return _actorRepository.Find(Actor => true).ToList();
    }

    public void AddMovie(Actor movie)
    {
        Actor.Id = Guid.NewGuid().ToString();
        _actorRepository.InsertOne(movie);
    }

    public Actor? GetMovieById(string id)
    {
        return _actorRepository.Find(movie => Actor.Id == id).FirstOrDefault();
    }

    public void DeleteMovie(string id)
    {
        _actorRepository.DeleteOne(movie => Actor.Id == id);
    }
    
    public void UpdateMovie(Actor movie)
    {
        _actorRepository.ReplaceOne(movieToEdit => true, movie);
    }

    public Actor? GetActorById(int actorId)
    {
        throw new NotImplementedException();
    }

    public List<Actor> GetActorsById(IEnumerable<int> actorIds)
    {
        throw new NotImplementedException();
    }
}