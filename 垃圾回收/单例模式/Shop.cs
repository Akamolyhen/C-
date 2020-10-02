using System;
namespace 单例模式
{
    public class Shop
    {
        public Shop()
        {
        }
        public void Buy()
        {
            /*Packdata pack = new Packdata();
            pack.Count -= 20;
            Console.WriteLine($"在商店消费后，目前背包的金币个数：{pack.Count}");*/
            //Packdata pack=Packdata.GetInstance();
            Packdata pack = Packdata.Instance;
            int count = pack.Count;
            count -= 20;
            //pack.Setcount(count);
            pack.Count = count;
            Console.WriteLine($"在商店消费后，目前背包的金币个数：{pack.Count}");
        }//商店花销
    }
}
