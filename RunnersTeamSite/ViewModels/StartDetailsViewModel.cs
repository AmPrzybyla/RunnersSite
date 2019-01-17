using RunnersTeamSite.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunnersTeamSite.ViewModels
{
    public class StartDetailsViewModel
    {
        public string CompetitionName { get; set; }

        public double CompetitonDistance { get; set; }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public List<ApplicationUser> Users { get; set; }
    }
}
