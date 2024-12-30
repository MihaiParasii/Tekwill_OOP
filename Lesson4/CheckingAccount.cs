namespace Lesson4;

internal class CheckingAccount(string accountNumber, decimal balance, decimal overdraftLimit)
    : BankAccount(accountNumber, balance)
{
    private decimal OverdraftLimit { get; } = overdraftLimit;

    public override void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            return;
        }

        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            return;
        }

        if (Balance + OverdraftLimit < amount)
        {
            return;
        }

        Balance -= amount;
    }
}
