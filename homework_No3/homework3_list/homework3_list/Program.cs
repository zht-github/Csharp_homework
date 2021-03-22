using System;

namespace homework3_list
{
    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> next;
        public Node(T t)
        {
            data = t;
        }
    } 
    public class MyList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public MyList()
        {
            head = tail = null;
        }
        public void add(T data)
        {
            if (head == null)
            {
                head = tail = new Node<T>(data);
            }
            else
            {
                Node<T> temp = new Node<T>(data);
                tail.next = temp;
                tail = temp;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> presentNode = head;
            while (presentNode != null)
            {
                action(presentNode.data);
                presentNode = presentNode.next;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            MyList<int> myList = new MyList<int>();
            for(int i = 0; i < 10; i++)
            {
                myList.add(i);
            }
            //输出表
            myList.ForEach(x => Console.Write(x+" "));
            Console.WriteLine("\n==========================");
            //求最大值
            int max = 0;
            myList.ForEach(x =>
            {
                if (max < x) max = x;
            });
            Console.WriteLine($"Max item is {max}");
            Console.WriteLine("=============================");
            //求最小值
            int min = 0;
            myList.ForEach(x =>
            {
                if (min > x) min = x;
            });
            Console.WriteLine($"Min item is {min}");
            Console.WriteLine("=============================");
            //求和
            int sum = 0;
            myList.ForEach(x =>
            {
                sum += x;
            });
            Console.WriteLine($"Sum item is {sum}");
            Console.WriteLine("=============================");
        }
    }
}
