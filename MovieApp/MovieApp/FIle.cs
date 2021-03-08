using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    class FIle:IStorable
    {
        string _name;
        double _size;
        string _extension;
        public FIle(String name, double size, string extension)
        {
            this._name = name;
            this._size = size;
            this._extension = extension;
        }

        public string GetName { get { return this._name; } }
        public double GetSize { get { return this._size; } }
        public string GetExtension { get { return this._extension; } }

        public void display(StringBuilder dashes)
        {
            dashes.Append("\t---->" + _name + "." + _extension + " size:" + _size + "\n");

        }

    }
}
