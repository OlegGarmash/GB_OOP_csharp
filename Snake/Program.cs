// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        HorizontalLine upLine = new HorizontalLine(0, 78, 0, '‾');
        HorizontalLine downLine = new HorizontalLine(0, 78, 24, '_');
        VerticalLine leftLine = new VerticalLine(0, 24, 0, '|');
        VerticalLine rightLine = new VerticalLine(0, 24, 78, '|');
        upLine.Draw();
        downLine.Draw();
        leftLine.Draw();
        rightLine.Draw();

        Point p = new Point(4, 5, '*');
        p.Draw();

        Console.ReadLine();
    }
}
