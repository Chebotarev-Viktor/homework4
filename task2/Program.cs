Console.WriteLine ("Введите число: ");
int numberN = int.Parse(Console.ReadLine());

  int SumNumber(int numberN)
  {
    int counter = Convert.ToString(numberN).Length;
    int progress = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
      progress = numberN - numberN % 10;
      result = result + (numberN - progress);
      numberN = numberN / 10;
    }
   return result;
  }
int sumNumber = SumNumber(numberN);
Console.WriteLine(sumNumber);