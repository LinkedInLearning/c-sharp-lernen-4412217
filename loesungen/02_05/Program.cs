/*----------- Aufgabe 1  Ausgabe einzelner Zeichen --------------------*/

// Anlegen und initialisieren der ersten Variable
char meine_erstes_Zeichen = 'T';

// Anlegen und initialisieren der zweiten Variable 
// durch zuweisung der ersten Variable
int meine_Variable = meine_erstes_Zeichen;

// Ausgeben der Variablen auf die Konsole
Console.WriteLine("Die char Variable: " + meine_erstes_Zeichen);
Console.WriteLine("Die int Variable: " + meine_Variable);


/*----------- Aufgabe 2 Zeichenkette -------------------------------*/

// Anlegen und initialisieren der ersten Variable
string meine_erste_Zeichenkette = "The quick brown fox jumps over the lazy Dog";

string meine_zweite_Zeichenkette = "But the dog is faster";

// Ausgeben der Variablen auf die Konsole
Console.WriteLine("Die erste Zeichenkette : " + meine_erste_Zeichenkette);
Console.WriteLine("Die zweite Zeichenkette : " + meine_zweite_Zeichenkette);

// Kombination beider Zeichenketten anhand des +-Operators
string mein_Ergebnis = meine_erste_Zeichenkette + meine_zweite_Zeichenkette;

// Ausgeben der Variablen auf die Konsole
Console.WriteLine("Die Zeichenkette nach Kombinierung: " + mein_Ergebnis);