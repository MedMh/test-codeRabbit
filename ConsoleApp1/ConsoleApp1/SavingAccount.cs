class SavingsAccount : Account
{
    private decimal InterestRate;

    public SavingsAccount(int accountNumber, string accountHolder, decimal initialBalance, decimal interestRate)
        : base(accountNumber, accountHolder, initialBalance)
    {
        InterestRate = interestRate;
    }

    public void ApplyInterest()
    {
        Balance += Balance * InterestRate;
    }
}