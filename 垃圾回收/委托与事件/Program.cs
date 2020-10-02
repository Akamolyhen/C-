using System;

namespace 委托与事件
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tool tool = new Tool();
            tool.ShowResultSum();
            tool.ShowResultMinus();*/
            Tool tool = new Tool();
            DelGetResult del = tool.ShowResultMinus;
            del += tool.ShowResultSum;
            tool.ShowResult(del);
            Console.ReadKey();
        }
    }
}
