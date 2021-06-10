namespace Repositories.ExtraRepository
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public class ExtraRepository : IExtraRepository
    {

        private readonly ApplicationDbContext _appDbContext;
        public ExtraRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Extra> GetAllExtras => _appDbContext.Extras.ToList();

        public Extra GetExtraByName(string name) => _appDbContext.Extras
                   .Include(b => b.GameExtras)
                   .AsNoTracking()
                   .SingleOrDefault(x => x.Name == name);
    }
}
