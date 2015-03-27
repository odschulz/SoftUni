using System;
using System.Threading;

public class AsyncTimer
{
    private Action<string> actionMethod;
    private int ticks;
    private int timeInterval;

    public AsyncTimer(Action<string> actionMethod, int ticks, int timeInterval)
    {
        this.Ticks = ticks;
        this.TimeInterval = timeInterval;
        this.ActionMethod = actionMethod;
    }

    public int Ticks
    {
        get 
        { 
            return this.ticks; 
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Ticks parameter cannot be negative!");
            }

            this.ticks = value;
        }
    }

    public int TimeInterval
    {
        get
        {
            return this.timeInterval;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Time Interval parameter cannot be negative!");
            }

            this.timeInterval = value;
        }
    }

    public Action<string> ActionMethod
    {
        get { return this.actionMethod; }
        set { this.actionMethod = value; }
    }

    public void StartThread()
    {
        Thread thread = new Thread(() =>
        {
            if (this.ActionMethod != null)
            {
                while (this.Ticks > 0)
                {
                    Thread.Sleep(this.TimeInterval);
                    this.ActionMethod((this.Ticks * this.TimeInterval) + " milliseconds left");
                    this.Ticks--;
                }

                Console.WriteLine("KBOOOOOM!");
                Console.WriteLine("A stripper comes out of the cake!");
            }
        });
        thread.Start();
    }
}