using System;
using Investments.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Investments.Controllers
{
    public class TicTacToeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            /*
             * Start Up Menu
             */

            return View();
        }

        public IActionResult DisplayGame()
        {
            return View();
        }
    }
}
