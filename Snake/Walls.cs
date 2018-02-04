﻿using System;
using System.Collections.Generic;

namespace Snake
{
    public class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine upLine = new HorizontalLine(0, mapWidth, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth, mapHeight, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight, mapWidth, '+');
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        public bool isHit(Figure figure)
        {
            foreach (var wall in wallList){
                if (wall.isHit(figure)){
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList){
                wall.Draw();
            }
        }
    }
}
