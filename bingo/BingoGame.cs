using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingo
{
    class BingoGame
    {
        private int wins;

        private int losses;
        private int numberOfGames;
        private int[] calledNumbers = new int[80];
       
        public int AnounceNumber()
        {
            Random rand = new Random();

            int anouncedNumber = rand.Next(1, 76);

            for (int i = 0; i < calledNumbers.Length; i++)
            {

                while (anouncedNumber == calledNumbers[i])
                {
                    //search array for duplicate and if none exists return anounceNumber

                }



            }
        }


        private int[] CheckBoard(int[,] board , int number)
         {
            int[] check = new int[76];

             for (int i = 0; i < 5; i++)
             {
                 for (int j = 0; j < 5; j++)
                 {
                     if (board[i, j] == number)
                     {
                         check[0] = i;
                         check[1] = j;

                         return check;

                     }

                 }
             }
        
            return check;
        }

        public void MarkBoard(int number)
        {
            int[,] board;
            int ROWS = 5;
            int COLUMNS = 5;
            
            board = new int[ROWS, COLUMNS];
            Baord boards = new Baord();
            int[] check = new int[2];
            
            board = boards.GetBoard(); 
            check = CheckBoard(board, number);
            board[check[0], check[1]] = 0;

        

        }
        public bool CheckBingo(int[,] board)
        {
            int ROWS = 5;
            int COLUMNS = 5;

            for (int row = 0; row < ROWS; row++)
            {
                if (board[row, 0] == 0 && board[row, 1] == 0 && board[row, 2] == 0 && board[row, 3] == 0 && board[row, 4] == 0)
                {
                   
                    return true;
                }
                
            
            }
            for (int cols = 0; cols < COLUMNS; cols++)
            {
                if (board[0, cols] == 0 && board[1, cols] == 0 && board[2, cols] == 0 && board[3, cols] == 0 && board[4, cols] == 0)
                {
                    
                    return true;
                }
            }
            if ((board[0, 0] == 0 && board[1, 1] == 0 && board[2, 2] == 0 && board[3, 3] == 0 && board[4, 4] == 0) ||
                   (board[0, 4] == 0 && board[1, 3] == 0 && board[2, 2] == 0 && board[3, 1] == 0 && board[4, 0] == 0))
            {

                return true;
            }
            else
                return false;

        
          
        }
    }
}

