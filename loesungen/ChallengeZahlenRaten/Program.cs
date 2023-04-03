int theNumber = new Random().Next(20);
bool keepGoing = true;

Console.WriteLine("Lass uns 'Zahlen raten' spielen.");
Console.WriteLine("Ich denke mir eine Zahl zwischen 0 und 20 aus.");
Console.WriteLine("Schreibe deine Zahl in die Konsole, oder -1 um es zu beenden.");

int guessNum = 0;
int guessCount = 0;

while (keepGoing)
{
  Console.WriteLine("Rate mal!?");
  guessNum = Convert.ToInt32(Console.ReadLine());

  if (guessNum == -1)
  {
    Console.WriteLine("Oh schade. Ich habe an die Zahl " + theNumber + " gedacht.");
    keepGoing = false;
  }
  else
  {
    guessCount++;
    if (guessNum == theNumber)
    {
      Console.WriteLine("Hurra, Du hast es mit " + guessCount + " Versuchen erraten!!");
      keepGoing = false;
    }
    else
    {
      string compare;
      if (guessNum < theNumber)
      {
        compare = "größer";
      }
      else
      {
        compare = "kleiner";
      }
      Console.WriteLine("Leider falsch. Meine Zahl ist " + compare + " als diese");
    }
  }
}
