using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunnersTeamSite.Models
{
    public class CompetitionRepository : ICompetitionRepository
    {

        private readonly AppDbContext _context;

        public CompetitionRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Competition> GetAllCopetitions()
        {
            return _context.Competitions;
        }

        public Competition GetCompetitionbyId(int competitionId)
        {
            return _context.Competitions.FirstOrDefault(c => c.Id == competitionId);
        }
    }
}
