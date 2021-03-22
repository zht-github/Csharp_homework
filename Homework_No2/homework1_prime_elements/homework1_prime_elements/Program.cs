using System;
using System.Collections.Generic;

namespace homework1_prime_elements
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input your number.");
            int num = int.Parse(Console.ReadLine());
            var myFinder = new PrimeFinder(num);
            Console.WriteLine("Prime elements of number {0} is as follows:", num);
            foreach(int i in myFinder.Mylist.ToArray())
            {
                Console.Write(i + " ");
            }
        }
    }
    class PrimeFinder
    {
        private int number;
        public PrimeFinder(int number)
        {
            this.Mylist = new List<int> { };
            this.number = number;
            FindPrime();
        }
        public List<int> Mylist { get; }
        private void FindPrime()
        {
            if (number == 1) return;
            for (int i = 2; i <= number ; i++)
            {
                if (number % i == 0)
                {
                    Mylist.Add(i);
                    number /= i;
                    break;
                }
            }
            FindPrime();
        }
    }
}
