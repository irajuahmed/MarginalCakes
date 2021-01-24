using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MarginalCakes.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDBContext _appDBContext;

        public PieRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _appDBContext
                       .Pies
                       .Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _appDBContext
                       .Pies
                       .Where(c => c.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int pieId)
        {
            return _appDBContext
                   .Pies
                   .Where(c => c.PieId == pieId)
                   .FirstOrDefault();
        }
    }
}
