using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Gazete : IObserver
    {
        public void Guncelle(float yeniFaizOrani)
        {
            Console.WriteLine($"Yeni faiz oranı {yeniFaizOrani} Haberciniz Gazete !");
        }
    }
}
