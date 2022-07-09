using static System.Console;

namespace Snake;

public class Point
{
    public int x;
    public int y;
    public char sym;

    public Point(int xPosition, int yPosition, char symbol)
    {
        x = xPosition;
        y = yPosition;
        sym = symbol;
    }

    public Point(Point p)
    {
        x = p.x;
        y = p.y;
        sym = p.sym;
    }

    public void Move(int offset, Direction direction)
    {
        if (direction == Direction.RIGHT)
        {
            x = x + offset;
        }
        else if (direction == Direction.LEFT)
        {
            x = x - offset;
        }
        else if (direction == Direction.UP)
        {
            y = y - offset;
        }
        else if (direction == Direction.DOWN)
        {
            y = y + offset;
        }
    }

    public void Clear()
    {
        sym = ' ';
        Draw();
    }
    public void Draw()
    {
        SetCursorPosition(x, y);
        Write(sym);
    }

    public bool IsHit(Point p)
    {
        return p.x == this.x && p.y == this.y;
    }
}