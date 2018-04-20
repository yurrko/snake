﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            //Отрисовка рамок
            HorizontalLine upLine   =   new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine =   new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine   =   new VerticalLine(0, 0, 24, '+');
            VerticalLine rightLine  =   new VerticalLine(78, 0, 24, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            //Отрисовка токе

            Point p = new Point(4, 5, '*');
            //p.Draw();

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            Console.ReadLine();
        }
    }
}
