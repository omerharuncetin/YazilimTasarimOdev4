using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonKonfigurasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            Konfigurasyon konfigurasyon1 = Konfigurasyon.getInstance();
            Konfigurasyon konfigurasyon2 = Konfigurasyon.getInstance();
            Konfigurasyon konfigurasyon3 = Konfigurasyon.getInstance();

            Console.ReadLine();
        }
    }
}
