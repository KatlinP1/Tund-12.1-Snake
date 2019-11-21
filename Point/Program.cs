using System;
using System.Threading;

namespace Point
{
    //Snakedrafti ilusam versioon 
    //Ussi tärnid on objektid listist point

    class MyPoint
    {
        public int x;
        public int y;
        public char symbol;
        
        public MyPoint(int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }

        public MyPoint(MyPoint _p)
        {
            x = _p.x;
            y = _p.y;
            symbol = _p.symbol;
        }
        
        public void Draw()
        { 
            Console.SetCursorPosition(x,y);
            Console.Write(symbol);
        }

        public void Clear()
        {
            symbol = ' ';
            Draw();
        }

        public void MovePoint(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction ==Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction ==Direction.UP)
            {
                y = y - offset;
            }
            else if (direction==Direction.DOWN)
            {
                y = y + offset;
            }
            
        }

    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            //Ümbrise tegemine
            //Visualstudio jaoks, kui on eraldi aken, kus asju kuvatakse
            //Console.SetWindowSize(80,25);
            //Console.SetBufferSize(80,25);
            
            Horisontalline topLine=new Horisontalline(0,78,0,'*');
            topLine.DrawFigure();
            Horisontalline bottomLine= new Horisontalline(0,78,24,'*');
            bottomLine.DrawFigure();
            Verticalline leftLine= new Verticalline(0,24,0, '*');
            leftLine.DrawFigure();
            Verticalline righLine= new Verticalline(0,24,78, '*');
            righLine.DrawFigure();
            
            //ussi punktid
            MyPoint tail= new MyPoint(6,5,'*');
            Snake snake= new Snake(tail,4,Direction.RIGHT);
            snake.DrawFigure();
            
            
            while (true)
            {
                
                
                ConsoleKeyInfo key = Console.ReadKey();
                snake.ReadUserKey(key.Key);
                
                
                snake.MoveSnake();
                Thread.Sleep(100);
            }
            
            
            /*Horisontalline hrLine= new Horisontalline(20,80,20,'*');
            hrLine.DrawHorizontalLine();
            
            Verticalline vrLine= new Verticalline(20,80,,'*');
            vrLine.DrawVerticalLine();*/
            
            /*for(int i=5; i<10;i++)
            {
                MyPoint newPoint=new MyPoint(i,5,'*');
                newPoint.Draw();
                MyPoint newPoint2=new MyPoint(5,i,'*');
                newPoint2.Draw();
            }*/
            
            
            /*Point p1=new Point(5,1,'*');
            p1.Draw();
            Point p2=new Point(5,2,'*');
            p2.Draw();
            Point p3=new Point(5,3,'*');
            p3.Draw();
            Point p4=new Point(5,4,'*');
            p4.Draw();
            Point p5=new Point(5,5,'*');
            p5.Draw();*/
            
            
            
        }

        public static void Draw(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x,y);
            Console.Write(symbol);
        }
    }
}