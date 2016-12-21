using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class Snake : Line
    {
        //public List<point> pList<point>;
        public Snake(point tail, int lenght, Direction direction)
        {
            pList = new List<point>();
            for (int i = 0; i<lenght; i++)
            {
                point p = new point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}
