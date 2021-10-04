using System;

namespace Task._1___7ye_bolunme
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 37;
            if (num%7==0)
            {
                Console.WriteLine($"{num} 7 ye bolunur");
            }
            else
            {
                int remainder = num % 7;
                if (remainder>3)
                {
                    while (num%7!=0)
                    {
                        num++;
                    }
                }
                else
                {
                    while (num%7!=0)
                    {
                        num--;
                    }
                }
                Console.WriteLine(num);
            }
        }
    }
}
