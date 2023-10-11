// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
CalculateFactorial(5);
IsPalindrome("radar");
SumOfEvenNumbers(new[] { 1, 2, 3, 4, 5, 6 });


static int CalculateFactorial(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}

bool IsPalindrome(string input)
{
    string cleanInput = input.Replace(" ", "").ToLower();
    string reversedInput = new string(cleanInput.Reverse().ToArray());

    if (cleanInput == reversedInput)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int SumOfEvenNumbers(int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        if (number % 2 == 0)
        {
            sum += number;
        }
    }
    return sum;
}

/***
 *  better versions of the functions
 *
 * static int CalculateFactorial(int n)
{
    if (n < 0)
    {
        throw new ArgumentException("Factorial is not defined for negative numbers", nameof(n));
    }

    return n == 0 ? 1 : n * CalculateFactorial(n - 1);
}

bool IsPalindrome(string input)
{
    // Clean and normalize the input string
    string cleanInput = input.ToLower().Replace(" ", "");

    // Check if the cleaned string is the same as its reverse
    return cleanInput == new string(cleanInput.Reverse().ToArray());
}

public int SumOfEvenNumbers(int[] numbers)
{
    return numbers.Where(n => n % 2 == 0).Sum();
}

 */