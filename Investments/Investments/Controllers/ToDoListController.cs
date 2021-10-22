using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investments.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Investments.Controllers
{
    public class ToDoListController : Controller
    {
        public static ToDoList ToDoList = new ToDoList();
        // GET: /<controller>/
        public IActionResult Index()
        {
            Console.WriteLine($"Assignment Count: {ToDoList.ListOfAssignments.Count}");
            return View(ToDoList);
        }

        /*
         * Add Item to ToDoList
         */
        public IActionResult AddItemView()
        {
            return View();
        }

        public IActionResult AddItem(ToDo toDo)
        {
            ToDoList.AddAssignment(toDo);
            Console.WriteLine($"Number of Assignments: {ToDoList.ListOfAssignments.Count}");

            return RedirectToAction("Index");
        }
    }
}
