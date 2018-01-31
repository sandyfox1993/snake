using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HorizontalLine hl = new HorizontalLine(3, 20, 4, '+');
            hl.Draw();
            VerticalLine vl = new VerticalLine(4, 15, 3, '-');
            vl.Draw();

            Console.ReadLine();
        }
       
    }
}
