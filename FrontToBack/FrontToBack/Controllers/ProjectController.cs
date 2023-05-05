using FrontToBack.Models;
using FrontToBack.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers {
    public class ProjectsController : Controller {
        public IActionResult Index()
        {
            ProjectVM project = new()
            {
                Projects = GetAllAboutProjects()
            };
            return View(project);
        }

        private List<Project> GetAllAboutProjects()
        {
            Project p1 = new()
            {
                Id = 1,
                Title = "Reshad",
                Image = "project-1.jpg",
                Description = "Description is the pattern of narrative development that aims to make vivid a place, object, character, or group. Description is one of four rhetorical modes, along with exposition, argumentation, and narration. In practice it would be difficult to write literature that drew on just one of the four basic modes."
            };
            Project p2 = new()
            {
                Id = 2,
                Title = "Elcin",
                Image = "project-3.jpg",
                Description = "Description is the pattern of narrative development that aims to make vivid a place, object, character, or group. Description is one of four rhetorical modes, along with exposition, argumentation, and narration. In practice it would be difficult to write literature that drew on just one of the four basic modes."
            };
            Project p3 = new()
            {
                Id = 3,
                Title = "Abulfaz",
                Image = "project-4.jpg",
                Description = "Description is the pattern of narrative development that aims to make vivid a place, object, character, or group. Description is one of four rhetorical modes, along with exposition, argumentation, and narration. In practice it would be difficult to write literature that drew on just one of the four basic modes."
            };
            Project p4 = new()
            {
                Id = 4,
                Title = "Novruz",
                Image = "project-2.jpg",
                Description = "Description is the pattern of narrative development that aims to make vivid a place, object, character, or group. Description is one of four rhetorical modes, along with exposition, argumentation, and narration. In practice it would be difficult to write literature that drew on just one of the four basic modes."
            };
            List<Project> projects = new() { p1, p2, p3, p4 };
            return projects;
        }

    }
}