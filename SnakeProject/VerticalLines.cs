namespace Snake;

public class VerticalLines : Figure
{
    public VerticalLines(int yUp, int yDown, int x, char sym)
    {
        pList = new List<Point>();
        for (int y = yUp; y <= yDown; y++)
        {
            Point p2 = new Point(x, y, sym);
            pList.Add(p2);
        }
    }
}