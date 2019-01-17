using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunnersTeamSite.Models
{
    public class Competition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }
        public DateTime MyProperty { get; set; }
        public double Distance { get; set; }

    }
}
