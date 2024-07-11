using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battelShip
{
    public class GameBoard
    {
        public string[,] board;
        public GameBoard()
        {
            board = new string[10, 10];

            for (int i = 0; i <10; i++)
            {
                for (int j = 0; j< 10;j++)
                {
                    board[i, j] = "x";
                }
            }
        
        }
    }
}
