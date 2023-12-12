namespace GuyangLib;
public class Utils
{
    public static void Info()
    {
        Console.WriteLine("这个类里集合了很多便捷的工具方法");
    }
    public static int GetRandomNum()
    {
        return new Random().Next(0,10);
    }
    public static void SayHello()
    {
        Console.WriteLine("hello,我是谷洋的工具库");
    }
}