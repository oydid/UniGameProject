namespace Repositories.PublisherRepository
{
    using Models;
    using System.Collections.Generic;

    public interface IPublisherRepository
    {
        Publisher GetPublisherById(int id);

        IEnumerable<Publisher> GetAllPublishers { get; }
    }
}
