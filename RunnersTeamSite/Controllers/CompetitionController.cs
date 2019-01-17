using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunnersTeamSite.Auth;
using RunnersTeamSite.Models;
using RunnersTeamSite.ViewModels;

namespace RunnersTeamSite.Controllers
{
    public class CompetitionController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CompetitionController(AppDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCompetition()
        {
            return View();
        }

        public IActionResult SaveCompetition(CompetitionViewModel competitionViewModel)
        {
            var competition = new Competition();
            if(!ModelState.IsValid)
            {
                var viewModel = new CompetitionViewModel
                {
                    City = competitionViewModel.City,
                    Date = competitionViewModel.Date,
                    Distance = competitionViewModel.Distance,
                    Name = competitionViewModel.Name
                };


                return View("AddCompetition", viewModel);
            }
            else
            {
                competition = new Competition
                {
                    City = competitionViewModel.City,
                    Date = competitionViewModel.Date,
                    Distance = competitionViewModel.Distance,
                    Name = competitionViewModel.Name
                };
                    
            }
            _context.Competitions.Add(competition);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Details(int id)
        {
            var competition = _context.Competitions.SingleOrDefault(c => c.Id == id);
            if (competition == null)
                return RedirectToAction("Index", "Home");

            return View(competition);
        }

        public IActionResult StartDetails(int id)
        {
            var list = _context.Starts.Where(s => s.CompetitionId == id).Include(s => s.Competition).Include(u => u.User).ToList();
            var users = list.Select(u => u.User).ToList();


            return View(list);
        }
    }
}