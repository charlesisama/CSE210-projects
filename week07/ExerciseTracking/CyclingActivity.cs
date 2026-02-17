public class CyclingActivity : Activity
{
    private float _speed;

    public CyclingActivity (string date, float length, float speed) : base (date, length)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return GetDistance();
    }
    public override float GetSpeed()
    {
        return _speed;
    }
    public override float GetPace()
    {
        return GetLength() / GetDistance() * 60;
    }
    
    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLength()}) -- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    } 
}