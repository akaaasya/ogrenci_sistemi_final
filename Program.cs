﻿using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using OgrenciDersYonetimSistemi;


namespace OgrenciDersYonetimSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Öğretim görevlisi bilgisi
            var ogretimGorevlisi = new OgretimGorevlisi
            {
                Ad = "Ali",
                Soyad = "Yılmaz",
                Unvan = "Doç. Dr.",
                Email = "ali.yilmaz@universite.edu.tr"
            };

            // Öğretim görevlisini JSON dosyasına kaydet
            JsonHelper.JsonYaz("ogretim_gorevlisi.json", ogretimGorevlisi);

            // Ders bilgisi
            var ders = new Ders
            {
                DersAdi = "Matematik",
                Kredi = 4,
                OgretimGorevlisi = ogretimGorevlisi
            };
           
            // Öğrencileri listeler
            var ogrenci1 = new Ogrenci { Ad = "Ayşe", Soyad = "Demir", OgrenciNo = 123, Email = "ayse.demir@student.edu.tr" };
            var ogrenci2 = new Ogrenci { Ad = "Mehmet", Soyad = "Kaya", OgrenciNo = 456, Email = "mehmet.kaya@student.edu.tr" };

            // Öğrencileri derse ekler
            ders.OgrenciEkle(ogrenci1);
            ders.OgrenciEkle(ogrenci2);

            // Ders bilgilerini JSON dosyasına kaydeder
            JsonHelper.JsonYaz("ders.json", ders);

            Console.WriteLine("\nDers Bilgileri:");
            ders.BilgiGoster();

            // Sistemdeki giriş işlemlerini gerçekleştirir.
            Console.WriteLine("\nSisteme Girişler:");
            ogretimGorevlisi.Login();
            ogrenci1.Login();
            ogrenci2.Login();

            // JSON dosyasından okuma
            Console.WriteLine("\nOkunan Ders Bilgileri:");
            var okunanDers = JsonHelper.JsonOku<Ders>("ders.json");
            if (okunanDers != null)
            {
                okunanDers.BilgiGoster();
            }
            else
            {
                Console.WriteLine("Ders bilgisi bulunamadı.");
            }

            var okunanOgretimGorevlisi = JsonHelper.JsonOku<OgretimGorevlisi>("ogretim_gorevlisi.json");
            if (okunanOgretimGorevlisi != null)
            {
                Console.WriteLine("\nOkunan Öğretim Görevlisi Bilgileri:");
                Console.WriteLine($"Adı: {okunanOgretimGorevlisi.Ad}, Soyadı: {okunanOgretimGorevlisi.Soyad}, Ünvan: {okunanOgretimGorevlisi.Unvan}, E-mail: {okunanOgretimGorevlisi.Email}");
            }
            else
            {
                Console.WriteLine("Öğretim görevlisi bilgisi bulunamadı.");
            }
        }
    }
}
