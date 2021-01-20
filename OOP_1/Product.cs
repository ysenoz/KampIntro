using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    class Product
    {
        public int Id { get; set; }//Primary key diyebiliriz.
        public string ProductName { get; set; }//foreig key diyebiliriz.
        public double UnitPrice { get; set; }  //foreig key diyebiliriz.
        public int CategoryId { get; set; }    //foreig key diyebiliriz.
        public int UnitsInStock { get; set; }  //foreig key diyebiliriz.

        //CRUD (CREATE-READ-UPDATE-DELETE)




    }
}
