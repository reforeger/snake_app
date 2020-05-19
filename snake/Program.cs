using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Snake_N2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontallLine upLine = new HorizontallLine(0, 78, "+");
            HorizontallLine downLine = new HorizontallLine(0, 78, "+");
            VerticalLine leftLine = new VerticalLine(0, 78, "+");
            VerticalLine rightLine = new VerticalLine(0, 78, "+");
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4, 5, "*");
            p.Draw();

        }
    }
}
