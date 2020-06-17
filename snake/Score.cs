using System;
using System.Collections.Generic;
using System.Linq;
using Snake_N2;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Score
    {
        public void Scoree(int a, int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Score: " + a);

        }

    }
}
