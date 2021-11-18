using System;
namespace Investments.Models
{
    public class Game
    {
        public char[,] TicTacToeGame { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Player PlayerTurn { get; set; }

        public Game()
        {
            TicTacToeGame = new char[3, 3];
            Player1 = new Player();
            Player2 = new Player();
            PlayerTurn = new Player();
        }

        public Game(Player player1, Player player2)
        {
            TicTacToeGame = new char[3, 3];
            Player1 = player1;
            Player2 = player2;
        }

        public bool CheckForVictory()
        {
            if(VerticalWin())
            {
                return true;
            }

            if(HorizontalWin())
            {
                return true;
            }

            if(DiagonalWin())
            {
                return true;
            }

            return false;
        }

        public Player CheckPlayer(char c)
        {
            if(Player1.C == c)
            {
                return Player1;
            }

            return Player2;
        }

        public bool VerticalWin()
        {
            int match = 0;
            for(int col = 0; col < 3; col++)
            {
                char c = TicTacToeGame[0, col];
                Player player = CheckPlayer(c);

                for(int row = 1; row < 3; row++)
                {
                    if(c != TicTacToeGame[row, col])
                    {
                        match = 0;
                        break;
                    } else
                    {
                        match++;
                    }

                    if(match == 2)
                    {
                        player.Wins++;
                        return true;
                    }
                }
            }

            return false;
        }

        public bool HorizontalWin()
        {
            int match = 0;
            for(int row = 0; row < 3; row++)
            {
                char c = TicTacToeGame[row, 0];
                Player player = CheckPlayer(c);

                for (int col = 1; col < 3; col++) {
                    if (c != TicTacToeGame[row, col])
                    {
                        match = 0;
                        break;
                    } else
                    {
                        match++;
                    }

                    if(match == 2)
                    {
                        player.Wins++;
                        return true;
                    }
                }
            }

            return false;
        }

        public bool DiagonalWin()
        {
            int match = 0;
            /*
             * Check Top Left -> 
             *                      ->
             *                             -> To Bottom Right
             */
            int col = 0;
            char c = TicTacToeGame[0, col];
            Player player = CheckPlayer(c);

            for (int row = 1; row < 3; row++)
            {
                if(c != TicTacToeGame[row, col])
                {
                    match = 0;
                    break;
                } else
                {
                    match++;
                }

                if(match == 2)
                {
                    return true;
                }
                col++;
            }

            col = 0;
            /*  
             *                              -> To Top Right
             *                         ->
             * Check Bottom Right ->
             */
            c = TicTacToeGame[2, 0];
            player = CheckPlayer(c);
            for (int row = 1; row >= 0; row--)
            {
                if(c != TicTacToeGame[row, col])
                {
                    match = 0;
                    return false;
                } else
                {
                    match++;
                }
                col++;

                if(match == 2)
                {
                    player.Wins++;
                    return true;
                }
            }

            return false;
        }
    }
}
