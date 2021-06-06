using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardAdaptor
{
    public interface ISIMCard
    {
        Data Read();
        void Write(Data data);
    }
}
