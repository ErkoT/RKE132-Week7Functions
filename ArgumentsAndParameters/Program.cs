

Console.WriteLine("Enter word");
string userInput = Console.ReadLine();
PrintAnyWord(userInput);

static void PrintAnyWord(string anyString) // anystring on argument
{
    anyString = anyString.ToUpper();
    for(int i = 0; i<5; i++)
    {
        Console.WriteLine(anyString);
    }
}

