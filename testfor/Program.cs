using System;

namespace testfor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,count=0;
            for(i=0;i<100;i++)
           {
           		if(i%5==0)
           		{
           			count++;

           		}

           }
           Console.WriteLine(count);
        }
    }
}
