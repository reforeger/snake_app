using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_N2
{
    class VerticalLine : Figure
    {

        public VerticalLine(int yUp, int yDown, int y, char sym)
        {
            plist = new List<Point>();
            for (int x = yUp; x <= yDown; x++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }
    }
}
