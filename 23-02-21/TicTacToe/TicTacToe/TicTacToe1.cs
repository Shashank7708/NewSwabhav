using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe1
    {
        static string[,] _tictactoe = new string[3, 3];


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

        public void initializerMatrix()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j=0; j < 3; j++)
                {
                    _tictactoe[i, j] = "_";
                }
            }
        }
        public string[,] showMatrix { get => _tictactoe; }

        public string ReturnWinner()
        {   string FirstElemntOfMatrix = _tictactoe[0, 0];
            
            int firstforCount1 = 0;
            int firstforCount2 = 0;
            string ZeroRowThirdelemt = _tictactoe[0, 2];
            //checking Diagonally
            for(int i = 0; i < 3; i++)
            {
                if (FirstElemntOfMatrix.Equals("_")) { break; }
                
                for (int j = 0; j < 3; j++)
                {   
                    if (i == j)
                        if (_tictactoe[i, j].Equals(FirstElemntOfMatrix))
                            firstforCount1++;
                }
            }
            if (firstforCount1 == 3)
                return FirstElemntOfMatrix;

            //Checking Reverse Diagonal
            for (int i = 0; i < 3; i++)
            {
                if (ZeroRowThirdelemt.Equals("_")) { break; }
                for (int j = 0; j < 3; j++)
                {
                    if (i+j==2)
                        if (_tictactoe[i, j].Equals(ZeroRowThirdelemt))
                            firstforCount2++;
                }
            }
            if (firstforCount2 == 3)
                return ZeroRowThirdelemt;
            //Checking Row Wise
            for(int i = 0; i < 3; i++)
            {
                string value = _tictactoe[i, 0];
                if (value.Equals("_")) { continue; }
                int count = 0;
                for(int j = 0; j < 3; j++)
                {
                     if (_tictactoe[i, j].Equals(value))
                        count++;
                }
                if (count == 3)
                    return value;
            }

            //Checking Column Wise
            for (int i = 0; i < 3; i++)
            {
                string value = _tictactoe[0, i];
                if (value.Equals("_")) { continue; }
                int count = 0;
                for (int j = 0; j < 3; j++)
                {
                     if (_tictactoe[j,i].Equals(value))
                        count++;
                }
                if (count == 3)
                    return value;
            }
            return "nowin";

        }
    }
}
