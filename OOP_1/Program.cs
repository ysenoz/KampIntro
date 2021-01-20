using System;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            
            //PascalCase    CamelCase
            //Case Sensitive(küçük-büyük harf duyarlı.)
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            /*int sayi = 100;
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi);*/

            //int-double-bool.. değer tiptir.
            //diziler-classlar-abstrack classlar- interfaceler referans tiptir.
            
        }
    }
}
