/*
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)//方法的说明，要求返回void或int；且要么无参，要么接收一个字符串数组
        {
            string str1,str2,str3;//变量使用camelCase风格（除第一个单词外，其他每个单词的首字母都要大写）
            Console.Write("你的名字是：");
            str3=System.Console.ReadLine();
            str2="程锦昊是：";
            str1=Console.ReadLine();
           Console.WriteLine(str2+str1);
           int value;
           char character;
           value=Console.Read();
           character=(char) value;
           Console.WriteLine(character);

        }
    }
}
*/
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_16
{
    public class Program
    {
        public static void Main()
        {
            string firstName;
            string lastName;
            string str1="大炮几秒钟",str2="爱操你老公";

            System.Console.WriteLine("Hey you!");

            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();

            System.Console.WriteLine(
                "Your full name is {0}{1}.",firstName,lastName);
            System.Console.WriteLine($"Your full name is {firstName}{lastName} say："+$"{str1}\t{str2}");
        }
    }
}
