
int manticoreHealth = 10;
int cityHealth = 15;
int currentRound = 1;


int chosenNumber = AskForNumberInRange("Pilot, how far do you want to place the Manticore?", 0, 100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("It's your time to guess the placement of the Manticore.");

while (manticoreHealth > 0 && cityHealth > 0)
{
    Console.WriteLine("=================================================================");
    StatusBar(currentRound, cityHealth, manticoreHealth);

    int currentDamage = CurrentRoundDamage(currentRound);
    Console.WriteLine($"The cannon is expected to deal {currentDamage} damage this round.");
    int guessedNumber = AskForNumber("Enter desired cannon range: ");
    if (guessedNumber > chosenNumber) Console.WriteLine("That shot went too far!");
    else if (guessedNumber < chosenNumber) Console.WriteLine($"That shot went too close!");
    else if (guessedNumber == chosenNumber) Console.WriteLine("You hit the Manticore!");

        if (guessedNumber == chosenNumber) manticoreHealth -= currentDamage;

    if (manticoreHealth > 0) cityHealth--;
    if (manticoreHealth == 0) Console.WriteLine("Die bitch");
    currentRound++;
}

if (cityHealth == 0)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You were not able to save the city. Consolas vanquished.");
}
if (cityHealth > 0)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("You destroyed the Manticore. Congratulations!");
}

//=================
//=====Methods=====
//=================

int AskForNumber(string text)
{
    Console.Write(text);
    int guessingNumber = Convert.ToInt32(Console.ReadLine());
    return guessingNumber;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int chosenNumber = AskForNumber(text);
        if (chosenNumber >= min && chosenNumber <= max)
            return chosenNumber;
    }
}

void StatusBar(int currentRound, int cityHealth, int manticoreHealth)
{
    Console.WriteLine($"STATUS: Round: {currentRound} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
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