using System;

public class RandomNumberGenerator : INumberGenerator
{
    private readonly Random _random = new Random();
    private readonly int _maxValue;

    public RandomNumberGenerator(int maxValue)
    {
        _maxValue = maxValue;
    }

    public int Generate()
    {
        return _random.Next(1, _maxValue + 1);
    }
}
