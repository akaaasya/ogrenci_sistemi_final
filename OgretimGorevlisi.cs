using System;
using System.Collections.Generic;
using System.Text;

namespace OgrenciDersYonetimSistemi
{
    public class OgretimGorevlisi : Kisi, ILogin
    {
        public string Unvan { get; set; }

        public override void BilgiGoster()
        {
            Console.WriteLine($"Öğretim Görevlisi: {Unvan} {Ad} {Soyad}, Email: {Email}");
        }

        public void Login()
        {
            Console.WriteLine($"Öğretim Görevlisi {Ad} {Soyad} sisteme giriş yaptı.");
        }
    }
}
