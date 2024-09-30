public class Challenge_two
{
    public void GuessNumber()
    {
        int? secret = 3; // Assign the secret value
        int? guess = 0;
        while (guess != secret)
        {
            Console.WriteLine("\nGuess the secret number: ");
            guess = int.Parse(Console.ReadLine());
            if (guess == secret)
            {
              Console.WriteLine("You found the secret number! Congratulations\n");
              break;
            }
            else
            {
              continue;
            }
            
            
        }
    }

    public void Fibonacci(int n)
    {
        int a = 0, b = 1, c;

        for (int i = 0; i < n; ++i)
        {
          Console.Write($"{a}, ");
          c = a + b;
          a = b;
          b = c;
        }

        Console.WriteLine();
    }

    public void CheckIfNumberIsEvenOrOdd(double a, double b)
    {
        // Todo: Check if a number is even or odd
        // if the number is even, write out "even"
        // if the number is odd, write out "odd"
        Console.WriteLine("");
    }
}