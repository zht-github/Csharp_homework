using System;

namespace homework1__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your parameters and operator as:1 + 1");
            /*
            int para1 = Console.Read() - '0';
            Console.Read();
            char op = (char)Console.Read();
            Console.Read();
            int para2 = Console.Read() - '0';
            Console.WriteLine("{0} {1} {2}", para1, op, para2);
            */
            char[] charArray = Console.ReadLine().ToCharArray();
            Console.WriteLine("My input string's length is {0}", charArray.GetLength(0));
            int para1 = charArray[0] - '0';
            char op = charArray[2];
            int para2 = charArray[charArray.Length - 1] - '0';

            switch (op)
            {
                case '+': Console.WriteLine("result={0}!", para1 + para2); break;
                case '-': Console.WriteLine("result={0}!", para1 - para2); break;
                case '*': Console.WriteLine("result={0}!", para1 * para2); break;
                case '/': Console.WriteLine("result={0}!", para1 / para2); break;
                default: Console.WriteLine("Operation input error!"); break;
            }

        }
    }
}


