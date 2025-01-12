using System;
using System.Collections.Generic;
using System.Text;

namespace OgrenciDersYonetimSistemi
{
    public class Ogrenci : Kisi, ILogin
    {
        public int OgrenciNo { get; set; }

        public override void BilgiGoster()
        {
            Console.WriteLine($"Öğrenci: {Ad} {Soyad}, No: {OgrenciNo}, Email: {Email}");
        }

        public void Login()
        {
            Console.WriteLine($"Öğrenci {Ad} {Soyad} sisteme giriş yaptı.");
        }
    }
}
