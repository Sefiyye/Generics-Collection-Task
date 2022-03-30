using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp33
{
    internal class Apple<U>
    {
        private U Vitamin;

        public Apple(U vita)
        {
            Vitamin = vita;
        }
        public override string ToString()
        {
            return $"Apple-in vitaminleri: {Vitamin}";
        }
    }
}
