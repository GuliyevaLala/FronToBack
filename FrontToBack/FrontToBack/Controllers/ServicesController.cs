using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers {
    public class ServicesController : Controller {
        private readonly AppDbContext _context;

        public ServicesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ServiceVM service = new()
            {
                Services = _context.Services.ToList(),

                Testimonials = _context.Testimonials.ToList()
            };
            return View(service);
        }
    }
}
