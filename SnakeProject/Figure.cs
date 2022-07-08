namespace Snake;

public class Figure
{
    protected List<Point> pList;
    
    public void Drow()
    {
        foreach (Point p  in pList)
        {
            p.Draw();
        }
    }
}