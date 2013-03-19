using System;
using System.Collections.Generic;
using System.Linq;

public class GSMCallHistoryTest
{
    private const decimal PRICE_PER_MINUTE = 0.37m;

    private static GSM gsm = new GSM("k700i", "Sony-Ericsson");

    public static void Test()
    {
        Console.WriteLine("Testing Calls");
        Console.WriteLine("============================");
        Console.WriteLine(gsm.ToString());
        AddSomeCalls();
        PrintCalls();
        PrintTotalPrice();
        RemoveCallWithMaxDuration();
        Console.WriteLine("After removing the call with maximal duration:");
        PrintTotalPrice();
        Console.WriteLine("Clearing the call history.");
        ClearCallsHistory();
        Console.WriteLine("After clearing total calls in history: {0}", gsm.Calls.Count);
        PrintCalls();
    }

    private static void AddSomeCalls()
    {
        gsm.AddCall(new Call("025 6584 555 1", 300));
        gsm.AddCall(new Call("025 456 555 1", 330));
        gsm.AddCall(new Call("025 614568 85 1", 600));
        gsm.AddCall(new Call("025 4562 555 1", 60));
        gsm.AddCall(new Call("025 123 555 1", 148));
        gsm.AddCall(new Call("025 4568 535 1", 15));
        gsm.AddCall(new Call("025 6114 135 1", 67));
        gsm.AddCall(new Call("025 4 555 1", 123));
        gsm.AddCall(new Call("025 58 15 1", 432));
    }

    private static void PrintCalls()
    {
        foreach (Call call in gsm.Calls)
        {
            Console.WriteLine("Date: {0}, Time: {1}, Phone number: {2}, Duration: {3}",
                call.Date, call.Time, call.DialedPhoneNumber, call.Duration);
        }
    }

    private static void PrintTotalPrice()
    {
        decimal totalPrice = gsm.CalculateTotalPriceOfCalls(PRICE_PER_MINUTE);
        Console.WriteLine("Total price: {0:c}", totalPrice);
    }

    private static void RemoveCallWithMaxDuration()
    {
        uint maxDuration = gsm.Calls.Max(x => x.Duration);
        Call maxDurationCall = gsm.Calls.Find(x => x.Duration == maxDuration);
        gsm.RemoveCall(maxDurationCall);
    }

    private static void ClearCallsHistory()
    {
        gsm.ClearCallHistory();
    }
}

