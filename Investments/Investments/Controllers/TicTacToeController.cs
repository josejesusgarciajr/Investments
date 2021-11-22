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
                game.PlayerTurn.BoarderColor = game.Player1.BoarderColor;
            }

            /*
             * if players name not entered, 
             * redirect to main menu
             */
            if (game.Player1.Name == null || game.Player2.Name == null)
            {
                return RedirectToAction("Index");
            }

            s = true;
            return View(game);
        }

        public IActionResult PlayerMove(int row, int col, char c)
        {
            /*
             * if players name not entered, 
             * redirect to main menu
             */
            if (game.Player1.Name == null || game.Player2.Name == null)
            {
                return RedirectToAction("Index");
            }

            // mark player turn
            game.TicTacToeGame[row, col] = c;

            // check to see if player won
            bool victory = game.CheckForVictory();

            if(victory)
            {
                return RedirectToAction("Victory");
            }

            // next players move
            if(game.PlayerTurn.C.Equals(game.Player1.C))
            {
                game.PlayerTurn = game.Player2;
                game.PlayerTurn.BoarderColor = game.Player2.BoarderColor;
            } else
            {
                game.PlayerTurn = game.Player1;
                game.PlayerTurn.BoarderColor = game.Player1.BoarderColor;
            }

            if(game.Tie())
            {
                return RedirectToAction("Tie");
            }

            return RedirectToAction("DisplayGame", game);
        }

        public IActionResult Tie()
        {
            /*
             * if players name not entered, 
             * redirect to main menu
             */
            if (game.Player1.Name == null || game.Player2.Name == null)
            {
                return RedirectToAction("Index");
            }

            game.ResetGame();
            return View(game);
        }

        public IActionResult Victory()
        {
            /*
             * if players name not entered, 
             * redirect to main menu
             */
            if (game.Player1.Name == null || game.Player2.Name == null)
            {
                return RedirectToAction("Index");
            }

            if(game.PlayerTurn.Name == game.Player1.Name)
            {
                game.PlayerTurn.CelebrationGifPath = "/Images/TicTacToe/Vanessa.gif";
            } else
            {
                game.PlayerTurn.CelebrationGifPath = "/Images/TicTacToe/Jose.gif";
            }

            game.ResetGame();
            return View(game);
        }
    }
}
