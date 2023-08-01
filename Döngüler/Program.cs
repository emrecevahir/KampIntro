namespace Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";


            //array - dizi 
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" ,
                "programlamaya başlangıç için temel kurs", "Java","python" };



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for döngüsü bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu-footer");
        }
    }
}