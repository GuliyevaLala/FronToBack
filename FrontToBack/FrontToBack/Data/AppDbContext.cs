﻿using FrontToBack.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Data {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }


    }
}
