// Wähle eine Zufallszahl zwischen 0 und 20
int theNumber = new Random().Next(20);
bool keepGoing = true;

// Ausgabe der Spielbegrüßung und weiterer Answeisungen
Console.WriteLine("Lass uns 'Zahlen raten' spielen.");
Console.WriteLine("Ich denke mir eine Zahl zwischen 0 und 20 aus.");
Console.WriteLine("Schreibe deine Zahl in die Konsole, oder -1 um es zu beenden.");

// Verfolge die Anzahl der Vermutungen und der aktuell geratenen Zahl
int guessNum = 0;
int guessCount = 0;

// Die while-Schleife läuft solange der Nutzer das Programm beendet oder die
// Zahl richtig erraten hat
while (keepGoing)
{
  // Den Benutzer nach seiner aktuellen Vermutung fragen
  Console.WriteLine("Rate mal!?");

  // Die ToInt32-Funktion hilft uns die Eingabe in eine Zahl zu parsen
  guessNum = Convert.ToInt32(Console.ReadLine());

  // Bei der Eingabe einer -1, wird das Programm beendet
  if (guessNum == -1)
  {
    Console.WriteLine("Oh schade. Ich habe an die Zahl " + theNumber + " gedacht.");
    keepGoing = false;
  }
  else
  {
    // Anzahl der benötigten Versuche erhöhen
    guessCount++;

    // Wenn die Zahl richtig erraten wurde, wird die Anzahl der Versuche ausgegeben
    // und das Programm beendet
    if (guessNum == theNumber)
    {
      Console.WriteLine("Hurra, Du hast es mit " + guessCount + " Versuchen erraten!!");
      keepGoing = false;
    }
    else
    {
      // Ausgabe ob die geratene Zahl größer oder kleiner 
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
