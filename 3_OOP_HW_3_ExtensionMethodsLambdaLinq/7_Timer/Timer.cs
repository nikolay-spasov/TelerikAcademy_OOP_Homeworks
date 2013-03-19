using System;
using System.Threading;
using System.Threading.Tasks;


public static class Timer
{
    public static void Start(Action action, double t)
    {
        Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep((int)(t * 1000));
                    action();
                }
            });
    }
}

