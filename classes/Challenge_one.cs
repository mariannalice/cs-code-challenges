public class Challenge_one
{
  public void PrintNumbers()
  {
   // int [] myNumbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
    for(int i = 1; i <= 10; i = i + 1)
    {
      Console.WriteLine(i);
    }
  }

  public void PrintStrings(string[] arr)
  {
    foreach (string tekst in arr)
    {
      Console.WriteLine(tekst);
    }
  }

  public void CheckIfNumberIsPositiveOrNegative(int number)
  {
    if (number == 0)
    {
      Console.WriteLine(number +" is zero");
    }

    else if (number > 0)
    {
      Console.WriteLine(number +" is positive");
    }

    else 
    {
      Console.WriteLine(number +" is negative");
    }
  }
}