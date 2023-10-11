// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
CalculateFactorial(5);
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
        return 0;
    }
}

var accounts = new List<Account>
{
    new SavingsAccount(101, "Alice", 1000, 0.05m),
    new Account(102, "Bob", 1500)
};

foreach (var account in accounts)
{
    Console.WriteLine(account);
    account.Deposit(500);
    Console.WriteLine($"After deposit: {account}");
    account.Withdraw(200);
    Console.WriteLine($"After withdrawal: {account}");

    if (account is SavingsAccount savingsAccount)
    {
        savingsAccount.ApplyInterest();
        Console.WriteLine($"After interest applied: {account}");
    }

    Console.WriteLine();
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