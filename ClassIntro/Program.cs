namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "engin";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "emre";
            kurs2.IzlenmeOranı = 30;
           
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "ali";
            kurs3.IzlenmeOranı = 40;

            //Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3};
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " "+ kurs.Egitmen);
            }


        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}