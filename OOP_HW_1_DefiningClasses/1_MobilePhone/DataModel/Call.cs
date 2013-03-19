using System;

public class Call
{
    private DateTime date;
    private string dialedPhoneNumber;
    private uint durationInSeconds;

    public Call(string dialedPhoneNumber, uint durationInSeconds)
    {
        this.date = DateTime.Now;
        this.dialedPhoneNumber = dialedPhoneNumber;
        this.Duration = durationInSeconds;
    }

    public string Time
    {
        get { return this.date.ToLongTimeString(); }
    }

    public string Date
    {
        get { return this.date.ToShortDateString(); }
    }

    public string DialedPhoneNumber
    {
        get { return this.dialedPhoneNumber; }
    }

    public uint Duration
    {
        get { return this.durationInSeconds; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Price must be positive");
            }
            durationInSeconds = value;
        }
    }
}

