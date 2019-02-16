/*using System;
namespace Shallow_Copy { 
    class CreditCard
    {
        public string name;
    }
    class Customer
    {
        public int age;
        public CreditCard card;
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
    }
    class ArrayTest
    {
        static void Main()
        {
            Customer c1 = new Customer();
            c1.age = 20;
            c1.card = new CreditCard();
            c1.card.name = "비씨카드";
            Customer c2 = (Customer)c1.ShallowCopy();
            c2.card.name = "BC카드";
            Console.WriteLine("c1.card.name = " + c1.card.name);
            Console.WriteLine("c2.card.name = " + c2.card.name);
        }
    }
}
*/
/*
using System;
namespace Deep_Copy
{
        class CreditCard
        {
            public string name;
        }
        class Customer : ICloneable
        {
            public int age;
            public CreditCard card;
            public object Clone()
            {
                Customer c = new Customer();
                c.age = this.age;
                c.card = new CreditCard();
                c.card.name = this.card.name;
                return c;
            }
        }
        class ArrayTest
        {
            static void Main()
            {
                Customer c1 = new Customer();
                c1.age = 20;
                c1.card = new CreditCard(); c1.card.name = "비씨카드";
                Customer c2 = (Customer)c1.Clone();
                c2.card.name = "BC카드";
                Console.WriteLine("c1.card.name = " + c1.card.name);
                Console.WriteLine("c2.card.name = " + c2.card.name);
            }
        }
}*/

/* 일반화클래스
using System;
using System.Collections.Generic;
using System.Text;
namespace GenericArray
{
    class MyArray<T> // T 형은 매개변수
    {
        private T[] onj;
        //onj 배열을 초기화
        public MyArray(int size) { onj = new T[size]; }
        // onj의 배열에 데이타를 저장한다.
        public void SetElement(int index, T value)
        {
            onj[index] =
value;
        }
        // onj배열에 해당 index 데이터를 반환
        public T GetElement(int index, T value) { return onj[index]; }
        // onj의 모든 요소를 출력한다.
        public void PrintElements()
        {
            foreach (T o in onj) { Console.WriteLine(o); }
        }
    }
    class MainApp
    {
        public static void Main(string[] args)
        {
            //int 형을 매개 변수로 MyArray<T>의 객체를 생성.
            MyArray<string> array = new MyArray<string>(4);
            array.SetElement(0, "OnjOracleJava"); array.SetElement(1, "OracleJava Commmunity");
           
            array.SetElement(2, "onjprogramming.co.kr"); array.SetElement(3,
           "oraclejavanew.kr");
            array.PrintElements();
        }
    }
}*/

/*//일반화메소드using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMethod
{
class MainApp
{
  static T[] GetArray<T>(int size, T val)
  {
      T[] array = new T[size];
      for (int i = 0; i < size; i++) { array[i] = val; }
      return array;
  }
  static void Main(string[] args)
  {
      string[] str_array = GetArray<string>(3, "오라클자바커뮤니티,오라클자바커뮤니티");
      foreach (string s in str_array) Console.WriteLine(s);
      int[] int_array = GetArray<int>(3, 999);
      foreach (int i in int_array) Console.WriteLine(i);
  }
}
}*/

//아래 예제는 int형 스택, string형 스택을 각각 구현했다.
//이를 일반화 시켜 Generic으로 Stack3 클래스를 구현하고 메인을 적절히 수정하여 테스트 하세요.
//(코드를 추가 하세요)

using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication6
{
    class Stack1
    {
        int top = 0;
        int[] ar = new int[10];

        public void Push(int obj)
        {
            ar[top] = obj;
            top++;
        }

        public int Pop()
        {
            top--;
            return ar[top];
        }
    }
       
    class Stack2
    {
        int top = 0;
        string[] ar = new string[10];
        public void Push(string obj)
        {
            ar[top] = obj;
            top++;
        }

        public string Pop()
        {
            top--;
            return ar[top];
        }
    }
       
    class StackTest
    {
        static void Main()
        {
            Stack1 s1 = new Stack1();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);

            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());

            Stack2 s2 = new Stack2();
            s2.Push("KOREA");
            s2.Push("대한민국");
            s2.Push("서울");

            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());

        }
    }
}
