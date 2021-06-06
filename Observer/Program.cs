using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IObserver gazete = new Gazete();
            IObserver internet = new Internet();

            Kredi ihtiyacKredisi = new Kredi();

            ihtiyacKredisi.RegisterObserver(gazete);
            ihtiyacKredisi.RegisterObserver(internet);
            ihtiyacKredisi.SetFaizOrani(1.15f);

            ihtiyacKredisi.RemoveObserver(internet);
            ihtiyacKredisi.SetFaizOrani(1.35f);

            ihtiyacKredisi.RemoveObserver(gazete);
            ihtiyacKredisi.SetFaizOrani(1.0f);

            Console.ReadLine();

        }
    }
}
