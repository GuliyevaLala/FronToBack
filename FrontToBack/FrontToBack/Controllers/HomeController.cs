using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

public class HomeController : Controller {
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        HomeVM home = new()
        {
            Sliders = _context.Sliders.ToList(),
            Features = _context.Features.ToList(),
            Services = _context.Services.ToList(),
            Projects = _context.Projects.ToList(),
            Teams = _context.Teams.ToList(),
            Testimonials = _context.Testimonials.ToList(),



        };
        return View(home);
    }


}

