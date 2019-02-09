using System;
namespace while_LoopTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요. ");
            string str = Console.ReadLine();
            int m = 0;
            bool parsed = Int32.TryParse(str, out m);  //스트링을 int로 변환... 변환못할시 bool = false 변환시 m 변수로 받음....
            if (!parsed)
            {
                Console.WriteLine("숫자도 입력 못하세요!!");
                Environment.Exit(0);
            }
            int i = 0, sum = 0;
            while (i <= m)
            {
                if (i % 2 == 0) sum += i;
                i++;
            }
            Console.WriteLine("1부터 {0}까지의 짝수합 {1}", m, sum);
            i = 0; sum = 0;
            do
            {
                if (i % 2 == 0) sum += i;
                i++;
            } while (i <= m);
            Console.WriteLine("1부터 {0}까지의 짝수합 {1}", m, sum);
            sum = 0;
            for (i = 0; i <= m; i++)
            {
                if (i % 2 == 0) sum += i;
            }
            Console.WriteLine("1부터 {0}까지의 짝수합 {1}", m, sum);
        }
    }
}