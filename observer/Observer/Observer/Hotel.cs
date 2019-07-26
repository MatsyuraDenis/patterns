using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Hotel : IObservable
    {
        public int Id { get; set; }
        private bool isFree;
        private List<IObserver> observers = new List<IObserver>();

        public Hotel(int id, [Optional] params IObserver[] _observers)
        {
            Id = id;
            observers.AddRange(_observers);
        }

        public bool IsFree
        {
            get { return isFree;}
            set
            {
                if (value != IsFree)
                {
                    isFree = value;
                    Notify();
                    
                }
            }
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
            
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
