namespace Repositories.GameRepository
{
    using System.Collections.Generic;
    using Models;

    public interface IGameRepository
    {
        Game GetGameById(int id);
        Game GetGameByName(string name);
        IEnumerable<Game> GetAllGames { get; }
        int Add(Game game);
        void Update(Game game);
        void Delete(int game);
    }
}
