using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankObserverApp.Observer
{
    internal class BankBranch: IObserver
    {
        private string branchName;

        public BankBranch(string name)
        {
            branchName = name;
        }
        public void Update(string message)
        {
            Console.WriteLine($"{branchName} : {message} 'received'");
        }
    }
}
