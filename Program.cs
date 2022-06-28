// See https://aka.ms/new-console-template for more information


int manticoreHealth = 10;
int cityHealth = 15;
int currentRound = 1;


int chosenNumber = AskForNumberInRange("Pilot, how far do you want to place the Manticore?", 0, 100);
Console.Clear();

Console.WriteLine("Guess the placement, between 0 and 100");

while (manticoreHealth > 0 && cityHealth > 0)
{
    Console.WriteLine("=================================================================");
    Console.WriteLine($"STATUS: Round: {int currentRound = TheCurrentRound} City: {cityHealth}/15 Manticore: {manticoreHealth} / 10");
    Console.WriteLine($"The cannon is expected to deal {currentDamage} this round.");
    int guessedNumber = AskForNumber("Enter desired cannon range: ");
    if (guessedNumber > chosenNumber) Console.WriteLine("That shot went too far!");
    else if (guessedNumber < chosenNumber) Console.WriteLine($"That shot went too close!");
    else if (guessedNumber == chosenNumber) Console.WriteLine("You shot the Manticore!");
}


/*
while (true)
{
    int guessedNumber = AskForNumber("What's your next guess? ");
    if (guessedNumber > chosenNumber) Console.WriteLine($"{guessedNumber} is too high");
    else if (guessedNumber < chosenNumber) Console.WriteLine($"{guessedNumber} is too low");
    else break;
}
Console.WriteLine("You guessed the right number!");
*/

//=================
//=====Methods=====
//=================

void statusBar

GCNotificationStatus

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


