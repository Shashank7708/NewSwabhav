using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeUsingObject
{
    class Board
    {
      public  string[,] _tictactoe = new string[3, 3];

        public void initializerMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _tictactoe[i, j] = "_";
                }
            }
        }
        public bool addtomatrix(int i, int j, string value)
        {
            if (i < 3 && j < 3)
            {
                if (_tictactoe[i, j].Equals("_"))
                {
                    _tictactoe[i, j] = value;
                    return true;
                }
            }
            return false;

        }
        public string[,] matrix()
        {
            return _tictactoe;
        }

    }
}
