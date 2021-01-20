using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string>  isimler = new MyList<string>();
            isimler.Add("Yiğit Ş.");
            isimler.Add("Bozok");
            isimler.Add("Adem");
            isimler.Add("Hülya");
            isimler.Add("Uğur");
            Console.WriteLine(isimler.Length +" Kişi Database' e eklendi.");
            Console.WriteLine("-------");
            Console.WriteLine("Eklenen kişi isimleri:");

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
