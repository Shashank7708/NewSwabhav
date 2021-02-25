using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGame1
{
    class Game
    {
        int _turn = 1;
        Die _d = new Die();
        int _score = 0;
        bool _isTurnOver = false;
        bool _isGamever = false;

        public void setScore()
        {
            this._score = 0;
        }
        public int getTurn()
        {
            return this._turn;
        }
        public int score()
        {
            return this._score;
        }
        public int getValue()
        {
            int tem = _d.getValue();
            this._score = this._score + tem;
            return tem;
        }

        public void switchThisTurn(int turn)
        {
            this._turn = turn;

        }
        public bool isgameover
        {
            set { this._isGamever = value; }

            get { return this._isGamever; }
        }
        public bool isTurnOver
        {
            set { this._isTurnOver = value; }
            get { return this._isTurnOver; }
        }
    }

}
