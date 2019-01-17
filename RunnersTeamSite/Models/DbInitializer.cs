using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunnersTeamSite.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if(!context.Competitions.Any())
            {
                context.AddRange
                    (
                new Competition { Name = "Bieg Nadodrzańśki", City = "Racibórz", Distance = 10 },
                new Competition { Name = "Bieg Twardziela", City = "Racibórz", Distance = 7.5 }
                );

                context.SaveChanges();
            }

        }
    }
}
