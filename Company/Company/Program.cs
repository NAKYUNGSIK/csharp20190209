using System;

namespace Company
{
    class Emp {
        string name;
        void GotoOffice() { }
    }

    class Programmer : Emp { }  // Emp 클래스 상속

    class EmpTest {

        static void Main()
        {
            Programmer p = new Programmer();

            if (p is Emp)
            {
                Console.WriteLine("Programmer is Emp");

            }
            else
            {
                Console.WriteLine("Programmer is not Emp");
            }

        }

    }
        

}
