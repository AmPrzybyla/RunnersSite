using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunnersTeamSite.ViewModels
{
    public class DaneViewModel
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
    }
}
