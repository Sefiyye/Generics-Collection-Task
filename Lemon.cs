using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp33
{
    internal class Lemon<U>
    {
        private U Vitamin;

        public Lemon(U vita)
        {
            Vitamin = vita;
        }
        public override string ToString()
        {
            return $"Limon-un vitaminleri: {Vitamin}";
        }
    }
}
