using System;

class BaseActivity
{
    public BaseActivity()
    {

    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;

        for(int i = seconds; i>0; i--)
        {
        Console.Clear();
        Console.WriteLine($"{message} - {i}");
        Thread.Sleep(100);
        }

        Console.CursorVisible = true;
    }

    public void RunSpinnerMessage(string messgae, int seconds)
    {
        Console.CursorVisible = false;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        // Clear Console
        Console.Clear();

        while(DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }
}   