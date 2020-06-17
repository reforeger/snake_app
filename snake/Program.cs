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
            Console.SetWindowSize(80, 27);
            Walls walls = new Walls(80, 25);
            walls.Draw();
            //отсартировка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            p.Draw();
            snake.Draw();
            Console.ReadLine();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            int si = 0;


            while (true)
            {
                if ( walls.IsHit(snake) || snake.IsHitTail() )
                {
                    Gameover gameover = new Gameover();
                    gameover.Game();

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("Enter your name: ");

                    String nimi = (Console.ReadLine());

                    Console.WriteLine(nimi + ": " + si + "Points");

                    string answer = nimi + ": " + si + "Points";



                    break;
                }
                Score score = new Score();
                score.Scoree(si, 0, 25);

                if(snake.Eat(food) )
                {
                    si++;
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}
