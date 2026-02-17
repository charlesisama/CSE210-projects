public class RunningActivity : Activity
{
    private float _distance;

 

    public RunningActivity(string date, float length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }
    public override float GetPace()
    {
        return GetLength() / GetDistance();
    }

    public override string GetActivityName() => "Running";


   
}