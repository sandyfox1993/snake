using System;
namespace Snake
{
    public class FoodCreator
    {
        int mapHeight;
        int mapWidth;
        char sym;
        Random rand = new Random();
        public FoodCreator(int mapWidth,int mapHeight,  char sym)
        {
            this.mapHeight = mapHeight;
            this.mapWidth = mapWidth;
            this.sym = sym;
        }

        public Point CreateFood(){
            int x = rand.Next(3, mapWidth - 3);
            int y = rand.Next(3, mapHeight - 3);
            return new Point(x, y, sym);
        }
    }
}
