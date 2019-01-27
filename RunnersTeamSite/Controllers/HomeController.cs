using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RunnersTeamSite.Auth;
using RunnersTeamSite.Models;
using RunnersTeamSite.ViewModels;

namespace RunnersTeamSite.Controllers
{
    public class HomeController : Controller
    {
      //  private readonly AppDbContext _context;
        private readonly ICompetitionRepository _competitionRepository;
        private readonly INewsRepository _newsRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ICompetitionRepository competitionRepository, INewsRepository newsRepository, UserManager<ApplicationUser> userManager)
        {
            _competitionRepository = competitionRepository;
            _newsRepository = newsRepository;
            _userManager = userManager;
        }

        //     public JsonSerializerSettings JsonRequestBehavior { get; private set; }



        //public HomeController(ICompetitionRepository competitionRepository, UserManager<ApplicationUser> userManager)
        //{
        //    _competitionRepository = competitionRepository;
        //    _userManager = userManager;
        //}

        //public IActionResult Index()
        //{
        //    var competitions = _competitionRepository.GetAllCopetitions().OrderBy(c => c.Name);

        //    var viewModel = new HomeViewModel()
        //    {
        //        Title = _userManager.GetUserId(User),
        //        Competitions = competitions.ToList()
        //    };
        //    return View(viewModel);
        //}

        public IActionResult Index()
        {
            var news = _newsRepository.News.OrderBy(c => c.Date);

            return View(news);
        }

        public IActionResult Calendaar()
        {
            //var events = _context.Competitions.OrderBy(c => c.Id).ToList();
            return View();
        }

        public IActionResult Calendarr()
        {
            //  return Json(_context.Competitions.OrderBy(c => c.Id));
            return View();
        }
    }
}