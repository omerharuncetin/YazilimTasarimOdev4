using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardAdaptor
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone smartPhone = new SmartPhone();
            NanoSIMCard nanoSımCard = new NanoSIMCard();
            smartPhone.SimCardSocket.Insert(nanoSımCard);

            Console.ReadKey();
        }
    }
}
