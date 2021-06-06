using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardAdaptor
{
    public class SIMCardSocket
    {
        private ISIMCard simCardReferans;

        public SIMCardSocket()
        {
            simCardReferans = new NanoSIMCardAdaptor();
        }
        public void Insert(ISIMCard simCard)
        {
            simCardReferans.Write(simCard.Read());
        }

        
    }
}
