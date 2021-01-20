using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    class ProductManager//Operasyon ismi, Operasyonlar CRUD içerir.
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+ " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public int Topla(int sayi, int sayi2)
        {
            return sayi + sayi2;
        }

       /* public void BiseyYap(int sayi)
        {
            sayi = 99;// değer tip gönderildiği için bağlantı kesilir. 
       o yüzden ilk gönderilen 100 döndürülür

        }*/
    }
}
