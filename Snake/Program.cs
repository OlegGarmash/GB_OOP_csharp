﻿// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        
        Point p1 = new Point();
        p1.x = 1;
        p1.y = 3;
        p1.sym = '*';
        p1.Draw();

        Point p2 = new Point();
        p2.x = 4;
        p2.y = 5;
        p2.sym = '#';
        p2.Draw();

        Console.ReadLine();
    }
}
