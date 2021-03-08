using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLParserUsingComposition
{
    class ControlGroup:IHTML
    {
        string _tag;
        List<IHTML> controls = new List<IHTML>();
        public StringBuilder controlgroup = new StringBuilder();

        public ControlGroup(string tag)
        {
            this._tag = tag;
        }
        public void AddControl(IHTML element)
        {
            controls.Add(element);
        }

       public StringBuilder ParseHtml()
        {
            controlgroup.Append("<" + _tag + ">\n");
            if (controls != null)
            {
                foreach(IHTML i in controls)
                {
                    controlgroup.Append(i.ParseHtml());
                }
            }
            return controlgroup;
        }

        public override string ToString()
        {
            return controlgroup.ToString();
        }
    }
}
