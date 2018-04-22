using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int width;
        int height;
        char sym;

        Random rnd = new Random();

        public FoodCreator(int width, int height, char sym)
        {
            this.width = width;
            this.height = height;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = rnd.Next(2, width - 2);
            int y = rnd.Next(2, height - 2);
            return new Point(x, y, sym);
        }
    }
}
