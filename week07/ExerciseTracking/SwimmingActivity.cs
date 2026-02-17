public class SwimmingActivity : Activity
{
    private float _numberOfLaps;

    public SwimmingActivity(string date, float length, float numberOfLaps) : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

     public override float GetDistance()
    {
        return _numberOfLaps * 50 / (10 * 62);
    }
    public override float GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }
    public override float GetPace()
    {
        return GetLength() / GetDistance() * 60;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLength()}) -- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}