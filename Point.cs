namespace Point;

public class Point
{
    private double _x;
    private double _y;
    //constructor
    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }
    //Getters
    public double Get_X()
    {
        return _x;
    }
    public double Get_Y()
    {
        return _y;
    }
    //Setters
    public void Set_X(int x)
    {
        _x = x;
    }
    public void Set_Y(int y)
    {
        _y = y;
    }
    //Distance
    //^2
    public double square (double a)
    {
        return a * a;
    }
    public double Distance(double x1, double x2, double y1, double y2)
    {
        return Math.Sqrt(square(x2 - x1) + (y2 - y1));
    }
    //Egalite
    public bool Eqalite(double x1, double x2, double y1, double y2)
    {
        if (x1 == x2 && y1 == y2)
            return true;
        else
        {
            return false;
        }
    }
    //Translation
    public void translation(double t)
    {
        _x += t;
        _y += t;

    }
    //Linearite
    public bool Linearite(double x1, double x2, double x3, double y1, double y2, double y3)
    {
        bool res = true;
        
        if (x2-x1 != 0 && x3-x1 !=0 )
        {
            if ((y2-y1)/(x2-x1) == (y3-y1)/(x3-x1))
            {
                res = true;
            }
            else
            {
                res = false;
            }
        }else
        {
            return "error";
        }
        return res;
    }
}
