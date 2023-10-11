using System;
using System.Collections.Generic;

class Account
{
    public int AccountNumber { get; }
    public string AccountHolder { get; }
    public decimal Balance { get; protected set; }

    public Account(int accountNumber, string accountHolder, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    public virtual void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException("Amount must be positive");
        Balance += amount;
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException("Amount must be positive");
        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds");
        Balance -= amount;
    }

    public override string ToString()
    {
        return $"Account Number: {AccountNumber}, Holder: {AccountHolder}, Balance: {Balance:C}";
    }
}