using System.Collections;
using System.Globalization;
List<string> games = new List<string>();
bool gameEnd = false;
string? result;
int numQuestions = 0;
while (!gameEnd)
{
    ShowMenu();
}

void ShowMenu()
{
    Console.Clear();
    Console.WriteLine("MATH GAME");
    Console.WriteLine("----------");
    Console.WriteLine("1. Play");
    Console.WriteLine("2. History");
    Console.WriteLine("3. Exit");
    Console.Write("Choose an option: ");
    result = Console.ReadLine();

    switch (result)
    {
        case "1":
            ChooseGame();
            break;
        case "2":
            ShowHistory();
            break;
        case "3":
            Console.WriteLine("BYE");
            gameEnd = true;
            break;
        default:
            ShowMenu();
            break;

    }
}

void ChooseGame()
{
    Console.Clear();
    Console.WriteLine("MATH GAME");
    Console.WriteLine("----------");
    Console.WriteLine("Choose a game: ");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Divison");
    result = Console.ReadLine();

    switch (result)
    {
        case "1":
            try
            {
                AdditionGame();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Press enter to go back to main menu");
                Console.ReadLine();
            }
            break;
        case "2":
            try
            {
                SubtractionGame();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Press enter to go back to main menu");
                Console.ReadLine();
            }
            break;
        case "3":
            try
            {
                MultiplicationGame();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Press enter to go back to main menu");
                Console.ReadLine();
            }
            break;
        case "4":
            try
            {
                DivisionGame();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Press enter to go back to main menu");
                Console.ReadLine();
            }
            break;
        default:
            Console.WriteLine("Thats not a valid option, please type only the number of the option.");
            ChooseGame();
            break;
    }
}

void AdditionGame()
{
    numQuestions = QuestionsCount();
    var random = new Random();
    int number1;
    int number2;
    int points = 0;

    for (int i = 0; i < numQuestions; i++)
    {
        Console.Clear();
        number1 = random.Next(1, 10);
        number2 = random.Next(1, 10);

        Console.WriteLine($"Addition Game: {points} points");
        Console.WriteLine($"{number1} + {number2} = ");
        result = Console.ReadLine();

        if (Convert.ToInt32(result) == (number1 + number2))
        {
            Console.WriteLine("Correct! + 1 point");
            Console.ReadLine();
            points++;
        }
        else
        {
            Console.WriteLine("Incorrect.");
            Console.ReadLine();
        }
    }

    Console.WriteLine($"The End. You scored {points} points. Press enter to go back to main menu.");
    Console.ReadLine();
    AddToHistory("Addition", points);
    ShowMenu();
}

void SubtractionGame()
{
    numQuestions = QuestionsCount();
    var random = new Random();
    int number1;
    int number2;
    int points = 0;

    for (int i = 0; i < numQuestions; i++)
    {
        Console.Clear();
        number1 = random.Next(1, 10);
        number2 = random.Next(1, 10);

        Console.WriteLine($"Subtraction Game: {points} points");
        Console.WriteLine($"{number1} - {number2} = ");
        result = Console.ReadLine();

        if (Convert.ToInt32(result) == (number1 - number2))
        {
            Console.WriteLine("Correct! + 1 point");
            Console.ReadLine();
            points++;
        }
        else
        {
            Console.WriteLine("Incorrect.");
            Console.ReadLine();
        }
    }

    Console.WriteLine($"The End. You scored {points} points. Press enter to go back to main menu.");
    Console.ReadLine();
    AddToHistory("Subtraction", points);
    ShowMenu();
}

void MultiplicationGame()
{
    numQuestions = QuestionsCount();
    var random = new Random();
    int number1;
    int number2;
    int points = 0;

    for (int i = 0; i < numQuestions; i++)
    {
        Console.Clear();
        number1 = random.Next(1, 10);
        number2 = random.Next(1, 10);

        Console.WriteLine($"Multiplication Game: {points} points");
        Console.WriteLine($"{number1} * {number2} = ");
        result = Console.ReadLine();

        if (Convert.ToInt32(result) == (number1 * number2))
        {
            Console.WriteLine("Correct! + 1 point");
            Console.ReadLine();
            points++;
        }
        else
        {
            Console.WriteLine("Incorrect.");
            Console.ReadLine();
        }
    }

    Console.WriteLine($"The End. You scored {points} points. Press enter to go back to main menu.");
    Console.ReadLine();
    AddToHistory("Multiplication", points);
    ShowMenu();
}

void DivisionGame()
{
    numQuestions = QuestionsCount();
    var random = new Random();
    int points = 0;
    for (int i = 0; i < numQuestions; i++)
    {
        int[] Numbers = DivisionNumbers();
        int number1 = Numbers[0];
        int number2 = Numbers[1];
        Console.Clear();

        Console.WriteLine($"Division Game: {points} points");
        Console.WriteLine($"{number1} / {number2} = ");
        result = Console.ReadLine();

        if (Convert.ToInt32(result) == (number1 / number2))
        {
            Console.WriteLine("Correct! + 1 point");
            Console.ReadLine();
            points++;
        }
        else
        {
            Console.WriteLine("Incorrect.");
            Console.ReadLine();
        }
    }

    Console.WriteLine($"The End. You scored {points} points. Press enter to go back to main menu.");
    Console.ReadLine();
    AddToHistory("Division", points);
    ShowMenu();

}

int QuestionsCount()
{
    Console.Clear();
    Console.WriteLine("MATH GAME");
    Console.WriteLine("----------");
    int num;
    Console.WriteLine("Enter the amount of questions you want to answer: ");
    result = Console.ReadLine();
    num = Convert.ToInt32(result);
    return num;
}

int[] DivisionNumbers()
{
    var random = new Random();
    int[] Numbers = new int[2];
    Numbers[0] = random.Next(1, 100);
    Numbers[1] = random.Next(1, 100);

    while (Numbers[0] % Numbers[1] != 0)
    {
        Numbers[0] = random.Next(1, 100);
        Numbers[1] = random.Next(1, 100);
    }
    return Numbers;
}

void AddToHistory(string gamemode, int points)
{
    games.Add($"{gamemode}: {points}pts");
}

void ShowHistory()
{
    Console.Clear();
    Console.WriteLine("MATH GAME");
    Console.WriteLine("----------\n");
    Console.WriteLine("HISTORY");
    foreach (string game in games)
    {
        Console.WriteLine(game);
    }
    Console.ReadLine();
}