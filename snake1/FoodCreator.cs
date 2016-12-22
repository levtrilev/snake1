using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    internal class FoodCreator
    {
        private int mapWith;
        private int mapHeight;
        private char sym;

        Random random = new Random();
        public FoodCreator(int mapWith, int mapHeight, char sym)
        {
            this.mapWith = mapWith;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWith-2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}