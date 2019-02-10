using System;

namespace 매개변수
{
    class Program
    {
        private static void OnjSum(string title, params int[] num) {
            int sum = 0;
            Console.WriteLine("Sum of {0}", title);

            foreach (int i in num) sum += 1;

            Console.WriteLine("Sum :: {0}\n", num);
        }

        static void Main(string[] args)
        {
            int[] onjArray = new int[2] { 1, 2 };
            OnjSum("숫자하나", 1);
            OnjSum("숫자둘", 1, 2);
            OnjSum("숫자셋", 1, 2, 3);
            OnjSum("배열", onjArray);
        }
    }
}
