int theNumber = new Random().Next(20);
bool keepGoing = true;

Console.WriteLine("Lass uns das Spiel 'Zahlen raten' spielen!");
Console.WriteLine("Ich denke mir eine Zahl zwischen 0 und 20 aus.");
Console.WriteLine("Versuche meine Zahl zu erraten, oder tippe -1 um das Spiel zu beenden.");

int guessNum = 0;
int guessCount = 0;


while (keepGoing)
{

  Console.WriteLine("Rate mal!?");
  guessNum = Convert.ToInt32(Console.ReadLine());

  if (guessNum == -1)
  {


    Console.WriteLine("Oh well. I was thinking of " + theNumber);
    keepGoing = false;
  }
  else
  {
    guessCount++;
    if (guessNum == theNumber)
    {
      Console.WriteLine("You got it in " + guessCount + " guesses!!");
      keepGoing = false;
    }
    else
    {
      Console.WriteLine("Nope, {0} than that.", guessNum < theNumber ? "higher" : "lower");
    }
  }
}