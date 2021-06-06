using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardAdaptor
{
    public class SmartPhone
    {
        public SIMCardSocket SimCardSocket;

        public SmartPhone()
        {
            SimCardSocket = new SIMCardSocket();
        }
    }
}
