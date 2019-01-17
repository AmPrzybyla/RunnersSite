using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RunnersTeamSite.Auth;

namespace RunnersTeamSite.Models
{
    public class Start
    {
        public int Id { get; set; }
        public int CompetitionId { get; set; }
        public virtual Competition Competition { get; set; }

        public decimal Price { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}
