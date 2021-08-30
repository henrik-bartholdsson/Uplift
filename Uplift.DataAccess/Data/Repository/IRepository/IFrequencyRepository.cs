using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository.IRepository
{
    public interface IFrequencyRepository : IRepository<Frequency>
    {
        IEnumerable<SelectListItem> GetCategoryForDropDown();
        void Update(Frequency frequency);
    }
}
