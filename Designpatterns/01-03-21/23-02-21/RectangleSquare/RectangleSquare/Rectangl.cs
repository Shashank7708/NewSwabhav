using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleSquare
{
    class Rectangl :ICalculateArea
    {
        public int _height;
        public int _width;

        public Rectangl(int width,int height)
        {
            this._height = height;
            this._width = width;

        }

        public int getwidth { get => this._width; }
        public int getHeight { get => this._height; }

        public virtual void setWidth(int width)
        {
            this._width = width;
        }
        public virtual void setHeight(int height)
        {
            this._height=height;
        }
         int ICalculateArea.calculateArea()
        {
            return this._height * this._width;
        }

    }

}
