using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>//generic yazarken T type şeklinde yazılır.Kural değil.
    {
        T[] items;
        public MyList()//ctor tab ile yapıldı.Constructor deniyor.Aslında metotdur.
            //Classı newlersen otomatik çalışır.Efsane!!
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//diziye ekleme yapıldığında referans kaybolmasın diye saklıyoruz.

            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Length 
        {
            get { return items.Length; }
        }

        public T[] Items 
        {
            get { return items; }
        }
    }
}
