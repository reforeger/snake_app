using System;
using System.Collections.Generic;
using Snake_N2;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace snake
{
    class Restart
    {

        ConsoleKeyInfo knop = Console.ReadKey();
        {
            if (knop.Key == ConsoleKey.R)
            {
                var Restarti = Assembly.GetExecutingAssembly().Location;
                _ = System.Diagnostics.Process.Start(Restarti);
                Environment.Exit(0);
            }

        }

    }
}
