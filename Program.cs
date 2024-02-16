using System.Collections;

string? option;
void ShowMenu()
{
    Console.Clear();
    Console.WriteLine("MATH GAME");
    Console.WriteLine("----------\n");
    Console.WriteLine("1. Play");
    Console.WriteLine("2. History");
    Console.WriteLine("3. Exit");
    Console.Write("Choose an option: ");
    option = Console.ReadLine();

    switch (option)
    {
        case "1":
        ChooseGame();
            break;
        case "2":
            break;
        case "3":
            Console.WriteLine("BYE");
            Environment.Exit(1);
            break;
        default:
            ShowMenu();
            break;

    }
}

void ChooseGame() 
{
    Console.WriteLine("Choose a game: ");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Divison");
    option = Console.ReadLine();

    switch(option)
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

}

void SubtractionGame()
{

}

void MultiplicationGame()
{

}

void DivisionGame()
{
    
}
