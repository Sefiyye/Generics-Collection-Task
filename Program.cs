using System;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pineapple<string> pineapple = new Pineapple<string>("C,B6," );
            Apple<string> apple = new Apple<string>("E,B1,B6,C");
            Lemon<string> lemon = new Lemon<string>("C,B6");
            Console.WriteLine("Meyveler ve vitaminleri: ");
            Console.WriteLine(pineapple);
            Console.WriteLine(apple);
            Console.WriteLine(lemon);

            Console.WriteLine("\n ");
            BasketList<string> basketlist = new BasketList<string>();

            basketlist.Add("Pineapple");
            basketlist.Add("Apple");
            basketlist.Add("Lemon");
            basketlist.Add("Pear");
            basketlist.Add("Banana");
            basketlist.Add("Orange");

 
            
            Console.WriteLine("Meyveler: ");
            foreach (var item in basketlist.getFruits()) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
