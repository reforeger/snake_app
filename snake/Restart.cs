using System;
using System.Collections.Generic;
using Snake_N2;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace snake
{
    class Restart
    {
        public void Nupi()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.R)
                Application.Restart();
        }
    }
}
