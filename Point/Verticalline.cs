using System.Collections.Generic;

namespace Point
{
    class Verticalline:Figure
    {
        //public List<MyPoint> pointList= new List<MyPoint>();

        public Verticalline(int yTop, int yBottom, int x, char symbol)
        {
            
            
            for (int i = yTop; i<= yBottom; i++)
            {
                MyPoint newPoint= new MyPoint(x,i, symbol);
                pointList.Add(newPoint);
            }
        }

        /*public void DrawVerticalLine()
        {
            foreach (MyPoint point in pointList)
            {
                point.Draw();
            }
        }*/
        
    }
}