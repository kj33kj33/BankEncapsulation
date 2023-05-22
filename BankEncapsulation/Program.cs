namespace BankEncapsulation;

public class Program
{
    static void Main(string[] args)
    {
        var bankAccount = new BankAccount();

        Console.WriteLine("Please create a 4 digit pin number to begin:\n");
        bankAccount.Pin = int.Parse(Console.ReadLine());

        bool pinCheck = false;
        do
        {
            Console.WriteLine("Please enter the pin number you just created:\n");
            pinCheck = bankAccount.CheckPin(int.Parse(Console.ReadLine()));
        } while (pinCheck == false);


        Console.WriteLine("Welcome! Press enter to continue:");
        var userInput = Console.ReadLine();

        do
        {
            Console.WriteLine("Please select an option:\nPress 'd' for Deposit, 'b' for balance, 'w' for withdraw, 'p' to set a new pin number, or 'quit' to exit.");
            userInput = Console.ReadLine();

            if (userInput.ToLower() == "d")
            {
                Console.WriteLine("Enter the amount you would like to deposit: ");


                double deposit = double.Parse(Console.ReadLine());

                bankAccount.Deposit(deposit);

                Console.WriteLine($"The new balance is: ${bankAccount.GetBalance()}\n");
                Console.WriteLine("If you would like to make another deposit or withdrawal, press enter. Otherwise please type 'quit'.");
                if(Console.ReadLine() == "quit")
                {
                    break;
                }

            }
            else if (userInput.ToLower() == "b")
            {
                Console.WriteLine($"The balance is ${bankAccount.GetBalance()}\n");
            }
            else if (userInput.ToLower() == "w")
            {
                Console.WriteLine("Enter the amount you would like to withdraw: ");


                double withdraw = double.Parse(Console.ReadLine());
                bankAccount.Withdraw(withdraw);
                Console.WriteLine($"The new balance is ${bankAccount.GetBalance()}\n");
                Console.WriteLine("If you would like to make another deposit or withdrawal, press enter. Otherwise please type 'quit'.");
                if (Console.ReadLine() == "quit")
                {
                    break;
                }

            }
            else if (userInput.ToLower() == "p")
            {
                Console.WriteLine("Please enter your new 4 digit pin number:\n");
                int newPin = int.Parse(Console.ReadLine());
                bankAccount.SetPin(newPin);
                Console.WriteLine("The new pin number has been set.");
            }
        } while (userInput != "quit");
    } 
}
