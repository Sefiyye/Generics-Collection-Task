using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp33
{
    internal class BasketList<U>
    {
        public U[] Fruits;
        public int Count;
        public int getCount { get { return Fruits.Length; } }

        public BasketList()
        {
            Fruits = new U[0];
        }
        public U[] getFruits()
        {
            return Fruits;
        }
        public void Add(U meyve)
        {
            Array.Resize(ref Fruits, Fruits.Length + 1);
            Fruits[Fruits.Length - 1] = meyve;
        }
        
    }
}
