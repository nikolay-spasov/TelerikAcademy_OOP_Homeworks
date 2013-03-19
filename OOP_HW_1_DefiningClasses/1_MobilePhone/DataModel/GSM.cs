using System;
using System.Collections.Generic;
using System.Linq;

public class GSM
{
    public static GSM IPhone4S = new GSM("iPhone4S", "Apple", 1000m, "Some rich guy",
        new Battery("34-12sFF", BatteryType.NiMH, 100, 8),
        new Display(6, 4000000));

    private string model;
    private string manufacturer;
    private decimal? price;
    private string owner;
    private Battery battery;
    private Display display;

    private List<Call> callHistory;

    public GSM(string model, string manufacturer, decimal? price, string owner,
        Battery battery, Display display)
    {
        Model = model;
        Manufacturer = manufacturer;
        Price = price;
        Owner = owner;
        Battery = battery;
        Display = display;
        this.callHistory = new List<Call>();
    }

    public GSM(string model, string manufacturer)
        : this(model, manufacturer, null, null, 
            new Battery(null, BatteryType.Unknown, 0, 0), 
            new Display(0d, 0))
    { }

    public GSM(string model, string manufacturer, Battery battery, Display display)
        : this(model, manufacturer, null, null, battery, display)
    { }

    public GSM(string model, string manufacturer, decimal? price, string owner)
        : this(model, manufacturer, price, owner,
            new Battery(null, BatteryType.Unknown, 0, 0),
            new Display(0, 0))
    { }

    public string Model 
    {
        get { return model; }
        set { model = value; }
    }

    public string Manufacturer 
    {
        get { return manufacturer; }
        set { manufacturer = value; }
    }

    public decimal? Price 
    {
        get { return price; }
        set 
        {
            if (price < 0.0m)
            {
                throw new ArgumentOutOfRangeException(
                    "Price cannot be negative");
            }
            price = value;
        }
    }

    public string Owner 
    {
        get { return owner; }
        set { owner = value; }
    }

    /// <summary>
    /// Gets or sets the battery of the GSM.
    /// </summary>
    public Battery Battery
    {
        get { return battery; }
        set { battery = value; }
    }

    /// <summary>
    /// Gets or sets the display of the GSM.
    /// </summary>
    public Display Display
    {
        get { return display; }
        set { display = value; }
    }

    /// <summary>
    /// Adds a call to the call history.
    /// </summary>
    /// <param name="call">The call to be added to call history.</param>
    public void AddCall(Call call)
    {
        callHistory.Add(call);
    }

    /// <summary>
    /// Removes a call from the call hsitory.
    /// </summary>
    /// <param name="call">The call to remove from call history.</param>
    public void RemoveCall(Call call)
    {
        callHistory.Remove(call);
    }

    /// <summary>
    /// Clears all calls from the call history.
    /// </summary>
    public void ClearCallHistory()
    {
        callHistory.Clear();
    }

    /// <summary>
    /// Calculates the total price of calls.
    /// </summary>
    /// <param name="pricePerMinute">The price per minute.</param>
    /// <returns>Total price of all calls.</returns>
    public decimal CalculateTotalPriceOfCalls(decimal pricePerMinute)
    {
        long totalSeconds = callHistory.Sum(x => x.Duration);

        return totalSeconds / 60m * pricePerMinute;
    }

    /// <summary>
    /// Represents all calls that are currently stored.
    /// </summary>
    public List<Call> Calls
    {
        get { return this.callHistory; }
    }

    public override string ToString()
    {
        return string.Format(
            "GSM:\n\tModel: {0}\n\tManufacturer: {1}\n\t" +
            "Price: {2:c}\n\tOwner: {3}\n\tBattery: \n\t\t" +
            "Model: {4}\n\t\tType: {5}\n\t\tHours Idle: {6}\n\t\tHours Talk: {7}\n\t" +
            "Display: \n\t\tSize in inches: {8}\n\t\tNumber of colors: {9}",
            Model, Manufacturer, Price, Owner, Battery.Model, Battery.BatteryType.ToString(),
            Battery.HoursIdle, Battery.HoursTalk, Display.Size, Display.Colors);
    }
}

