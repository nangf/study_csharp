

using System.IO;

namespace DirectoryInfoTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello, World!");*/

            DirectoryInfo info = new(@"D:\MC\.minecraft\versions");
            DirectoryInfo info2 = new(@"Z:\aaaaaa\bbbbb\ccccc\dddddd\eeee.txt");
            PrintAttr(info, info2);
            PrintExists(info, info2);
            PrintFullName(info, info2);
            PrintName(info, info2);
            PrintRoot(info, info2);
            PrintParent(info, info2);
        }

        public static void PrintExists(params DirectoryInfo[] info)
        {
            int index = 0;
            int count = info.Length;
            for(;index<count;++index)
            {
                Console.WriteLine(info[index].Exists);
            }
        }

        public static void PrintAttr(params DirectoryInfo[] info)
        {
            
            int count=info.Length;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(info[i].Attributes);
            }
        }

        public static void PrintFullName(params DirectoryInfo[] info)
        {
            
            int count = info.Length;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(info[i].FullName);
            }
        }
        public static void PrintName(params DirectoryInfo[] info)
        {
            int count = info.Length;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(info[i].Name);
            }
        }
        public static void PrintRoot(params DirectoryInfo[] info)
        {
            int count = info.Length;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(info[i].Root);
            }
        }
        public static void PrintParent(params DirectoryInfo[] info)
        {
            int count = info.Length;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(info[i].Parent);
            }
        }
    }
}