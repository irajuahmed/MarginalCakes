using MarginalCakes.Models;
using System.Collections.Generic;

namespace MarginalCakes.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
