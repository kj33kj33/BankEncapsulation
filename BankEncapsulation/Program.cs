namespace BankEncapsulation;

public class Program
{
    static void Main(string[] args)
    {
        var bankAccount = new BankAccount();

        Console.WriteLine("Enter the amount you would like to deposit: ");

        double deposit = double.Parse(Console.ReadLine());

        bankAccount.Deposit(deposit);

        Console.WriteLine($"The new balance is: ${bankAccount.GetBalance()}");
    } 
}
