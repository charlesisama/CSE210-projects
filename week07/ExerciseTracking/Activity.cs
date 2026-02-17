using System.Runtime.CompilerServices;

public abstract class Activity
{
    private string _date;
    private float _lengthOfActivity;

    public Activity(string date, float length)
    {
        _date = date;
        _lengthOfActivity = length;
    }

    public string GetDate()
    {
        return _date;
    }

    public float GetLength()
    {
        return _lengthOfActivity;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();

    public virtual string GetSummary()
    {
        return "";
    }
}