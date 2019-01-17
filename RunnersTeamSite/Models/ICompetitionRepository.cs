using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunnersTeamSite.Models
{
    public interface ICompetitionRepository
    {
        IEnumerable<Competition> GetAllCopetitions();
        Competition GetCompetitionbyId(int competitionId);
    }
}
