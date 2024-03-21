// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Point p1 = new Point(1, 3, '*');
        p1.Draw();

        Point p2 = new Point(4, 5, '#');
        p2.Draw();

        HorizontalLine line = new HorizontalLine(5, 100, 8, '+');
        line.Draw();

        VerticalLine verticalLine = new VerticalLine(5, 0, 15, '+');
        verticalLine.Draw();

        Console.ReadLine();
    }
}
