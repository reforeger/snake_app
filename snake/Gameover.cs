using System;
using Snake_N2;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class GameOver
    {

        public void GameOvers(string nimi, int score)
        {

            Console.Clear();
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("G A M E  O V E R", xOffset + 1, yOffset++);
            WriteText("Для перезапуска игры, нажмите R", xOffset, yOffset++);
            Console.ForegroundColor = ConsoleColor.White;
            WriteText("Ваш счёт: " + score, xOffset + 2, yOffset++);
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

        internal void Game()
        {
        }
    }
}
