using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investments.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Investments.Controllers
{
    public class VanessaController : Controller
    {
        public IWebHostEnvironment webHostEnvironment { get; set; }

        public static List<DateIdea> DateIdeas = new List<DateIdea>();
        public static int IDForDateIdeas = 0;

        public VanessaController(IWebHostEnvironment e)
        {
            webHostEnvironment = e;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            // GET the Date Ideas From DataBase
            QueryDB queryDB = new QueryDB();
            DateIdeas = queryDB.GetDateIdeas();

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

        public IActionResult DeleteDateIdeaConfirmation(int id)
        {
            QueryDB queryDB = new QueryDB();
            DateIdea dateIdea = queryDB.GetDateIdea(id);
            return View(dateIdea);
        }

        public IActionResult DeleteDateIdeaFromDB(int id)
        {
            QueryDB queryDB = new QueryDB();
            DateIdea dateIdea = queryDB.GetDateIdea(id);
            queryDB.DeleteDateIdea(dateIdea);

            return RedirectToAction("Index");
        }

        public IActionResult AddDateIdea(DateIdea dateIdea)
        {
            dateIdea.ID = IDForDateIdeas;
            IDForDateIdeas++;

            /*
             *  put image in folder
             */
            FolderAndDirectories folderAndDirectories = new FolderAndDirectories(webHostEnvironment);
            dateIdea.ImagePath = folderAndDirectories.PutImageTo(dateIdea.ImageFile, "Images");

            DateIdeas.Add(dateIdea);

            // add to DataBase
            QueryDB queryDB = new QueryDB();
            queryDB.AddDateIdeaToDB(dateIdea);

            return RedirectToAction("Index");
        }

        public IActionResult EditDateIdeaView(int id)
        {
            QueryDB queryDB = new QueryDB();
            DateIdea dateIdea = queryDB.GetDateIdea(id);

            return View(dateIdea);
        }

        public IActionResult UpdateDateIdea(DateIdea dateIdea)
        {
            QueryDB queryDB = new QueryDB();
            queryDB.UpdateDateIdea(dateIdea);

            return RedirectToAction("Index");
        }
    }

}
