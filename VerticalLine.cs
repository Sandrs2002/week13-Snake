using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pointList = new List<Point>();
            for (int i = yUp; i <= yDown; i++)
            {
                Point p = new Point(x, i, sym);
                pointList.Add(p);
            }
        }


    }
}
