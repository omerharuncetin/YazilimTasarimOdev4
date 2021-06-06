using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardAdaptor
{
    public class NanoSIMCard : ISIMCard
    {
        public Data Read()
        {
            return new Data();
        }

        public void Write(Data data)
        {
            Console.WriteLine("nano sim card icin data yazıldı.");
        }
    }
}
