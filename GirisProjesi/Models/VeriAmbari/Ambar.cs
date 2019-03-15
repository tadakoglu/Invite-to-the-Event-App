using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirisProjesi.Models.VeriAmbari
{
    public static class Ambar
    {
        //Komponentlerin, sınıfların birbiriyle gevşek bir biçimde bağlantı kurması için böyle bir şey yapıyoruz(sınıf oluşturup içinde bazı metot ve özellikleri tanımlıyoruz)
        //Bu durumda herhangi bir sınıfta değişklik yaptığımızda diğer bağlantılı sınıflar fazla etkilenmeyecektir.
        //Bu düzgün bir yazılım tasarımı anlamına gelir.

        private static List<DavetEdilenKisi> cevaplar = new List<DavetEdilenKisi>();
        public static IEnumerable<DavetEdilenKisi> Cevaplar
        {
            get
            {
                return cevaplar; // Sadece bilgi alma amaçlı bu özellik kullanılacak.
            }
      
        }
        public static void Ekle(DavetEdilenKisi davetEdilenKisi)
        {
            cevaplar.Add(davetEdilenKisi);
        }
    }
}
