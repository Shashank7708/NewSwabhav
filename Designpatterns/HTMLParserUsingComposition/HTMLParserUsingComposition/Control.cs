using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLParserUsingComposition
{
    class Control:IHTML
    {
        string _tag;
        string _type;
        string _value;
        StringBuilder control = new StringBuilder();
        public Control(string tag)
        {
            this._tag = tag;
        }

        public Control(string tag,string type,string value)
        {
            this._tag = tag;
            this._type = type;
            this._value = value;
            
        }

       public StringBuilder ParseHtml()
        {
            if (_type != null)
            {
                control.Append( "<" + _tag + " type=" + _type + " value=" + _value + ">" );
                control.Append( "</"+_tag+">");
                return control;

            }
            else
            {
                control.Append("<" + _tag + ">");
                control.Append("</" + _tag + ">");
                return control;
            }
        }
        public override string ToString()
        {
            return control.ToString();
        }
    }
}
