namespace Repositories.PublisherRepository
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public class PublisherRepository : IPublisherRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public PublisherRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Publisher> GetAllPublishers => _appDbContext.Publishers
            .Include(x => x.Games)
            .ToList();

        public Publisher GetPublisherById(int id) => _appDbContext.Publishers
            .AsNoTracking()
            .SingleOrDefault(x => x.Id == id);
    }
}
