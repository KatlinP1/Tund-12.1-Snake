using System;

namespace Snakedraft
{

    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point(int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x,y);
            Console.Write(symbol);
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {

            //Taustavärvi lisamine
            //Console.BackgroundColor = ConsoleColor.White; 
            //Console.Clear();
            
            
            Point p1=new Point(10,10,'*');
            p1.Draw();
            
            Point p2=new Point(5,5,'*');
            p2.Draw();
            
            
            //Declare point coordinates esialgne variant kui polnud veel class Point loodud
            /*int x1 = 5;
            int y1 = 5;
            char symbol1 = '*';
            Draw(x1,y1, symbol1);*/
            //Draw(p1.x, p1.y, p1.symbol);
            
            //Console.SetCursorPosition(x1, y1);
            //Punkti värvi lisamine- Console.ForegroundColor = ConsoleColor.Blue;
            //Console.Write(symbol1);
            
            /*int x2 = 10;
            int y2 = 10;
            char symbol2 = '*';
            Draw(x2,y2, symbol2);*/
            
            /*Console.SetCursorPosition(x2,y2);
            Console.Write(symbol1);*/
        }

        public static void Draw(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x,y);
            Console.Write(symbol);
        }
    }
}