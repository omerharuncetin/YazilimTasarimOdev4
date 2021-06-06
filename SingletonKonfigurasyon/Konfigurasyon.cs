using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonKonfigurasyon
{
    class Konfigurasyon
    {

        private static Konfigurasyon instance;
        private static object _lockObject = new object();

        public int MaksKullaniciSayisi { get; set; }
        public string LogDosyaAdi { get; set; }

        private Konfigurasyon()
        {

        }

        public static Konfigurasyon getInstance()
        {
            lock (_lockObject)
            {
                if (instance == null)
                {
                    instance = new Konfigurasyon();
                    instance.MaksKullaniciSayisi = 10;
                    instance.LogDosyaAdi = "D:\\USER.LOG";
                    Console.WriteLine($"Yeni konfigurasyon nesnesi oluşturuldu! Maks Kullanıcı Sayısı: {instance.MaksKullaniciSayisi} LogDosyaAdi: {instance.LogDosyaAdi}");
                }
                else
                {
                    Console.WriteLine($"Önceden oluşturulmuş nesne geri döndürüldü! Maks Kullanıcı Sayısı: {instance.MaksKullaniciSayisi} LogDosyaAdi: {instance.LogDosyaAdi}");
                }
            }
           
            return instance;
        }


    }
}
