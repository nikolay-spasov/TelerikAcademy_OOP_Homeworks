using System;
using System.Threading;
using System.Threading.Tasks;

class TimerDemo
{
    static void Main()
    {
        Timer.Start(() => Console.WriteLine("Tick"), 1.5);
        Timer.Start(() => Console.WriteLine("Tack"), 2);
        Timer.Start(() => CustomMethod(), 3);

        Thread.Sleep(15000);
    }

    static void CustomMethod()
    {
        Console.WriteLine("This is the CustomMethod.");
    }
}

