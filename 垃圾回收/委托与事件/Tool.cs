using System;
namespace 委托与事件
{
    //delegate是委托的关键字
    public delegate void DelGetResult(int num);
    public class Tool
    {
        public Tool()
        {
        }
        public void ShowResultSum(int num)
        {
            int a = 10;
            int sum = a + num;
            Console.WriteLine($"两个数的和为：{sum}");
        }
        public  void ShowResultMinus(int num)
        {
            int a = 20;
            int minus = a - num;
            Console.WriteLine($"两个数的差为：{minus}");
        }
        public void ShowResult(DelGetResult del)
        {
            if (del != null)
            {
                del(10);
            }
            else
            {
                Console.WriteLine("委托为空");
            }
        }
    }
}
