using snake;
using System;
using System.IO;
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

            int s = 0;


            while (true)
            {
                if ( walls.IsHit(snake) || snake.IsHitTail() )
                {
                    Gameover gameover = new Gameover();
                    gameover.Game();

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("Enter your name: ");

                    String nimi = (Console.ReadLine());

                    Console.WriteLine(nimi + ": " + s + "Points");

                    string reco = nimi + ": " + s + "Points";


                    using (StreamWriter to_file = new StreamWriter(@"C:\Users\snake_app6\snake\Resources\record.txt"))
                    {
                        to_file.Write(reco);
                        Console.WriteLine();
                    }

                    //using (StreamWriter to_score = new StreamWriter("results"))
                        
                    

                    break;
                }
                Score score = new Score();
                score.Scoree(s, 0, 25);

                if(snake.Eat(food) )
                {
                    s++;
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
