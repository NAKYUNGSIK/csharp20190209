using System;

namespace LogicalAnd
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("정상적인 AND:");

            if (Method1() & Method2())

                Console.WriteLine("Both methods returned true.");
            else
                Console.WriteLine("둘중 하나의 메소드는 false");

            Console.WriteLine("\n Short-circuit AND:");

            if (Method1() && Method2())
                Console.WriteLine("Both methods returned true.");
            else
                Console.WriteLine("둘중 하나으 메소드는 false");
                        
            Console.WriteLine("0x{0:x}", 0xf8 & 0x3f); // 0x38 

        }

        static bool Method1() {
            Console.WriteLine("메소드1...");
            return false;
        }

        static bool Method2()
        {
            Console.WriteLine("메소드2...");
            return true;
        }
        
    }
}
