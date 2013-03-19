using System;

public class Battery
{
    private string model;
    private double hoursIdle;
    private double hoursTalk;
    private BatteryType batteryType;

    public Battery(string model, BatteryType batteryType, double hoursIdle, double hoursTalk)
    {
        Model = model;
        BatteryType = batteryType;
        HoursIdle = hoursIdle;
        HoursTalk = hoursTalk;
    }

    public Battery(string model, double hoursIdle, double hoursTalk)
        : this(model, BatteryType.Unknown, hoursIdle, hoursTalk)
    { }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public double HoursIdle
    {
        get { return hoursIdle; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Hours cannot be negative");
            }

            hoursIdle = value; 
        }
    }

    public double HoursTalk
    {
        get { return hoursTalk; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Hours cannot be negative");
            }

            hoursTalk = value; 
        }
    }

    public BatteryType BatteryType
    {
        get { return batteryType; }
        set { batteryType = value; }
    }
}

