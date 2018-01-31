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
        public Point(Point p ){
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move (int count, Direction direction){
            if (direction == Direction.RIGHT){
                x += count;
            }
            else if(direction == Direction.LEFT){
                x -= count;
            }
            else if(direction == Direction.UP){
                y -= count;
            }
            else if(direction == Direction.DOWN){
                y += count;
            }
        }

        public void Draw(){
            Console.SetCursorPosition(x,y);
            Console.Write(sym);
        }
    }
}
