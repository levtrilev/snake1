﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 26);
            
            hLine hТopLine = new hLine(0, 79, 0, '+');
            hТopLine.Draw();
            hLine hBtmLine = new hLine(0, 79, 24, '+');
            hBtmLine.Draw();
            vLine vLeftline = new vLine(0, 23, 0, '+');
            vLeftline.Draw();
            vLine vRightline = new vLine(0, 23, 79, '+');
            vRightline.Draw();

            Point p1 = new snake1.Point(3, 4, '#');
            Snake snake = new snake1.Snake(p1, 5, Direction.RIGHT);
            snake.Draw();

            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if(key.Key == ConsoleKey.LeftArrow) { Snake.direction = Direction.LEFT; }
                    else if (key.Key == ConsoleKey.RightArrow) { Snake.direction = Direction.RIGHT; }
                    else if (key.Key == ConsoleKey.UpArrow) { Snake.direction = Direction.UP; }
                    else if (key.Key == ConsoleKey.DownArrow) { Snake.direction = Direction.DOWN; }
                    Snake.
                }
            }

            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();

            Console.ReadLine();
        }

    }
}

