using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunnersTeamSite.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Nick Name")]
        public string NickName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }

    }
}
