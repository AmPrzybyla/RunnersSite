using RunnersTeamSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunnersTeamSite.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public IEnumerable<Competition> Competitions { get; set; }
    }
}
