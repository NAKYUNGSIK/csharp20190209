using System;

namespace 사칙연산
{
    class Program
    {
        static void Main(string[] args)
        {
      
            int i = 5;
            Console.WriteLine("입력숫자 : {0} ",i);

            int m;
            while (i <= 5)
            {
                m = (2 * i) - 1;
                Console.Write(m + " ");
                i++;
            }

        }
    }
}
