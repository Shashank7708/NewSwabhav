using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircleANDReturnObj
{
    class Program
    { static int count = 1;
        static float maxRadius = 0.0f;
        static float maxarea = 0.0f;

        static AreaOfCircle returnRefToAObj;
        static void Main(string[] args)
        {   //Creating Array of OBjects
            AreaOfCircle[] circle = new AreaOfCircle[2];
            for(int i = 0; i < 2; i++){
                circle[i] = new AreaOfCircle() ;
            }
           //Setting Value
            circle[0].SetandGetRadius = 4.5f;                   
            circle[0].SetandGetColor = "Red";
            circle[1].SetandGetColor = "Violet";
            circle[1].SetandGetRadius = 6.0f;

            //Printing HashCode Of Objected Created
            Console.WriteLine("1st Circle HashCode: "+circle[0].GetHashCode());      
            Console.WriteLine("2st Circle HashCode: " + circle[1].GetHashCode());
            CircleDetailSeperator();


            PrintCircleInfo(circle);                                      //Printing 1st circle value
            Console.WriteLine("Max Radius: "+ PrintMaxCircleradius(circle)); //Printing Max Radius 
            CircleDetailSeperator();

            //Printing HashCode of obj with Max Area of Circle 
            Console.WriteLine("Hash Code of Max Area: {0}", PrintMaxAreaObj(circle).GetHashCode());
            Console.ReadLine();

        }

        static void CircleDetailSeperator()                              //Information Seperator
        {
            Console.WriteLine("##################################################");
        }
        static void PrintCircleInfo(AreaOfCircle[] circleARRAY)                 //Printing Details
        {   foreach (AreaOfCircle circle in circleARRAY)
            {
                Console.WriteLine("Circle{0} :\nRadius: {1}\tColor: {2}", count++, circle.SetandGetRadius, circle.SetandGetColor);
                CircleDetailSeperator();
            }
        }

        static float PrintMaxCircleradius(AreaOfCircle[] RefObjArray)    //Returning Max Radius     
        {   foreach (AreaOfCircle i in RefObjArray)
                if (maxRadius < i.SetandGetRadius)
                    maxRadius = i.SetandGetRadius;
            return maxRadius; 

        }

        static AreaOfCircle PrintMaxAreaObj (AreaOfCircle[] RefObjArray)   //Returning  HashCode of obj with Max Area of Circle 
        {
            
            foreach(AreaOfCircle i in RefObjArray)
            {
                if (maxarea < i.getArea)
                {
                    maxarea = i.getArea;
                    returnRefToAObj = i;
                }
            }
            return returnRefToAObj;
        }
    }
}
