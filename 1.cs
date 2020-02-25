class HelloWorld
{
    private const string V = "比C++烦";

    static void Main()
    {
        string str1, str2,str3;
        //str1=System.Console.ReadLine();
        str3 = System.Console.ReadLine();
        str1 = V;
        str2 = "好恶心啊！";
        
        System.Console.WriteLine("我真的好烦C#{0}{1}", str2, str1+str3);

    }
}