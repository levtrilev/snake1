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
            pList = new List<point>();
            for (int y = yТор; y <= yBottom; y++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }

        }
    }
}
