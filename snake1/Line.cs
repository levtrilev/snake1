using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class Line
    {
        List<point> pList;
        public Line()
        {
            pList = new List<point>();
            point p1 = new snake1.point(4, 4, '*');
            point p2 = new snake1.point(5, 4, '*');
            point p3 = new snake1.point(6, 4, '*');

            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);

        }

        public void Draw()
        {
            foreach(point p in pList)
            {
                p.Draw();
            }
        }
    }
}
