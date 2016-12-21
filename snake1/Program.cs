using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(1,3,'*');
            p1.Draw();

            point p2 = new point(4,5,'#');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(3);
            numList.Add(4);
            numList.Add(5);

            numList.RemoveAt(0);
            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            List<point> pointList = new List<point>();
            pointList.Add(p1);
            pointList.Add(p2);

            hLine hl1 = new hLine(2, 22, 10, '+');
            hl1.Draw();
            vLine vl1 = new vLine(2, 22, 10, '+');
            vl1.Draw();

            Console.ReadLine();
        }

    }
}

