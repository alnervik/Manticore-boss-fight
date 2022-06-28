
int manticoreHealth = 10;
int cityHealth = 15;
int currentRound = 1;


int chosenNumber = AskForNumberInRange("Pilot, how far do you want to place the Manticore? ");
Console.Clear();
Console.WriteLine("It's your time to guess the placement of the Manticore.");

while (manticoreHealth > 0 && cityHealth > 0)
{
    StatusBar(currentRound, cityHealth, manticoreHealth);

    int currentDamage = CurrentRoundDamage(currentRound);
    Console.WriteLine($"The cannon is expected to deal {currentDamage} damage this round.");

    int guessedNumber = AskForNumber("Enter desired cannon range: ");
    HitChecker(guessedNumber, chosenNumber, currentDamage);
    ManticoreAttack(cityHealth--);
    currentRound++;
}

WinnerOrLoser(cityHealth);


//=================
//=====Methods=====
//=================
void WinnerOrLoser(int cityHealth)
{
    if (cityHealth == 0)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You were not able to save the city. Consolas vanquished.");
        Console.ReadLine();
    }
    if (cityHealth > 0)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You destroyed the Manticore and saved Consolas. Congratulations!");
        Console.ReadLine();
    }
}

void ManticoreAttack(int cityHealth)
{
    if (manticoreHealth > 0)
    {
        cityHealth--;
    }
}

void HitChecker(int guessedNumber, int chosenNumber, int currentDamage)
{
    if (guessedNumber > chosenNumber) Console.WriteLine("That shot went too far!");
    else if (guessedNumber < chosenNumber) Console.WriteLine($"That shot went too close!");
    else if (guessedNumber == chosenNumber)
    {
        Console.WriteLine("You hit the Manticore!");
        manticoreHealth -= currentDamage;
    }
}

int AskForNumber(string text)
{
    Console.Write(text);
    int guessingNumber = Convert.ToInt32(Console.ReadLine());
    return guessingNumber;
}

int AskForNumberInRange(string text)
{
    while (true)
    {
        int chosenNumber = AskForNumber(text);
        if (chosenNumber >= 0 && chosenNumber <= 100)
            return chosenNumber;
    }
}

void StatusBar(int currentRound, int cityHealth, int manticoreHealth)
{
    Console.WriteLine(" ");
    Console.WriteLine("=================================================================");
    Console.WriteLine($"STATUS: Round: { currentRound } City: { cityHealth }/15 Manticore: { manticoreHealth }/10");
}

int CurrentRoundDamage(int currentRound)
{
    if (currentRound % 5 == 0 && currentRound % 3 == 0)
        {
        return 10;
        }
     else if (currentRound % 5 == 0)
        {
        return 3;
        }
     else if (currentRound % 3 == 0)
        {
        return 3;
        }
     else
        {
        return 1;
        }
}