using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers {
    public class ProjectsController : Controller {
        
        private readonly AppDbContext _context;

        public ProjectsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ProjectVM project = new()
            {
                Projects = _context.Projects.ToList(),
            };
            return View(project);
        }


    }
}