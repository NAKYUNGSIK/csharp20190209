using System;

namespace HelloWorld
{
    class A { }
    class Program
    {
        int i; //멤버,필드, 인스턴스 변수
        static int j; //멤버, 변수, 클래스변수
        static void Main(string[] args) //멤버, 메소드
        {
            string name = "나경식";
            int k = 99;
            Console.WriteLine($"Hello {name}");
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Hello {0}{1}", name, k);
        }
    }
}
