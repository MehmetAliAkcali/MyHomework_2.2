class Program
{
    static void Main()
    {
        // Çalışanları oluşturuyoruz
        Calisan genelMudur = new GenelMudur();
        Calisan mudur = new Mudur();
        Calisan programci = new Programci();
        Calisan stajyer = new Stajyer();

        // Çalışanların maaşlarını hesaplıyoruz ve ekrana yazdırıyoruz
        double toplamMaas = genelMudur.maasinizNedir() +
                            mudur.maasinizNedir() +
                            programci.maasinizNedir() +
                            stajyer.maasinizNedir();

        Console.WriteLine("Toplam Maaş: " + toplamMaas);
    }
}