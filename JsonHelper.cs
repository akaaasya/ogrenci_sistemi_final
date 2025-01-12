using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace OgrenciDersYonetimSistemi
{
    public class JsonHelper
    {
        // JSON dosyasına veriyi burada yazdım
        public static void JsonYaz<T>(string dosyaAdı, T veri)
        {
            string jsonVeri = JsonConvert.SerializeObject(veri, Formatting.Indented);
            File.WriteAllText(dosyaAdı, jsonVeri);
        }

        // JSON dosyasından veriyi okumak için gerekli method
        public static T JsonOku<T>(string dosyaAdı)
        {
            if (File.Exists(dosyaAdı))
            {
                string jsonVeri = File.ReadAllText(dosyaAdı);
                return JsonConvert.DeserializeObject<T>(jsonVeri);
            }
            return default;
        }

    }
}   