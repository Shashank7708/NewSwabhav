using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeUsingObject
{
    class ResultAnalyzer
    {
        int count = 0;
        Board _b;
        Result winnerorloser;

        public ResultAnalyzer(Board b)
        {
            this._b = b;
        }
        public string ReturnWinner()
        {
            this.count++;
            string FirstElemntOfMatrix = _b._tictactoe[0, 0];

            int firstforCount1 = 0;
            int firstforCount2 = 0;
            string ZeroRowThirdelemt = _b._tictactoe[0, 2];

            //checking Diagonally
            for (int i = 0; i < 3; i++)
            {
                if (FirstElemntOfMatrix.Equals("_")) { break; }

                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                        if (_b._tictactoe[i, j].Equals(FirstElemntOfMatrix))
                            firstforCount1++;
                }
            }
            if (firstforCount1 == 3)
            {
                this.winnerorloser = Result.win;
                return FirstElemntOfMatrix;
            }
            //Checking Reverse Diagonal
            for (int i = 0; i < 3; i++)
            {
                if (ZeroRowThirdelemt.Equals("_")) { break; }
                for (int j = 0; j < 3; j++)
                {
                    if (i + j == 2)
                        if (_b._tictactoe[i, j].Equals(ZeroRowThirdelemt))
                            firstforCount2++;
                }
            }
            if (firstforCount2 == 3)
            {
                this.winnerorloser = Result.win;
                return ZeroRowThirdelemt;
            }
            //Checking Row Wise
            for (int i = 0; i < 3; i++)
            {
                string value = _b._tictactoe[i, 0];
                if (value.Equals("_")) { continue; }
                int count = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (_b._tictactoe[i, j].Equals(value))
                        count++;
                }
                if (count == 3)
                {
                    this.winnerorloser = Result.win;
                    return value;
                }
            }

            //Checking Column Wise
            for (int i = 0; i < 3; i++)
            {
                string value = _b._tictactoe[0, i];
                if (value.Equals("_")) { continue; }
                int count = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (_b._tictactoe[j, i].Equals(value))
                        count++;
                }
                if (count == 3)
                {
                    this.winnerorloser = Result.win;
                    return value;
                }
            }
            if (this.count == 9) { 
            this.winnerorloser = Result.draw;
             }   
            return "nowin";

        }

        public Result returnResult()
        {
            return this.winnerorloser;
        }
    }

    enum Result
    {
        win,
        draw

    }
}
