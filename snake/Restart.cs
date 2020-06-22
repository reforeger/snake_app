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
        public void Nupi()
        {
            ConsoleKeyInfo nuup = Console.ReadKey();
            if (nuup.Key == ConsoleKey.R)
            {
                var fileName = Assembly.GetExecutingAssembly().Location;
                System.Diagnostics.Process.Start(fileName);
                Environment.Exit(0);
            }
        }
    }
}
