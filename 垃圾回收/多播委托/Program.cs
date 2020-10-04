using System;

namespace 多播委托
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageCenter center = new MessageCenter();
            DelMessage del = new DelMessage(ShowmusicMessage);
            del += ShownormalMessage;
            del += ShownewsMessage;
            center.ShowMessage(del);
            Console.ReadKey();
        }
        public static void ShownormalMessage()
        {
            Console.WriteLine("正在开始播放日常广播");
        }
        public static void ShowmusicMessage()
        {
            Console.WriteLine("正在开始播放音乐广播");
        }
        public static void ShownewsMessage()
        {
            Console.WriteLine("正在开始播放新闻广播");
        }
    }
}
