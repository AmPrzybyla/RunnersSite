using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunnersTeamSite.ViewModels
{
    public class CompetitionViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [Display(Name ="Date of run")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name ="Distance of run")]
        public double Distance { get; set; }

    }
}
