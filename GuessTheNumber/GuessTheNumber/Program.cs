using System;

public class Program
{
    public static void Main()
    {
        ConsoleOutput output = new ConsoleOutput();
        ConsoleUserInput userInput = new ConsoleUserInput();

        bool playAgain = true;

        while (playAgain)
        {
            output.ShowMessage("Выберите уровень сложности:");
            output.ShowMessage("1. Легкий (1-10)");
            output.ShowMessage("2. Средний (1-50)");
            output.ShowMessage("3. Сложный (1-100)");

            int maxValue;

            while (true)
            {
                output.ShowMessage("Введите 1, 2 или 3 для выбора уровня сложности:");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            maxValue = 10;
                            output.ShowMessage("Вы выбрали легкий уровень.");
                            break;
                        case 2:
                            maxValue = 50;
                            output.ShowMessage("Вы выбрали средний уровень.");
                            break;
                        case 3:
                            maxValue = 100;
                            output.ShowMessage("Вы выбрали сложный уровень.");
                            break;
                        default:
                            output.ShowMessage("Некорректный выбор. Пожалуйста, введите 1, 2 или 3.");
                            continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    output.ShowMessage("Некорректный ввод. Пожалуйста, введите 1, 2 или 3.");
                }
            }

            INumberGenerator numberGenerator = new RandomNumberGenerator(maxValue);
            GuessingGame game = new GuessingGame(numberGenerator, userInput, output);
            game.Play();

          
            output.ShowMessage("Хотите сыграть еще раз? (да/нет)");
            string response = Console.ReadLine()?.Trim().ToLower();
            playAgain = response == "да";
        }

        output.ShowMessage("Спасибо за игру! До свидания.");
    }
}
