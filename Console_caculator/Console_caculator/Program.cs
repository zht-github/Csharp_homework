using System;

namespace Console_caculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your parameters and operator as:1 + 1 \n 请一定用空格隔开不然识别不了！");
            /*
            int para1 = Console.Read() - '0';
            Console.Read();
            char op = (char)Console.Read();
            Console.Read();
            int para2 = Console.Read() - '0';
            Console.WriteLine("{0} {1} {2}", para1, op, para2);
            */
            char[] opArray = new char[] { ' ' };
            string[] arr = Console.ReadLine().Split(opArray);
            double para1 = double.Parse(arr[0]);
            char op = arr[1].ToCharArray()[0];
            double para2 = double.Parse(arr[2]);

            switch (op)
            {
                case '+': Console.WriteLine("result={0}", para1 + para2); break;
                case '-': Console.WriteLine("result={0}", para1 - para2); break;
                case '*': Console.WriteLine("result={0}", para1 * para2); break;
                case '/': Console.WriteLine("result={0}", para1 / para2); break;
                default: Console.WriteLine("Operation input error!"); break;
            }

        }
    }
}
