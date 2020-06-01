﻿using snake;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake_N2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80,25);

            HorizontalLine upLine = new HorizontalLine(0,78,0,'+');
            HorizontalLine downLine = new HorizontalLine(0,78,24,'+');
            VerticalLine leftLine = new VerticalLine(0,78,0,'+');
            VerticalLine rightLine = new VerticalLine(0,78,78,'+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
            //отсартировка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake( p, 4, Direction.RIGHT );
            p.Draw();
            Console.ReadLine();
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyinfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                        snake.direction = Direction.LEFT;
                    else if (key.Key == ConsoleKey.LeftArrow)
                        snake.direction = Direction.RIGHT;
                    else if (key.Key == ConsoleKey.LeftArrow)
                        snake.direction = Direction.DOWN;
                    else if (key.Key == ConsoleKey.LeftArrow)
                        snake.direction = Direction.UP;
                }
                snake.Move();
                snake.Draw();
                Thread.Sleep(100);

            }

        }
    }
}
