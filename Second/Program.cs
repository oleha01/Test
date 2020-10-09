using System;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter an array, each element separated by a comma");
            string s1 = Console.ReadLine();

            string[] numbers1 = s1.Split(',');

            int n = numbers1.Length;

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(numbers1[i]);
            }

            bool[] isRepeated = new bool[101];

            int res = -1;

            foreach(int el in arr)
            {
                if (!isRepeated[el])
                    isRepeated[el] = true;
                else
                {
                    res = el;
                    break;
                }

            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
