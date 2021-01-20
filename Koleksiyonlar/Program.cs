using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"Ygt","Snz","Adem","Bozok" };

            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
                
            }
            Console.WriteLine("------------");

            List<string> isimler2 = new List<string>();//kolleksiyonlar genişletebilir.
            isimler2.Add("Yiğit");
            
        }
    }
}
