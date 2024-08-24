using Week7_App3;

public class Program
{
    public static void Main()
    {
        List<Dizi> diziler = new List<Dizi>
        {
            new Dizi { Ad = "Avrupa Yakası", YapimYili = 2004, Turu = "Komedi", YayinaBaslamaYili = 2004, Yonetenler = "Yüksel Aksu", YayindigiIlkPlatform = "Kanal D" },
            new Dizi { Ad = "Yalan Dünya", YapimYili = 2012, Turu = "Komedi", YayinaBaslamaYili = 2012, Yonetenler = "Gülseren Buda Başkaya", YayindigiIlkPlatform = "Fox TV" },
            new Dizi { Ad = "Jet Sosyete", YapimYili = 2018, Turu = "Komedi", YayinaBaslamaYili = 2018, Yonetenler = "Gülseren Buda Başkaya", YayindigiIlkPlatform = "TV8" },
            new Dizi { Ad = "Dadı", YapimYili = 2006, Turu = "Komedi", YayinaBaslamaYili = 2006, Yonetenler = "Yusuf Pirhasan", YayindigiIlkPlatform = "Kanal D" },
            new Dizi { Ad = "Belalı Baldız", YapimYili = 2007, Turu = "Komedi", YayinaBaslamaYili = 2007, Yonetenler = "Yüksel Aksu", YayindigiIlkPlatform = "Kanal D" },
            new Dizi { Ad = "Arka Sokaklar", YapimYili = 2004, Turu = "Polisiye, Dram", YayinaBaslamaYili = 2004, Yonetenler = "Orhan Oğuz", YayindigiIlkPlatform = "Kanal D" },
            new Dizi { Ad = "Aşk-ı Memnu", YapimYili = 2008, Turu = "Dram, Romantik", YayinaBaslamaYili = 2008, Yonetenler = "Hilal Saral", YayindigiIlkPlatform = "Kanal D" },
            new Dizi { Ad = "Muhteşem Yüzyıl", YapimYili = 2011, Turu = "Tarihi, Dram", YayinaBaslamaYili = 2011, Yonetenler = "Mercan Çilingiroğlu", YayindigiIlkPlatform = "Star TV" },
            new Dizi { Ad = "Yaprak Dökümü", YapimYili = 2006, Turu = "Dram", YayinaBaslamaYili = 2006, Yonetenler = "Serdar Akar", YayindigiIlkPlatform = "Kanal D" }
        };

        List<KisaltmaDizi> komediDizileri = diziler
            .Where(d => d.Turu.Contains("Komedi"))
            .Select(d => new KisaltmaDizi
            {
                Ad = d.Ad,
                Turu = d.Turu,
                Yonetenler = d.Yonetenler
            })
            .OrderBy(d => d.Ad)
            .ThenBy(d => d.Yonetenler)
            .ToList();

        // Yeni listeyi yazdırma
        foreach (var dizi in komediDizileri)
        {
            Console.WriteLine($"Dizi Adı: {dizi.Ad}, Türü: {dizi.Turu}, Yönetmen: {dizi.Yonetenler}");
        }

    }
}