using System.Collections.Generic;

namespace Point
{
     class Horisontalline : Figure
    {
        //public List<MyPoint> pointList=new List<MyPoint>();

        public Horisontalline(int xLeft, int xRight, int y, char symbol)
        {

            for (int i = xLeft; i < xRight; i++)
            {
                MyPoint newPoint=new MyPoint(i, y, symbol);
                pointList.Add(newPoint);
            }
            
        }

        /*public void DrawHorizontalLine()
        {
            foreach (MyPoint point in pointList)
            {
                point.Draw();
            }
        }*/
        
        
    }
}