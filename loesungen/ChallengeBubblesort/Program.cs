void BubbleSort(int[] toSort)
{
  for (int i = 0; i < toSort.Length; i++)
  {
    for (int j = 0; j < toSort.Length - 1; j++)
    {
      if (toSort[j] > toSort[j + 1])
      {
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