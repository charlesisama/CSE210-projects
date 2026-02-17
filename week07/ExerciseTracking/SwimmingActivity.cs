public class SwimmingActivity : Activity
{
    private float _numberOfLaps;

    public SwimmingActivity(string date, float length, float numberOfLaps) : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

     public override float GetDistance()
    {
        return (_numberOfLaps * 50f / 1000f) * 0.62f;

    }
    public override float GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }
    public override float GetPace()
    {
        return GetLength() / GetDistance();
    }

    public override string GetActivityName() => "Swimming";

}