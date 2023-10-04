using BankObserverApp.Observer;
using BankObserverApp.Subject;

namespace BankObserverApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the main bank
            MainBank mainBank = new MainBank();

            // Create bank branches (observers)
            BankBranch branch1 = new BankBranch("Adimali Branch ");
            BankBranch branch2 = new BankBranch("Pune Branch Brach");
            BankBranch branch3 = new BankBranch("Trivandram Branch");
            


            // Register bank branches as observers of the main bank
            mainBank.RegisterObserver(branch1);
            mainBank.RegisterObserver(branch2);
            mainBank.RegisterObserver(branch3);
            


            
            mainBank.NotifyObservers("Welcome Branches");

            
            mainBank.RemoveObserver(branch1);
            Console.WriteLine("\n------------------------------\n");
            
            mainBank.NotifyObservers($"Adimali Branch is removed Don't accept any requests");
        }
    }
}