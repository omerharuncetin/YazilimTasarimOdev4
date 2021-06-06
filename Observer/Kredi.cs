using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Kredi : ISubject
    {
        private float faizOrani;
        private List<IObserver> observers = new List<IObserver>();

        public void SetFaizOrani(float faizOrani)
        {
            this.faizOrani = faizOrani;
            NotifyObservers();
        }

        public void RegisterObserver(IObserver o)
        {
            this.observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            this.observers.Remove(o);
        }

        public void NotifyObservers()
        {

            foreach (var observer in observers)
            {
                observer.Guncelle(this.faizOrani);
            }
        }
    }
}
