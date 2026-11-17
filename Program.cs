using System;

namespace LAB05
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 4);

            Console.WriteLine($"Чтение: X = {p1.X}, Y = {p1.Y}");

            p1.PrintPoint();

            Console.WriteLine($"Расстояние: {p1.DistanceToOrigin()}");

            p1.X = 10;
            p1.Y = 20;

            Console.WriteLine($"После изменения: X = {p1.X}, Y = {p1.Y}");

            p1.MoveTo(-3, -4);
            p1.PrintPoint();
            Console.WriteLine($"Новое расстояние: {p1.DistanceToOrigin()}");

            Point p2 = new Point(0, 0);
            p2.PrintPoint();

            Console.WriteLine($"Расстояние для p2: {p2.DistanceToOrigin()}");

            Console.ReadLine();
        }
    }
}