public abstract class Shapes
{
    private string _color;

    public Shapes(string color)
    {
        _color = color;
    }

    public String GetColor()
    {
        return _color;
    }

    public virtual double GetArea()
    {
        return -1;
    }
    
}

