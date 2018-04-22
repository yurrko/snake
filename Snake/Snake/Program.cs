﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            //Отрисовка точки

            Point p = new Point(4, 5, '*');

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.Handle(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
