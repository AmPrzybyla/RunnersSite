using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunnersTeamSite.Auth;
using RunnersTeamSite.Models;

namespace RunnersTeamSite.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserController(AppDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllStarts(string userId)
        {
            var starts = _context.Starts.Where(s => s.UserId == userId).Include(s => s.Competition).ToList();

            return View(starts);
        }
    }
}