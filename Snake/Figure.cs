using System;
using System.Collections.Generic;

namespace Snake
{
    public class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        public bool isHit(Figure f){
            foreach (Point p in pList){
                if (f.isHit(p)){
                    return true;
                }   
            };
            return false;
        }
        public bool isHit(Point pF){
            foreach (Point p in pList){
                if (p.isHit(pF)){
                    return true;
                }
            };
            return false;
        }
    }
}
