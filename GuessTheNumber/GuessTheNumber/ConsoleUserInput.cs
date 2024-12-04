using System;

public class ConsoleUserInput : IUserInput
{
    public int GetInput()
    {
        Console.Write("Введите ваше предположение: ");
        return int.Parse(Console.ReadLine());
    }
}
