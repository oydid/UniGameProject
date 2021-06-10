namespace Repositories.ExtraRepository
{
    using Models;
    using System.Collections.Generic;

    public interface IExtraRepository
    {
        IEnumerable<Extra> GetAllExtras { get; }
        Extra GetExtraByName(string name);
    }
}
