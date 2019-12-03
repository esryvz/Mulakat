namespace Envest.DAL.Migrations
{
    using Envest.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Envest.DAL.EnvestDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Envest.DAL.EnvestDbContext context)
        {
            //context.Komponent.Add(new Komponent() { BilesenAdi = "PVC pano karkası", Stok = 20, Fiyat = 244, Birim = "TRY" });
            //context.Komponent.Add(new Komponent() { BilesenAdi = "AC UPS", Stok = 25, Fiyat = 30, Birim = "USD" });
            //context.Komponent.Add(new Komponent() { BilesenAdi = "DC UPS", Stok = 15, Fiyat = 110, Birim = "EUR" });
            //context.Komponent.Add(new Komponent() { BilesenAdi = "5A SMPS", Stok = 3, Fiyat = 91, Birim = "TRY" });
            //context.Komponent.Add(new Komponent() { BilesenAdi = "2.5A SMPS", Stok = 10, Fiyat = 57, Birim = "TRY" });
            //context.Komponent.Add(new Komponent() { BilesenAdi = "396R PLC", Stok = 75, Fiyat = 175, Birim = "USD" });
            //context.Komponent.Add(new Komponent() { BilesenAdi = "42A Analog Modül", Stok = 4, Fiyat = 130, Birim = "USD" });
            //context.Komponent.Add(new Komponent() { BilesenAdi = "Modem", Stok = 10, Fiyat = 140, Birim = "USD" });

            //context.Pano.Add(new Pano() { PanoAdi = "CP100", Kar = 20, Maliyet = 2164 });
            //context.Pano.Add(new Pano() { PanoAdi = "CP140", Kar = 15, Maliyet = 4122 });

            //context.PanoKomponent.Add(new PanoKomponent() { PanoID = 1, KomponentID = 1, Adet = 1 });
            //context.PanoKomponent.Add(new PanoKomponent() { PanoID = 1, KomponentID = 2, Adet = 1 });
            //context.PanoKomponent.Add(new PanoKomponent() { PanoID = 1, KomponentID = 5, Adet = 1 });
            //context.PanoKomponent.Add(new PanoKomponent() { PanoID = 1, KomponentID = 6, Adet = 1 });
            //context.PanoKomponent.Add(new PanoKomponent() { PanoID = 1, KomponentID = 8, Adet = 1 });

            //context.PanoKomponent.Add(new PanoKomponent() { PanoID = 2, KomponentID = 1, Adet = 1 });
            //context.PanoKomponent.Add(new PanoKomponent() { PanoID = 2, KomponentID = 3, Adet = 1 });
            //context.PanoKomponent.Add(new PanoKomponent() { PanoID = 2, KomponentID = 4, Adet = 1 });
            //context.PanoKomponent.Add(new PanoKomponent() { PanoID = 2, KomponentID = 6, Adet = 1 });
            //context.PanoKomponent.Add(new PanoKomponent() { PanoID = 2, KomponentID = 7, Adet = 2 });
            //context.PanoKomponent.Add(new PanoKomponent() { PanoID = 2, KomponentID = 8, Adet = 1 });

            //context.Satis.Add(new Satis() { Musteri = "Temsu Ltd.",PanoID=1,Adet=2,BirimFiyat=2596.8m,IndirimOrani=0, ToplamTutar=5193.6m,ToplamSatisTutari=5193.6m});
            //context.Satis.Add(new Satis() { Musteri = "Agaranti Ltd.", PanoID = 1, Adet = 1, BirimFiyat = 2596.8m, IndirimOrani = 0, ToplamTutar = 2596.8m, ToplamSatisTutari = 5193.6m });
            //context.Satis.Add(new Satis() { Musteri = "Agaranti Ltd.", PanoID = 2, Adet = 3, BirimFiyat = 4740.3m, IndirimOrani = 5, ToplamTutar = 14220.9m, ToplamSatisTutari = 13509.9m });

            //context.SaveChanges();
        }
    }
}
