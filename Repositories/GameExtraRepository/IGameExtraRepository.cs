namespace Repositories.GameExtraRepository
{
    using Models;
    using System.Collections.Generic;

    public interface IGameExtraRepository
    {
        void Add(GameExtra gameextra);
        ICollection<GameExtra> GetGameExtras(int gameId);
    }
}
