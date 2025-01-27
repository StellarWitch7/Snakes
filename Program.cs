﻿namespace Snakes;

internal class Program
{
    static void Main(string[] args)
    {
        var screen = new Screen(30, 15);
        var snake = new Snake(Direction.Right, 4, 5, new Position(0, 0), new Position(29, 14));
        Console.CursorVisible = false;

        while (snake.Move())
        {
            screen.Update(snake);
            screen.Render();
            Thread.Sleep(1000 / snake.Speed);
        }

        Console.CursorVisible = true;
        Console.WriteLine("Game over!");
    }
}