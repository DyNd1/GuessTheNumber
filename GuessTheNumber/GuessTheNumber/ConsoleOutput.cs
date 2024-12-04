using System;

public class ConsoleOutput : IOutput
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}
