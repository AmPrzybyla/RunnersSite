using RunnersTeamSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunnersTeamSite.Models
{
    public class CalendarBar
    {
        private readonly AppDbContext _context;

        public CalendarBar(AppDbContext context)
        {
            _context = context;
        }

        public List<Competition> CompetitionsList { get; set; }

        public List<Competition> GetCalendar()
        {

            return CompetitionsList ?? (CompetitionsList = _context.Competitions.OrderBy(c => c.Date).ToList());
        }
    }
}
