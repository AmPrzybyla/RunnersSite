using RunnersTeamSite.Auth;
using RunnersTeamSite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunnersTeamSite.ViewModels
{
    public class StartViewModel
    {
        public int Id { get; set; }

        public int CompetitionId { get; set; }

        public virtual Competition Competition { get; set; }

        [Required(ErrorMessage ="You need give the price")]
        public decimal Price { get; set; }

    }
}
