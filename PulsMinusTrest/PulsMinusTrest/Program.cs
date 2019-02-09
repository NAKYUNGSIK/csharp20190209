using System;
namespace PulsMinusTrest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(+3);
            Console.WriteLine(3 + 3);
            Console.WriteLine(3 + .3);
            Console.WriteLine("3" + "3");
            Console.WriteLine(3.5 + "3"); //3.5문자로 변환 후 concate ==> 3.53

            Console.WriteLine(!true);

            byte x = 10;
            Console.WriteLine(~x);

            Console.WriteLine(unchecked((short)50000));
        }
    }
}
