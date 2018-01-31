using System;
using System.Collections.Generic;

namespace Snake
{
    public class VerticalLine
    {
        List<Point> pList;
        public VerticalLine(int yTop, int yBottom, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yBottom; y++){
                pList.Add(new Point(x,y,sym));
            }
        }

        public void Draw(){
            foreach (Point p in pList){
                p.Draw();
            }
        }
    }
}
