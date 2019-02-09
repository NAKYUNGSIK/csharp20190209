using System;

namespace TypeCastExample1
{
    class Program
    {
        public static void Main()
        {
            short a = 10;   // system.int16 = short
            int b = a;       // system.int32 = int
            int c = 50000;
            try
            {
                short d = checked((short)c);  //형변환시 overflow가 발행체크
                Console.WriteLine("Short : {0})", d);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

            }
            
        }
    }
}
