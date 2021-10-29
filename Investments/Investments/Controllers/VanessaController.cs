using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investments.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Investments.Controllers
{
    public class VanessaController : Controller
    {
        public static List<DateIdea> DateIdeas = new List<DateIdea>();
        public static int IDForDateIdeas = 0;
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(DateIdeas);
        }

        public IActionResult AddDateView()
        {
            return View();
        }

        public IActionResult DisplayDateIdeaView(int id)
        {
            DateIdea date = new DateIdea();

            foreach(DateIdea dateIdea in DateIdeas)
            {
                if(id == dateIdea.ID)
                {
                    date = dateIdea;
                    break;
                }
            }

            return View(date);
        }

        public IActionResult AddDateIdea(DateIdea dateIdea)
        {
            dateIdea.ID = IDForDateIdeas;
            IDForDateIdeas++;

            DateIdeas.Add(dateIdea);
            return RedirectToAction("Index");
        }
    }
}
