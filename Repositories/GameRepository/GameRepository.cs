namespace Repositories.GameRepository
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public class GameRepository : IGameRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public GameRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Game> GetAllGames => _appDbContext.Games.Include(x => x.Publisher)
                                                                .Include(x => x.GameExtras).ThenInclude(x => x.Extra)
                                                                .AsNoTracking().ToList();
        public Game GetGameById(int id) => _appDbContext.Games.Include(x => x.Publisher)
                                                                .Include(x => x.GameExtras).ThenInclude(x => x.Extra)
                                                                .AsNoTracking().SingleOrDefault(x => x.Id == id);
        public Game GetGameByName(string model) => _appDbContext.Games
                                                                    .Include(b => b.Publisher)
                                                                    .Include(x => x.GameExtras)
                                                                    .ThenInclude(x => x.Extra)
                                                                    .AsNoTracking()
                                                                    .SingleOrDefault(x => x.Name == model);
        public int Add(Game game)
        {
            _appDbContext.Games.Add(game);
            _appDbContext.SaveChanges();
            return game.Id;
        }
        public void Update(Game game)
        {
            Game oldGame = _appDbContext.Games.Single(x => x.Id == game.Id);
            oldGame.Name = game.Name;
            oldGame.YearReleased = game.YearReleased;
            oldGame.PublisherId = game.PublisherId;
            _appDbContext.Entry(oldGame).State = EntityState.Modified;
            _appDbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            Game game = _appDbContext.Games.Find(id);
            _appDbContext.Games.Remove(game);
            _appDbContext.SaveChanges();
        }
    }
}
