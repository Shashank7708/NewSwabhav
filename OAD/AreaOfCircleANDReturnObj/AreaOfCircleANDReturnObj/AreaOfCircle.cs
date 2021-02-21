using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircleANDReturnObj
{
    class AreaOfCircle
    {
        private string color;
        private float radius;
        const float PI = 3.14f;

        public float SetandGetRadius                        //Set and Get for Radius
        {
            set { this.radius = value; }
            get { return this.radius; }
        }

        public string SetandGetColor                      //Set and Get Coloe
        {
            set
            {
                if (value == "Red" || value == "red" || value == "Blue" || value == "blue" || value == "Green" || value == "green")
                    this.color = value;
                else
                    this.color = "Black";
            }
            get { return this.color; }

        }
        public float getArea                            //Get area of Circle
        {
            get { return (PI * this.radius * this.radius); }
        }
    }
}
