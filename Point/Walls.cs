using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Point
{
    
    
    
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList=new List<Figure>();
            Horisontalline topLine= new Horisontalline(0,mapWidth -2,0,'#');
            Horisontalline bottomLine=new Horisontalline(0,mapWidth -2,mapHeight -1, '#');
            Verticalline leftLine=new Verticalline(0,mapHeight -1, 0, '#');
            Verticalline rightLine=new Verticalline(0, mapHeight -1, mapWidth -2, '#');
            
            wallList.Add(topLine);
            wallList.Add(bottomLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        public void DrawWalls()
        {
            foreach (Figure wall in wallList)
            {
                wall.DrawFigure();
            }
        }

        public bool IsHitByFigure(Figure figure)
        {
            foreach (Figure wall in wallList)
            {
                if (wall.IsHitByFigure(figure))
                {
                    return true;
                }
            }

            return false;
        }

        
        


    }
}