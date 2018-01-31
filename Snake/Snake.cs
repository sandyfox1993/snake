using System;
using System.Collections.Generic;

namespace Snake
{
    public class Snake:Figure
    {
        Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++){
                Point p = new Point(tail);
                p.Move(i,direction);
                pList.Add(p);

            }
        }

        public void Move()
        {
            //Сначала удалим самую первую точку
            Point tail = pList[0];
            pList.Remove(tail);
            Point head = GetNextHead();
            pList.Add(head);

            tail.Delete();
            head.Draw();
        }

        private Point GetNextHead()
        {
            Point head = new Point(pList[pList.Count - 1]);
            head.Move(1,direction);
            return head;
        }
    }
}
