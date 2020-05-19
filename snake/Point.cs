using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake_N2
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int v)
        {
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;

        }
        public void Draw()

        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }

    }
}