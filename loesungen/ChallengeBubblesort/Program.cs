void BubbleSort(int[] toSort)
{
  // Äußerer Schleifendurchlauf für jedes einzelne Element des Arrays
  for (int i = 0; i < toSort.Length; i++)
  {
    // Innere Schleife für um das aktuelle Element mit dem darauffolgenden Element
    // zu vergleichen
    for (int j = 0; j < toSort.Length - 1; j++)
    {
      // Vergleich ob das aktuelle Element größer ist als das nächste
      if (toSort[j] > toSort[j + 1])
      {
        // Dann soll das aktuelle Element mit dem nächsten Element
        // ausgetauscht werden
        int tmp = toSort[j];
        toSort[j] = toSort[j + 1];
        toSort[j + 1] = tmp;
      }
    }
  }
}


int[] mein_erstes_array = { 22, 1, 21, 11, 5 };

BubbleSort(mein_erstes_array);

for (int i = 0; i < mein_erstes_array.Length; i++)
{
  Console.WriteLine(mein_erstes_array[i]);
}