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

            return RedirectToAction("Index");
        }

        public IActionResult EditAssignmentView(int id)
        {
            ToDo toDo = new ToDo();
            toDo.ID = id;
            /*
             * find to do in list
             */
            int index = 0;
            foreach(ToDo assignment in ToDoList.ListOfAssignments)
            {
                if(id == assignment.ID)
                {
                    break;
                }
                index++;
            }

            toDo.Assignment= ToDoList.ListOfAssignments[index].Assignment;
            toDo.DateTime = ToDoList.ListOfAssignments[index].DateTime;

            return View(toDo);
        }

        public IActionResult EditAssignment(ToDo toDo)
        {
            /*
             * Find Index of Assignment
             */
            int index = 0;
            foreach(ToDo assignment in ToDoList.ListOfAssignments)
            {
                if(toDo.ID == assignment.ID)
                {
                    break;
                }
                index++;
            }
            ToDoList.ListOfAssignments[index].Assignment = toDo.Assignment;

            return RedirectToAction("Index");
        }

        public IActionResult DeleteAssignment(int id)
        {
            /*
             * Find Assignment to Delete
             */
            int index = 0;
            foreach(ToDo assignment in ToDoList.ListOfAssignments)
            {
                if(id == assignment.ID)
                {
                    break;
                }
                index++;
            }
            ToDo deleteToDo = ToDoList.ListOfAssignments[index];
            ToDoList.ListOfAssignments.Remove(deleteToDo);

            return RedirectToAction("Index");
        }
    }
}
