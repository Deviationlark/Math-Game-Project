using System.Collections;
using System.Globalization;
bool gameEnd = false;
string? result;
int points = 0;
int numQuestions = 0;
while (!gameEnd)
{
    ShowMenu();
}

void ShowMenu()
{
    Console.Clear();
    Console.WriteLine("MATH GAME");
    Console.WriteLine("----------\n");
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
    Console.WriteLine("----------\n");
    Console.WriteLine("Choose a game: ");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Divison");
    result = Console.ReadLine();

    switch(result)
    {
        case "1":
            AdditionGame();
            break;
        case "2":
            SubtractionGame();
            break;
        case "3":
            MultiplicationGame();
            break;
        case "4":
            DivisionGame();
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
    
    for(int i = 0; i < numQuestions; i++)
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
    ShowMenu();
}

void SubtractionGame()
{
    numQuestions = QuestionsCount();
    var random = new Random();
    int number1;
    int number2;
    
    for(int i = 0; i < numQuestions; i++)
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
    ShowMenu();
}

void MultiplicationGame()
{
    numQuestions = QuestionsCount();
    var random = new Random();
    int number1;
    int number2;
    
    for(int i = 0; i < numQuestions; i++)
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
    ShowMenu();
}

void DivisionGame()
{
    int[] Numbers = DivisionNumbers();

    numQuestions = QuestionsCount();
    var random = new Random();
    int number1 = Numbers[0];
    int number2 = Numbers[1];
    
    for(int i = 0; i < numQuestions; i++)
    {
        Console.Clear();

        Console.WriteLine($"Division Game: {points} points");
        Console.WriteLine($"{number1} / {number2} = ");
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
    ShowMenu();

}

int QuestionsCount()
{
    Console.Clear();
    Console.WriteLine("MATH GAME");
    Console.WriteLine("----------\n");
    int num;
    Console.WriteLine("Enter the amount of questions you want to answer: ");
    result = Console.ReadLine();
    num = Convert.ToInt32(result);
    return num;
}
// Fix this
int[] DivisionNumbers()
{
    var random = new Random();
    int[] Numbers = new int[2];
    Numbers[0] = random.Next(1, 100);
    Numbers[1] = random.Next(1, 100);
    
    if(Numbers[0] % Numbers[1] != 0)
        DivisionNumbers();

    return Numbers;
}