namespace Lesson4;

internal static class Program
{
    private static void Main()
    {
        Ex1();
    }

    private static void Ex1()
    {
        var account = new CheckingAccount("1234567890", 1000, 100);
        account.Deposit(1000);
        account.Withdraw(300);
        Console.WriteLine($"Account Balance: {account.Balance}");
        
        var savingsAccount = new SavingAccount("9876543210", 1000, 0.05m);
        savingsAccount.Deposit(1000);
        savingsAccount.Withdraw(300);
        Console.WriteLine($"Account Balance: {savingsAccount.Balance}");
    }
}
