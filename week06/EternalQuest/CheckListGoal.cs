public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;

    private int _bonus;

    public CheckListGoal (int amountCompleted, int target, int bonus, string name, string description, string points) : base (name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent ()
    {
        
    }

    public override bool IsComplete ()
    {
        return true;
    }

     public override string GetStringRepresentation()
    {
        return "";
    }

    public override string GetDetailsString()
    {
        return "";
    }
}