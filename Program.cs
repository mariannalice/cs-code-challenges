namespace cs_code_challenges;

class Program
{
    static void Main(string[] args)
    {
       Challenge_one one = new Challenge_one();
       one.PrintNumbers();

       string[] hund = ["\nLiker", "du", "labrador retriver", "eller", "golden retriver", "?\n"];
       one.PrintStrings(hund);
       

       for(int i = -3; i <= 3; i = i + 1)
       {
        one.CheckIfNumberIsPositiveOrNegative(i);
       }
       

       
       
       Challenge_two two = new Challenge_two();
       two.GuessNumber();
       
       int terms = 10;
       two.Fibonacci(terms);
       //Challenge_three three = new Challenge_three();

       //void ValidateRecursiveFactorial()
       //{
        //int n = 5;
        //int expected = 120;
        //int result = three.RecursiveFactorial(n);

        //if (result == expected)
        //{
            //Console.WriteLine($"Test passed: RecursiveFactorial({n}) = {expected}");
        //}
        //else
        //{
            //Console.WriteLine($"Test failed: RecursiveFactorial({n}) = {result}, expected: {expected}");
        //}
       //}

       //ValidateRecursiveFactorial();
    }
}
