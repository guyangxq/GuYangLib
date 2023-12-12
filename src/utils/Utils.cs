using System.Text.Json.Serialization;

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
    /// <summary>
    /// 该类的总体介绍
    /// </summary>
    public static void SayHello()
    {
        Console.WriteLine("hello,我是谷洋的工具库");
    }
    public static void RangeLoop()
    {
        List<int> list=new List<int>(){1,2,3};
        foreach(var item in Enumerable.Range(0,10))
        {
            Console.WriteLine(item);
            list.Add(item);
        }
        foreach(var _ in list)
        {
            Console.WriteLine(list.Count);
        }
    }
}