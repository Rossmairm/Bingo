using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingo
{
    class Baord
    {

        private int[,] board;
        int ROWS = 5;
        int COLUMNS = 5;
        Random rand = new Random();

       

        public void FillBoard()
        {
          
              board = new int[ROWS, COLUMNS];

            for (int i = 0; i < 5; i++)
            {
                
               
                board[i,0] = rand.Next(1,16);
                int thing = board[i,0];
                
                
                for(int j = i+1; j < 5; j++)
                {
                    
                        while(board[j,0] == thing)
                            {
                        board[i,0] = rand.Next(1,16);
                        thing = board[i, 0];
                        }
                    
               }
                
                
                board[i,1] = rand.Next(16,31);
                thing = board[i, 1];
                
                for (int j = 1; j < 5; j++)
                {
                    if (board[i, j] == thing)
                    {
                        board[i, 1] = rand.Next(16, 31);
                        thing = board[i, 1];
                    }
                }
                board[i,2] = rand.Next(31,46);
                thing = board[i, 2];

                for (int j = 1; j < 5; j++)
                {
                    if (board[i, j] == thing)
                    {
                        board[i, 2] = rand.Next(31, 46);
                        thing = board[i, 2];
                    }
                }

                board[i,3] = rand.Next(46,61);
                
                thing = board[i, 3];

                for (int j = 1; j < 5; j++)
                {
                    if (board[i, j] == thing)
                    {
                        board[i, 3] = rand.Next(46, 61);
                        thing = board[i, 3];
                    }
                }
                
                board[i,4] = rand.Next(60,76);
                thing = board[i, 4];
                for (int j = 1; j < 5; j++)
                {
                    if (board[i, j] == thing)
                    {
                        board[i, 4] = rand.Next(60, 76);
                        thing = board[i, 4];
                    }
                }



            }
          }
        public int[,] GetBoard()
        {
            return board;

        }

        
        public void SetColumn(int columnNumber, int rowNumber, int firstRandom, int lastRandom)
        {

            Random rand = new Random();


            int i = 0;
            while ( i < 5) 
            {
                int notDuplicate = rand.Next(firstRandom, lastRandom);
                if(notDuplicate == board[i, columnNumber])
                {
                    SetColumn(columnNumber, rowNumber, firstRandom, lastRandom);
                }
                if ( board[i,columnNumber] == 0)
                {
                    board[i,columnNumber]= notDuplicate;
                    return;
                }
                
         
             }
        }
        
        

       // public int[,] GetBoard
    //    {

  //      }
    }
}
