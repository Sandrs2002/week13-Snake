using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Snake
{
    class FoodGenerator
    {
        int mapWidth;
        int mapHeight;
        char sym;

        Random rnd = new Random();

        public FoodGenerator(int _mapWidth, int _mapHeight, char _sym)
        {
            mapWidth = _mapWidth;
            mapHeight = _mapHeight;
            sym = _sym;
        }

        public Point GenerateFood()
        {
            int x = rnd.Next(2, mapWidth - 2);
            int y = rnd.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
        public Point GenerateFood2()
        {

            int x2 = rnd.Next(2, mapWidth - 2);
            int y2 = rnd.Next(2, mapHeight - 2);
            return new Point(x2, y2, sym);
        }
    }
}