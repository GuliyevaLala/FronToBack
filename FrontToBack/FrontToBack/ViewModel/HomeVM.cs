using System;
using FrontToBack.Models;

namespace FrontToBack.ViewModels
{
	public class HomeVM
	{
        public List<Features> Features { get; set; }
        public List<Project> Projects { get; set; }
        public List<Services> Services { get; set; }
        public List<Team> Teams { get; set; }
        public List<Testimonial> Testimonials { get; set; }
    }
}

