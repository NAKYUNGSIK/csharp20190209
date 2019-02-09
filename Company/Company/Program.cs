using System;

namespace Company
{
/*    class Emp {
        string name;
        void GotoOffice() { }
    }
*/
        class Emp { }
        class Programmer : Emp { }  // Emp 클래스 상속

    class EmpTest {

        static void Main() {
            Emp e = new Emp();
            Programmer p = new Programmer();
            Emp e1 = p as Emp;   // p를 Emp로 형변환 (상위타입 형변환은 된다) 변환안될시 null값 반환.
            Emp e2 = (Emp)p;  // 위와 같은데 아닐시 에러나니까 쓰지 말라..
/*
            if (p is Emp)
            {
                Console.WriteLine("Programmer is Emp");

            }
            else
            {
                Console.WriteLine("Programmer is not Emp");
            }
*/
        }

    }
        
}
