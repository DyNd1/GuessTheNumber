public class GuessingGame
{
    private readonly INumberGenerator _numberGenerator;
    private readonly IUserInput _userInput;
    private readonly IOutput _output;

    public GuessingGame(INumberGenerator numberGenerator, IUserInput userInput, IOutput output)
    {
        _numberGenerator = numberGenerator;
        _userInput = userInput;
        _output = output;
    }

    public void Play()
    {
        int targetNumber = _numberGenerator.Generate();
        _output.ShowMessage("Игра началась! Попробуйте угадать число.");

        while (true)
        {
            try
            {
                int guess = _userInput.GetInput();

                if (guess == targetNumber)
                {
                    _output.ShowMessage("Поздравляем! Вы угадали число!");
                    break;
                }
                else if (guess < targetNumber)
                {
                    _output.ShowMessage("Загаданное число больше.");
                }
                else
                {
                    _output.ShowMessage("Загаданное число меньше.");
                }
            }
            catch (FormatException)
            {
                _output.ShowMessage("Пожалуйста, введите корректное число.");
            }
        }
    }
}
