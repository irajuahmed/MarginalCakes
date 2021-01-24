using System.Collections.Generic;

namespace MarginalCakes.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
