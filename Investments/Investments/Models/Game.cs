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
            Player1.BoarderColor = "orange";
            Player2 = new Player();
            Player2.BoarderColor = "black";
            PlayerTurn = new Player();
        }

        public Game(Player player1, Player player2)
        {
            TicTacToeGame = new char[3, 3];
            Player1 = player1;
            Player1.BoarderColor = "orange";
            Player2 = player2;
            Player2.BoarderColor = "black";
        }

        public bool Tie()
        {
            for(int row = 0; row < 3; row++)
            {
                for(int col = 0; col < 3; col++)
                {
                    if(TicTacToeGame[row, col].Equals('\0'))
                    {
                        /*
                         * Tie
                         * Generate Random Gif
                         */
                        Random r = new Random();
                        int x = r.Next(1, 4);
                        PlayerTurn.CelebrationGifPath = "/Images/TicTacToe/Tie" + x + ".gif";
                        return false;
                    }
                }
            }

            return true;
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

        public void ResetGame()
        {
            TicTacToeGame = new char[3, 3];
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
                    if(c == '\0')
                    {
                        match = 0;
                        break;
                    }

                    if (!c.Equals(TicTacToeGame[row, col]))
                    {
                        match = 0;
                        break;
                    }
                    else
                    {
                        match++;
                    }

                    if (match == 2)
                    {
                        player.Wins++;
                        return true;
                    }
                }
                match = 0;
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

                    if(c == '\0')
                    {
                        match = 0;
                        break;
                    }

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
                match = 0;
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
                col++;
                if (c == '\0')
                {
                    match = 0;
                    break;
                }

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

            col = 0;
            /*  
             *                              -> To Top Right
             *                         ->
             * Check Bottom Right ->
             */
            c = TicTacToeGame[2, col];
            //player = CheckPlayer(c);
            match = 0;
            for (int row = 1; row >= 0; row--)
            {
                col++;
                if (c == '\0')
                {
                    match = 0;
                    break;
                }

                if(c != TicTacToeGame[row, col])
                {
                    match = 0;
                    return false;
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

            return false;
        }
    }
}
