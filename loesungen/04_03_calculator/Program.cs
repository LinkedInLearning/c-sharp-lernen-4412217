int add(int firstNumber, int secondNumber)
{
  return firstNumber + secondNumber;
}

Console.WriteLine("----------Test für add-Funktion-------------");
Console.WriteLine(add(9, 2));
Console.WriteLine(add(0, 0));
Console.WriteLine(add(-11, 21));
Console.WriteLine("---------------------------------------------");

int sub(int firstNumber, int secondNumber)
{
  if (firstNumber < secondNumber)
  {
    return secondNumber - firstNumber;
  }

  return firstNumber - secondNumber;
}

Console.WriteLine("----------Test für sub-Funktion-------------");
Console.WriteLine(sub(9, 2));
Console.WriteLine(sub(11, 21));
Console.WriteLine(sub(-11, 21));
Console.WriteLine("---------------------------------------------");

int multiply(int firstNumber, int secondNumber)
{
  int product = 0;
  bool isNegative = (firstNumber < 0 && secondNumber > 0) || (firstNumber > 0 && secondNumber < 0);

  if (secondNumber < 0)
  {
    secondNumber = -secondNumber;
  }

  if (firstNumber < 0)
  {
    firstNumber = -firstNumber;
  }

  for (int i = 0; i < secondNumber; i++)
  {
    product = product + firstNumber;
  }

  if (isNegative)
  {
    return -product;
  }

  return product;
}

Console.WriteLine("----------Test für multiply-Funktion-------------");
Console.WriteLine(multiply(-9, 2));
Console.WriteLine(multiply(11, -2));
Console.WriteLine(multiply(-11, -11));
Console.WriteLine(multiply(11, 0));
Console.WriteLine("-------------------------------------------------");

double divide(double firstNumber, double secondNumber)
{
  if (secondNumber == 0)
  {
    return 0;
  }

  return firstNumber / secondNumber;
}

Console.WriteLine("----------Test für sub-Funktion-------------");
Console.WriteLine(divide(9, 2));
Console.WriteLine(divide(22, 2));
Console.WriteLine(divide(-11, 3));
Console.WriteLine(divide(-11, 0));
Console.WriteLine("---------------------------------------------");