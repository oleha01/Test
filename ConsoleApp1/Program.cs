using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hours = new string[25];
            string[] minutes = new string[61];

            int i = 0;
            for (; i < 10; i++)
            {
                hours[i] = '0'+i.ToString();
                minutes[i] = '0'+i.ToString();
            }

            for (; i < 25; i++)
            {
                hours[i] = i.ToString();
                minutes[i] = i.ToString();
            }

            for (;i<61;i++)
            {
                minutes[i] = i.ToString();
            }

            string res = "";

            i = 0;

            string time;
            for(;i<=24;i++)
            {
                for(int j=0;j<=60;j++)
                {
                    time = hours[i] + minutes[j];
                    int k = 0;
                    for (;k<time.Length/2;k++)
                    {
                        if (time[k] != time[time.Length - k - 1])
                            break;

                    }
                    if (k >= time.Length / 2)
                        res += hours[i] + ':' + minutes[j] + ' ';
                }
            }
            string[] Rezult = res.Split(' ');
            foreach (string el in Rezult)
                Console.WriteLine(el);
            Console.ReadKey();
        }
    }
}
