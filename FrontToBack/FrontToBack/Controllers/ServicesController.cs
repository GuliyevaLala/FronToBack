using FrontToBack.Models;
using FrontToBack.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers {
    public class ServicesController : Controller {
        public IActionResult Index()
        {
            ServiceVM service = new()
            {
                Services = GetAllServices(),
                Testimonials = GetTestimonials()
            };
            return View(service);
        }


        private List<Services> GetAllServices()
        {

            Services s1 = new()
            {
                Id = 1,
                Title = "Sabira",
                Icon = "icon-5.png",
                Description = "Description is the pattern of narrative development that aims to make vivid a place, object, character, or group. Description is one of four rhetorical modes, along with exposition, argumentation, and narration. In practice it would be difficult to write literature that drew on just one of the four basic modes."
            };
            Services s2 = new()
            {
                Id = 2,
                Title = "Rasul",
                Icon = "icon-10.png",
                Description = "Description is the pattern of narrative development that aims to make vivid a place, object, character, or group. Description is one of four rhetorical modes, along with exposition, argumentation, and narration. In practice it would be difficult to write literature that drew on just one of the four basic modes."
            };
            Services s3 = new()
            {
                Id = 3,
                Title = "Qara",
                Icon = "icon-8.png",
                Description = "Description is the pattern of narrative development that aims to make vivid a place, object, character, or group. Description is one of four rhetorical modes, along with exposition, argumentation, and narration. In practice it would be difficult to write literature that drew on just one of the four basic modes."
            };
            Services s4 = new()
            {
                Id = 4,
                Title = "Elsad",
                Icon = "icon-9.png",
                Description = "Description is the pattern of narrative development that aims to make vivid a place, object, character, or group. Description is one of four rhetorical modes, along with exposition, argumentation, and narration. In practice it would be difficult to write literature that drew on just one of the four basic modes."
            };
            Services s5 = new()
            {
                Id = 5,
                Title = "Mehriban",
                Icon = "icon-4.png",
                Description = "Description is the pattern of narrative development that aims to make vivid a place, object, character, or group. Description is one of four rhetorical modes, along with exposition, argumentation, and narration. In practice it would be difficult to write literature that drew on just one of the four basic modes."
            };
            Services s6 = new()
            {
                Id = 6,
                Title = "Lala",
                Icon = "icon-1.png",
                Description = "Description is the pattern of narrative development that aims to make vivid a place, object, character, or group. Description is one of four rhetorical modes, along with exposition, argumentation, and narration. In practice it would be difficult to write literature that drew on just one of the four basic modes."
            };
            List<Services> services = new() { s1, s2, s3, s4, s5, s6 };
            return services;
        }
        private List<Testimonial> GetTestimonials()
        {
            Testimonial t1 = new()
            {
                Id = 1,
                Icon = "testimonial-4.jpg",
                About = "Production workers produce and assemble products in factories. They operate and maintain machinery, ensure production standards are met, finalize products, and prepare them for shipping.",
                Name = "Sevil",
                Position = "Position"
            };
            Testimonial t2 = new()
            {
                Id = 2,
                Icon = "testimonial-3.jpg",
                About = "Production workers produce and assemble products in factories. They operate and maintain machinery, ensure production standards are met, finalize products, and prepare them for shipping.",
                Name = "John",
                Position = "Position"
            };
            Testimonial t3 = new()
            {
                Id = 3,
                Icon = "testimonial-1.jpg",
                About = "Production workers produce and assemble products in factories. They operate and maintain machinery, ensure production standards are met, finalize products, and prepare them for shipping.",
                Name = "Sabrina",
                Position = "Position"
            };
            Testimonial t4 = new()
            {
                Id = 4,
                Icon = "testimonial-2.jpg",
                About = "Production workers produce and assemble products in factories. They operate and maintain machinery, ensure production standards are met, finalize products, and prepare them for shipping.",
                Name = "Marc",
                Position = "Position"
            };

            List<Testimonial> testimonials = new() { t1, t2, t3, t4 };
            return testimonials;
        }


    }
}
