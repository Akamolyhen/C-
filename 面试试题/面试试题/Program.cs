using System;

namespace 面试试题
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool num = Test(3, 3);
            Console.WriteLine(num);
            Console.ReadKey();
        }
        #region 递归实现1*（1+2）*（1+2+3）

        //static int Test2(int n)
        //{
        //    if (n == 1)
        //        return 1;
        //    else
        //    {
        //        int tem = 0;
        //        for (int i = 1; i <= n; i++)
        //        {
        //            tem += i;
        //        }
        //        return tem * Test2(n - 1);
        //    }

        //}
        #endregion

        #region x+y=n,x*y=m,求x,y

        //static bool Test(int n, int m)
        //{
        //    double ret1 = (n - Math.Sqrt((double)(n * n - 4 * m))) / 2;
        //    double ret2 = (n + Math.Sqrt((double)(n * n - 4 * m))) / 2;
        //    if (ret1 == (int)ret1 && ret2 == (int)ret2)
        //        return true;
        //    else
        //        return false;
        //}
        #endregion
    }
}
