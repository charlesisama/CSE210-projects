using System.Runtime.CompilerServices;
using System.Collections.Generic;


public abstract class Activity
{
    private string _date;
    private float _lengthOfActivity;

    public Activity()
    {
        
    }

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

    public virtual string GetActivityName() => "Activity";

    public string GetSummary()
    {
        return $"{_date} {GetActivityName()} ({_lengthOfActivity} min)- " +
            $"Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }

}