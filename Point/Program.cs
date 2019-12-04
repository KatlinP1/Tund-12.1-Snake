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

        public bool IsHit(MyPoint point)
        {
            return point.x == x && point.y == y;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Seinte/äärte tegemine
            //Windows arvuti jaoks, kui on eraldi aken, kus asju kuvatakse, macis need kordinaadid ei tööta:
            //Console.SetWindowSize(80,25); ja Console.SetBufferSize(80,25);
            
            Walls walls = new Walls(80,25);
            walls.DrawWalls();
            
            //ussi punktid
            
            MyPoint tail= new MyPoint(6,5,'*');
            Snake snake= new Snake(tail,4,Direction.RIGHT);
            snake.DrawFigure();
            
            FoodCatering foodCatered =new FoodCatering(80, 24, '$');
            MyPoint food = foodCatered.CaterFood();
            food.Draw();
            
            
            
            
            while (true)
            {

                if (walls.IsHitByFigure(snake))
                {
                    break;
                }
                
                if (snake.Eat(food))
                {
                    food = foodCatered.CaterFood();
                    food.Draw();
                    
                }
                else
                {
                    snake.MoveSnake();
                }
                Thread.Sleep(200);
                
                if (Console.KeyAvailable==true)
                {
                    var key = Console.ReadKey(true);
                    snake.ReadUserKey(key.Key); 
                }
                
            }
            
            WriteGameOver();
        }
        
        public static void WriteGameOver()
        {
            Console.Clear();
            int xOffset = 35;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset,yOffset++);
            ShowMessage("__________", xOffset,yOffset++);
            ShowMessage("GAME OVER", xOffset, yOffset++);
            ShowMessage("__________", xOffset,yOffset++);
                
        }

        public static void ShowMessage(string text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
        
    }
}