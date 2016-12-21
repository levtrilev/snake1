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
            Console.SetBufferSize(80, 26);
            
            hLine hТopLine = new hLine(0, 79, 0, '+');
            hТopLine.Draw();
            hLine hBtmLine = new hLine(0, 79, 24, '+');
            hBtmLine.Draw();
            vLine vLeftline = new vLine(0, 23, 0, '+');
            vLeftline.Draw();
            vLine vRightline = new vLine(0, 23, 79, '+');
            vRightline.Draw();

            point p1 = new snake1.point(3, 4, '#');
            p1.Draw();

            Console.ReadLine();
        }

    }
}

