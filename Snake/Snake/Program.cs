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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine hLine = new HorizontalLine(5, 10, 8, '+');
            hLine.Draw();
            VerticalLine vLine = new VerticalLine(7, 5, 30, '|');
            vLine.Draw();

            Console.ReadLine();
        }

        static void Draw (int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
