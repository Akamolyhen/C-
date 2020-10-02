using System;

namespace 单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.Buy();
            Level level = new Level();
            level.Passlevel();
            Console.ReadKey();
        }
    }
}
