using Microsoft.AspNetCore.Mvc;
using MzgulerUdemy.DAL.Context;
using MzgulerUdemy.DAL.Entities;

namespace MzgulerUdemy.Controllers
{
    public class ExperienceController : Controller
    {
          PortfolioContext context = new  PortfolioContext();
          public IActionResult ExperienceList()
        {
            var values= context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]

        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experiences.Find(id);
            context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}

    }
}
