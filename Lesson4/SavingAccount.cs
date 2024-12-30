namespace Lesson4;

internal class SavingAccount(string accountNumber, decimal balance, decimal interestRate)
    : BankAccount(accountNumber, balance)
{
    private decimal InterestRate { get; } = interestRate;

    public override void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            return;
        }

        Balance += amount * (1 + InterestRate);
    }

    public override void Withdraw(decimal amount)
    {
        if (amount < 0 || amount > Balance)
        {
            return;
        }

        Balance -= amount;
    }
}
