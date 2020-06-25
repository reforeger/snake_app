using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake
{
    class Levels_10
    {

        int s = 0;


        public void AddLevel(int s)
        {
            while (true)
            { 

                if (s == 2)
                {
                    Thread.Sleep(200);
                }
                else if (s == 5)
                {
                    Thread.Sleep(400);
                }
            }
        }

        internal void AddLevel(int v1, int v2)
        {

        }
    }
}
