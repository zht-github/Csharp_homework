using System;

namespace homework3_seive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要被筛法处理的数字： ");
            int range = int.Parse(Console.ReadLine());
            int[] myArr = new int[range - 1];
            for(int i = 2; i <= range; i++)
            {
                myArr[i - 2] = i;
            }
            for(int i = 2; i < range; i++)
            {
                for(int j = 0; j < myArr.Length; j++)
                {
                    if (myArr[j] == 0) continue;
                    if (myArr[j] % i == 0 && myArr[j] != i) myArr[j] = 0;
                }
            }
            Console.WriteLine("Prime numbers less than {0} is as follows:", range);
            int count = 0;
            foreach(int i in myArr)
            {
                if (i != 0)
                {
                    Console.Write(i+" ");
                    count++;
                    if (count % 5 == 0) Console.Write("\n");
                }
            }
        }
    }
}
