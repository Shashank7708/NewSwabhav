using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeUsingObject
{
    class Game
    {
        Player _player1;
        Player _player2;
        
      static  Board _b=new Board();
        ResultAnalyzer resultanalyzer=new ResultAnalyzer(_b);
        Player winner;

        public void initializePlayer(Player p1,Player p2)
        {
            this._player1 = p1;
            this._player2 = p2;
        }

        public void initializeBoard()
        {
            _b.initializerMatrix();
        }

        public bool addtomatrix(int i,int j,string symbol)
        {
            bool addedOrNot = _b.addtomatrix(i, j, symbol);
            return addedOrNot;
            

        }

        public string[,] showMatrix {  get { return _b.matrix(); }  }
        
       

        public bool isgameover()
        {
            if (resultanalyzer.ReturnWinner() == "x") {this.winner=_player1; return true; }
            else if (resultanalyzer.ReturnWinner() == "o") {this.winner=_player2; return true; }
            else { return false; }
        }

        public Result WinOrDraw()
        {
            return resultanalyzer.returnResult();
        }

        public Player GetWinner()
        {
            return this.winner;
        }
    }
}
