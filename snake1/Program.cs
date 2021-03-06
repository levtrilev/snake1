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
            Snake snake = new snake1.Snake(p1, 15, Direction.RIGHT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(79, 23, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);                    
                }
                
                

            }


            Console.ReadLine();
        }

    }
}

