using System;
using System.Collections.Generic;
using System.Text;

namespace OgrenciDersYonetimSistemi
{
    public class Ders 
    {
        public string DersAdi { get; set; }
        public int Kredi { get; set; }
        public OgretimGorevlisi OgretimGorevlisi { get; set; }
        public List<Ogrenci> KayitliOgrenciler { get; set; } = new List<Ogrenci>();

        public void BilgiGoster()
        {
            Console.WriteLine($"Ders: {DersAdi}, Kredi: {Kredi}");
            Console.WriteLine($"Öğretim Görevlisi: {OgretimGorevlisi.Unvan} {OgretimGorevlisi.Ad} {OgretimGorevlisi.Soyad}");
            Console.WriteLine("Kayıtlı Öğrenciler:");
            foreach (var ogrenci in KayitliOgrenciler)
            {
                Console.WriteLine($"- {ogrenci.Ad} {ogrenci.Soyad} (No: {ogrenci.OgrenciNo})");
            }
        }

        public void OgrenciEkle(Ogrenci ogrenci)
        {
            KayitliOgrenciler.Add(ogrenci);
            Console.WriteLine($"Öğrenci {ogrenci.Ad} {ogrenci.Soyad} derse eklendi.");
        }
    }
}
