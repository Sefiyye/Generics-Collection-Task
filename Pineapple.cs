using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp33
{
    internal class Pineapple<U>
    {
        private U Vitamin;

        public Pineapple(U vita)
        {
            Vitamin = vita;
        }
        public override string ToString()
        {
            return $"Pineapple-in vitaminleri: {Vitamin}";

        }
    }
}
