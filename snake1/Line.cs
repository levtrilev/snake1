﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class Line
    {
        protected List<point> pList;

        public void Draw()
        {
            foreach(point p in pList)
            {
                p.Draw();
            }
        }
    }
}
