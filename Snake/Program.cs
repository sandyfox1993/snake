using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.SetBufferSize(80,25);

            Walls walls = new Walls(78, 24);
            walls.Draw();

            FoodCreator fc = new FoodCreator(78, 24, '$');
            Point newFood = fc.CreateFood();
            newFood.Draw();

            Point p  = new Point(4, 5, '*');
            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Draw();
            while (true){
                if (walls.isHit(snake)||snake.isHitTail()){
                    break;
                }

                if (snake.eatFood(newFood)){
                    newFood = fc.CreateFood();
                    newFood.Draw();
                }
                else{
                    snake.Move();
                }
				Thread.Sleep(100);

                if (Console.KeyAvailable){
                    snake.HandleKey(Console.ReadKey().Key);
                }
                //snake.Move();
            }

        }
       
    }
}
