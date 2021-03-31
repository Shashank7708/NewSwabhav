using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleSquare
{
    class Square :ICalculateArea
    {
        int _side;
        public Square(int side) 
        {
            this._side = side;
        }
        int ICalculateArea.calculateArea()
        {
            return this._side * this._side;
        }
      
    }
}
