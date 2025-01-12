using System;
using System.Collections.Generic;
using System.Text;

namespace OgrenciDersYonetimSistemi
{
    public abstract class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }

        public abstract void BilgiGoster();
    }
}
