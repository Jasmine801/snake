using System.Data;

namespace Snake;

public class HorizontalLines : Figure
{
    public HorizontalLines(int xLeft, int xRight, int y, char sym)
    {
        pList = new List<Point>();
        for (int x = xLeft; x <= xRight; x++)
        {
            Point p1 = new Point(x, y, sym);
            pList.Add(p1);
        }
    }
    
}