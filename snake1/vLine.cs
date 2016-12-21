using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class vLine : Line
    {
        
        public vLine(int yТор, int yBottom, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yТор; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }
    }
}
