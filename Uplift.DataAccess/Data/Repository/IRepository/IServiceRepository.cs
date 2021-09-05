using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository.IRepository
{
    public interface IServiceRepository : IRepository<Service>
    {
        void Update(Service serive);
    }
}
