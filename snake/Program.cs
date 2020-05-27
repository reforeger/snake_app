using snake;
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
            Console.SetWindowSize(80,25);

            HorizontalLine upLine = new HorizontalLine(0,78,0,'+');
            HorizontalLine downLine = new HorizontalLine(0,78,24,'+');
            VerticalLine leftLine = new VerticalLine(0,78,0,'+');
            VerticalLine rightLine = new VerticalLine(0,78,78,'+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();


            Point p = new Point(4, 5, '*');
            p.Draw();
            Console.ReadLine();

            Emploee e = new Emploee();
            e.age = 42;
            e.pay = 30000;
        }
    }
}
