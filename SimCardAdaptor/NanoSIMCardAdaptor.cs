using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardAdaptor
{
    public class NanoSIMCardAdaptor : ISIMCard
    {
        private NanoSIMCard nanoSımCard;

        public NanoSIMCardAdaptor()
        {
            nanoSımCard = new NanoSIMCard();
        }
        public Data Read()
        {
            return new Data();
        }

        public void Write(Data data)
        {
            nanoSımCard.Write(data);
        }
    }
}
