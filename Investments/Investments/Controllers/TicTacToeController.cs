using System;
using Investments.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Investments.Controllers
{
    public class TicTacToeController : Controller
    {
        public static Game game = new Game();
        public static bool s = false;
        // GET: /<controller>/
        public IActionResult Index()
        {
            /*
             * Start Up Menu
             */
            return View();
        }

        public IActionResult DisplayGame(Game g)
        {
           if(s == false)
            {
                game.Player1 = g.Player1;
                game.Player2 = g.Player2;
                game.Player1.C = 'x';
                game.Player2.C = 'o';
                game.PlayerTurn = game.Player1;
            }

            s = true;
            return View(game);
        }

        public IActionResult PlayerMove(int row, int col, char c)
        {
            // mark player turn
            game.TicTacToeGame[row, col] = c;

            // next players move
            if(game.PlayerTurn.C.Equals(game.Player1.C))
            {
                game.PlayerTurn = game.Player2;
            } else
            {
                game.PlayerTurn = game.Player1;
            }

            return RedirectToAction("DisplayGame", game);
        }
    }
}
