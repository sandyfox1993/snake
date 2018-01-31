using System;
namespace Snake
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;


        public Point(int _x, int _y, char _sym)
        {
            this.x = _x;
            this.y = _y;
            this.sym = _sym;
        }

        public void Draw(){
            Console.SetCursorPosition(x,y);
            Console.Write(sym);
        }
    }
}
