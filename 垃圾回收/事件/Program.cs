using System;

namespace 事件//他的本质就是委托
{
    class Program
    {
        static void Main(string[] args)
        {
            Tool tool = new Tool();
            tool.Myevent += ShowSum;
            tool.Showevent();
            Console.ReadKey();
        }
        public static void ShowSum()
        {
            Console.WriteLine("the sum is 100");
        }
    }
}
