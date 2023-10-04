using BankObserverApp.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankObserverApp.Subject
{
    internal class MainBank : ISubject
    {

        private List<IObserver> observers = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            //NotifyObservers($"{observer.Update} is removed ");
             observers.Remove(observer);
            



        }


        public void NotifyObservers(string message)
        {
            foreach (var observer in observers)
            {
                 observer.Update(message);
                
            }
        }


        // Simulate an event at the main bank
        //public void MainBankEvent()
        //{
        //    Console.WriteLine("Main Bank is processing a transaction.");
        //    NotifyObservers("Transaction processed at Main Bank.");
        //}

        
    }

}