using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RunnersTeamSite.Models;
using System.Net;
using RunnersTeamSite.ViewModels;

namespace RunnersTeamSite.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Home")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public JsonResult Calendar()
        {
            var dane = _context.Competitions.Select(c => new DaneViewModel
            {
                Id=c.Id,
                Subject = c.Name,
                Start = c.Date
            }).ToList();
            //var dane = new DaneViewModel { Description = "edi", Start = DateTime.Now.Date, Subject="ciul" };
            return Json(dane);
        }
    }
}