using System;

namespace ConsoleApp2
{
    class Tester
    {
        private int m = 88, n= 99;

//        Tester(){
//            this.m = 0; this.n = 0;
//        }
        
       // 위 기본생성자의 의미를 포함하고 있다.
        Tester(int m = 0, int n= 0) {

            this.m = m; this.n  = n;
        }

        //선택적 매개변수.. i,j 매개변수 없이 호출되면 i, j에 0이 대입
        static int Sum(int i = 0, int j = 0) {

            return i + j;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1,2));
            Console.WriteLine(Sum(j:1));
            Console.WriteLine(Sum());

//            Tester t1 = new Tester();
//            Console.WriteLine("m={ 0}, n={1}", t1.m , t1.n );

            Tester t2 = new Tester(1,2);
            Console.WriteLine("m={0},  n={1}", t2.m, t2.n);

        }

    }

}
