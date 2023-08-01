namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do not repeat yourself - kendini tekrar etme

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000; //tam sayi tutar
            double faizOrani = 1.45;  //ondalık sayı
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}