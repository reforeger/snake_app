using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Levels_10
    {
        public int level;

        public Levels_10(int x)
        {
            level = x;
            Console.SetCursorPosition(12, 25);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Level: " + level);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public Levels_10 AddLevel(Levels_10 level)
        {
            this.level++;
            Console.SetCursorPosition(19, 25);
            if (this.level == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (this.level == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (this.level == 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (this.level == 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (this.level == 6)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (this.level == 7)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (this.level == 8)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (this.level == 9)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (this.level == 10)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.Write(this.level);
            Console.ForegroundColor = ConsoleColor.White;
            return level;
        }
    }
}
