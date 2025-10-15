using System;

public class Running : Activity
{
    private double _distance; 

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }


    public override double GetDistance()
    {
        return _distance;
    }
    
    public void SetDistanceValue(double distance)
    {
        _distance = distance;
    }


    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}
