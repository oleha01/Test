using System;

namespace TraineeEveryMatrix
{
    class Program
    {
        static int[] StringArrToInt(string[] stringArr)
        {
            int n = stringArr.Length;
            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                res[i] = int.Parse(stringArr[i]);
            }
            return res;
        }
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            string[] numbers1 = s1.Split(',');
            string[] numbers2 = s2.Split(',');

            int[] intNumbers1 = StringArrToInt(numbers1);
            int[] intNumbers2 = StringArrToInt(numbers2);

            int[] result = new int[intNumbers1.Length + intNumbers2.Length];

            int i = 0;
            int j = 0;

            for (; i < intNumbers1.Length && j < intNumbers2.Length;)
            {
                if (intNumbers1[i] <= intNumbers2[j])
                {
                    result[i + j] = intNumbers1[i];
                    i++;
                }
                else
                {
                    result[i + j] = intNumbers2[j];
                    j++;
                }
            }
            for (; i < intNumbers1.Length; i++)
                result[i + j] = intNumbers1[i];

            for (; j < intNumbers2.Length; j++)
                result[i + j] = intNumbers2[j];

            int n = intNumbers1.Length + intNumbers2.Length-1;
            i = 0;
            for (;i<n;i++)
                Console.Write("{0},", result[i]); 
            Console.Write("{0}", result[i]);
            Console.ReadKey();
        }
    }
}
