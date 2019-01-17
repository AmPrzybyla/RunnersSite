using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RunnersTeamSite.Auth;
using RunnersTeamSite.Models;
using RunnersTeamSite.ViewModels;

namespace RunnersTeamSite.Controllers
{
    public class StartsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public StartsController(AppDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult SaveStart(StartViewModel startViewModel)
        {
            var userId = _userManager.GetUserId(User);
          if(!ModelState.IsValid)
            {
                return View("AddStart", startViewModel);
            }

          if(_context.Starts.Where(s=>s.CompetitionId==startViewModel.CompetitionId).Any(c=>c.UserId==userId))
            {
                return View("AddStart", startViewModel);
            }
            //if (_context.Starts.Where(c => c.CompetitionId == startViewModel.CompetitionId))
            //    return View();
            var start = new Start()
            {
                UserId = userId,
                CompetitionId = startViewModel.CompetitionId,
                Price = startViewModel.Price
            };

            _context.Starts.Add(start);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AddStart(int competitionId)
        {

            var competition = _context.Competitions.FirstOrDefault(c => c.Id == competitionId);

            if (competition == null)
                return RedirectToAction("Index", "Home");

            var viewModel = new StartViewModel
            {
                Competition = competition
                
            };

            ViewBag.Name = competition.Name;
            return View(viewModel);
        }
    }
}