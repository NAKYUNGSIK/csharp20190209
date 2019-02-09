using System;

namespace NullOperater
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = null;
            object b = "abc";

            object c = a ?? b;
            Console.WriteLine(c);

            object d;

            if (a != null)
            {

                d = a;
            }
            else {

                d = b;
            }

            Console.WriteLine(d);

            object e;
            e = (a != null) ? a : d;

            Console.WriteLine(e);
        }
    }
}
