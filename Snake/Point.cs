class Point
{
    public int x;
    public int y;
    public char sym;

    public void Draw()
    {
        Console.SetCursorPosition(x, y);
        System.Console.WriteLine(sym);
    }
}
 