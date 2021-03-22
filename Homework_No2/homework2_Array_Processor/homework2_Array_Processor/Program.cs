using System;

namespace homework2_Array_Processor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your arrray elements divided with \' \':");
            string[] stringArr = Console.ReadLine().Split(" ");
            int[] intArr = new int[stringArr.Length];
            for(int i = 0; i < stringArr.Length; i++)
            {
                intArr[i] = int.Parse(stringArr[i]);
            }
            ArrayProcessor myProcessor = new ArrayProcessor(intArr);

        }
    }
    class ArrayProcessor
    {
        private int[] arr;
        public ArrayProcessor(int[] arr)
        {
            this.arr = arr;
            initialize();
        }
        private void initialize()
        {
            DoProcess();
        }
        private void DoProcess()
        {
            int min = arr[0], max = arr[0], sum = 0;
            foreach(int i in arr)
            {
                if (min > i) min = i;
                if (max < i) max = i;
                sum += i;
            }
            Console.WriteLine("Max element in this arr is {0}; \nMin element in this arr is {1};\nSum of this arr is {2}", max, min, sum);
        }
    }
}

