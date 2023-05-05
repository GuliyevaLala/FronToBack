using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers {
    public class AboutController : Controller {
        public IActionResult Index()
        {
            AboutVM about = new()
            {
                Teams = GetMembers()
            };
            return View(about);
        }

        private List<Team> GetMembers()
        {
            Team t1 = new()
            {
                Id = 1,
                Image = "team-2.jpg",
                Title = "Lala",
                Position = "Business Analyst"
            };

            Team t2 = new()
            {
                Id = 1,
                Image = "team-5.jpg",
                Title = "Orkhan",
                Position = "Business Analyst"
            };

            Team t3 = new()
            {
                Id = 1,
                Image = "team-3.jpg",
                Title = "Madina",
                Position = "Business Analyst"
            };
            Team t4 = new()
            {
                Id = 1,
                Image = "team-4.jpg",
                Title = "Sabina",
                Position = "Business Analyst"
            };
            List<Team> teams = new() { t1, t2, t3, t4 };
            return teams;
        }
    }
}
