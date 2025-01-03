namespace Lesson4;

internal abstract class BankAccount(string accountNumber, decimal balance)
{
    public string AccountNumber { get; protected set; } = accountNumber;
    public decimal Balance { get; protected set; } = balance;
    public abstract void Deposit(decimal amount);
    public abstract void Withdraw(decimal amount);
}
