namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount Checking = new BankAccount();
            Console.WriteLine("How much money do you want to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            Checking.Deposit(amountToDeposit);
            double userBalance = Checking.GetBalance();

            Console.WriteLine($"Your current balance is: {userBalance, 0:c}");

        }
    }
}
