using Snake_N2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        Direction direction;
        private int tail;

        public Snake( Point tall, int lenght, Direction _direction)
        {
            direction = _direction;
            plist = new List<Point>();
            for(int i = 0; i < lenght; i++)
            {
                Point p = new Point( tail );
                p.Move( i, direction );
                plist.Add(p);
            }
        }
        internal void Move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);

            tail.Clear();
            head.Draw();

        }
        public Point GetNextPoint() 
    }
}
