using System;

namespace NullOperater
{
    class Program
    {
        static void Main()
        {
            //Nullable Type, a 가 NULL 을 허용한다는 의미
            int? a = null;
            //int b = a.Value; // a.Value 값 자체가 null 이므로 int? b 도 오류
            //Console.WriteLine("Value of b is {0}", b);
            int b;
            if (a.HasValue) b = a.Value;
            else b = 0;
            Console.WriteLine("Value of b is {0}", b);
            int c = a ?? 0;
            Console.WriteLine("Value of c is {0}", c);
            Console.ReadLine();
        }
    }}
