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

/*
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
*/

/*
//ArrayList 
using System;
using System.Collections;
public class SamplesArrayList
{
    public static void Main()
    {
        ArrayList onj = new ArrayList();
        //List<string> onj = new List<string>();
        onj.Add("Onj"); onj.Add("OracleJava"); onj.Add("Community");
        onj.Add("Onj2"); onj.Add("OracleJava2"); onj.Add("Community2");

        Console.WriteLine("onj List");
        Console.WriteLine(" Count: {0}", onj.Count);
        Console.WriteLine(" Capacity: {0}", onj.Capacity);
        Console.Write(" onj Values:"); PrintValues(onj);
        ArrayList onj2 = (ArrayList)onj.Clone();
        Console.Write(" onj2 Values:"); PrintValues(onj2);
    }
    public static void PrintValues(IEnumerable myList)
    {
        foreach (Object obj in myList) Console.Write("{0},", obj);
        Console.WriteLine();
    }
}
*/

/*
//STACK
using System;
using System.Collections;
public class MyStack
{
    public static void Main()
    {
        // Creates and initializes a new Stack.
        Stack myStack = new Stack();
        myStack.Push("OJC");
        myStack.Push("ASIA");
        myStack.Push("Thank You!");
        Console.WriteLine("myStack 의 건수:{0}", myStack.Count);
        //스택의 맨위 하나 꺼냄, 이제는 두개남음
        Console.WriteLine(myStack.Pop());
        //스택의 top 포인터가 가리키는 자료를 리턴, 스택에서 꺼내는것은 아님
        Console.WriteLine(myStack.Peek());

        PrintValues(myStack); //스택에 있는 두값을 출력
    }
    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write("{0} ", obj);
            Console.WriteLine();
    }
}
*/

/*
//HASHTABLE
using System;
using System.Collections;
using System.Collections.Generic;

class Example
{
    public static void Main()
    {
        Hashtable onj = new Hashtable(); //제너릴으로 수정시 아래와 같이 바꿔준다.
        //Dictionary<String, String> onj = new Dictionary<string, string>();

        onj.Add("김길동", "서울");
        onj.Add("홍길동", "광주");
        onj.Add("박길동", "부산");

        try
        {
            onj.Add("김길동", "서울");
        }
        catch
        {
            Console.WriteLine("키값 중복...");
        }
        Console.WriteLine("For key = \"name\", value = {0}.", onj["홍길동"]);
        onj["박길동"] = "제주";
        Console.WriteLine("For key = \"name\", value = {0}.", onj["박길동"]);

        if (!onj.ContainsKey("최길동"))
        {
            onj.Add("최길동", "하와이");
            Console.WriteLine("Value added for key = \"who\": {0}", onj["최길동"]);
        }
        Console.WriteLine();
        //출력순서를 확인하자.(입력된 순서로 나오는 것은 아님)
        foreach (DictionaryEntry d in onj)    //제너릴으로 수정시 아래와 같이 바꿔준다.
        //foreach (KeyValuePair<string, string> d in onj)
        {
            Console.WriteLine("Key = {0}, Value = {1}", d.Key, d.Value);
        }

        SortedList s = new SortedList(onj); //해시테이블 정렬하기위해 SoretedList에 넣음
        foreach (DictionaryEntry d in s) //키값이 정렬된 형식으로 출력
        {
            Console.WriteLine("Key = {0}, Value = {1}", d.Key, d.Value);
        }
    }
}
*/

/*
//연산자 오버로딩
using System;
namespace OperatorOverload1
{
    public class AddClass1
    {
        public int val;
        public static AddClass1 operator +(AddClass1 op1, AddClass1 op2)
        {
            AddClass1 obj = new AddClass1();
            obj.val = op1.val + op2.val;
            return obj;
        }
    }
    class Test
    {
        static void Main()
        {
            AddClass1 op1 = new AddClass1(); op1.val = 1;
            AddClass1 op2 = new AddClass1(); op2.val = 2;
            AddClass1 op3 = op1 + op2;
            Console.WriteLine("op1 + op2 = {0}", op3.val);
        }
    }
}
*/

//인덱스
/*
using System;
public class Animation
{
    private int total; //총 애니메이션 편수
    private string[] title; //각 볼륨당 제목
    private string distributor; //유통사
    private string date; //제작날짜
    private int price; //가격

    public Animation(int total, string distributor, string date, int price)
    {
        this.total = total; this.title = new string[total ];
        this.distributor = distributor;
        this.date = date; this.price = price;
    }
    //이부분에서 인덱서를 정의 한다. 이전 프로그램의 setTitle, getTitle이 인덱서로 대체됨,
    //결국 this라는 Property가 인덱서인 것이다.
public string this[int index] // Animation a= new Animation(); a[0] = “심청전”;
    {
        get { return title[index]; }
        set { title[index] = value; }
    }
    //제작사 정보를 읽어옴
    public string getDistributor() { return distributor; }
    //가격 정보를 읽어옴
    public int getPrice() { return price; }
    //총애니메이션의 수를 알아내는 메소드
    public int getTotal() { return total; }
}
class AniTest
{
    static void Main()
    {
        Animation ani = new Animation(5, "한국애니", "10-27-2004", 400000);
        ani[0] = "인어공주"; ani[1] = "신데렐라";
        ani[2] = "백설공주";
        ani[3] = "바보온달";
        ani[4] = "라이온킹";
        Console.WriteLine("배급사: {0}", ani.getDistributor());
        Console.WriteLine("가격: {0}", ani.getPrice());
        Console.WriteLine("----------------------------");
        for (int i = 0; i < ani.getTotal(); i++)
            {
            Console.WriteLine("Volume{0} : {1}", i, ani[i]);
        }
    }
}*/

/*
class Ojc<T> //일반화 클래스 정의
{
    //외부에서 접근못하도록 private으로 배열을 정의하고
    //배열의 값은 인덱스를 통해 다루도록 한다.
    //배열의 타입은 Ojc를 사용하는 시점에 정의 ==> Generic
    private T[] ojcArr = new T[10];
    //Generic을 이용하여 인덱서를 정의하자.
    public T this[int i]
    {
        get //R-VALUE
        {
            return ojcArr[i];
        }
        set //L-VALUE
        {
            ojcArr[i] = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Ojc<string> ojc1 = new Ojc<string>();
        ojc1[0] = "Hello, OJC";
        ojc1[9] = "나야, 나";
        //string s = ojc1[0];
        System.Console.WriteLine(ojc1[0]);
        System.Console.WriteLine(ojc1[9]);
        //System.Console.WriteLine(s);

        Ojc<int> ojc2 = new Ojc<int>();
        ojc2[0] = 999;
        //int i = ojc2[0];
        System.Console.WriteLine(ojc2[0]);
        //System.Console.WriteLine(i);
    }
}*/

/*
//1.예제
using System;
//일반화 클래스
class DataStore <T> {
private T[] s = new T[10];
public T this[int index]
{
    get
    {
        if (index < 0 || index >= s.Length)
            throw new IndexOutOfRangeException("Cannot store more than 10 objects");
        return s[index];
    }
    set
    {
        if (index < 0 || index >= s.Length)
            throw new IndexOutOfRangeException("Cannot store more than 10 objects");
        s[index] = value;
    }
}
}
class Program
{
    static void Main(string[] args)
    {
        DataStore<string> ds1 = new DataStore<string>();
        ds1[0] = "One";
        ds1[1] = "Two";
        ds1[2] = "Three";
        for (int i = 0; i < 3; i++)
            Console.WriteLine(ds1[i]);
        DataStore<int> ds2 = new DataStore<int>();
        ds2[0] = 1;
        ds2[1] = 2;
        ds2[2] = 3;
        for (int i = 0; i < 3; i++)
            Console.WriteLine(ds2[i]);
        //ds2[11] = 11;
    }
}
*/

/*
using System;
class DataStore
{
    private string[] strArr = new string[10]; // internal data storage
    public DataStore() { }
    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= strArr.Length)
                throw new IndexOutOfRangeException("Cannot store more than 10 objects");
            return strArr[index];
        }
        set
        {
            if (index < 0 || index >= strArr.Length)
                throw new IndexOutOfRangeException("Cannot store more than 10 objects");
                strArr[index] = value;
        }
    }
    public string this[string name]
    {
        get
        {
            foreach (string s in strArr)
            {
                if (s.ToLower() == name.ToLower())
                    return s;
            }
            return null;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        DataStore strStore = new DataStore();
        strStore[0] = "One";
        strStore[1] = "Two";
        strStore[2] = "Three";
        strStore[3] = "Four";
        Console.WriteLine(strStore["one"]);
        Console.WriteLine(strStore["two"]);
        Console.WriteLine(strStore["Three"]);
        Console.WriteLine(strStore["FOUR"]);
    }
}*/

/*
using System;
/// <summary>
/// Implements overloaded indexers.
/// </summary>
class OvrIndexer
{
    private string[] myData;
    private int arrSize;
    public OvrIndexer(int size)
    {
        arrSize = size;
        myData = new string[arrSize] ;
        for (int i = 0; i < size; i++)
        {
            //myData setting
            myData[i] = "empty";
    }
}
public string this[int pos]
{
    get
    {
        return myData[pos];
    }
    set
    {
        myData[pos] = value;
    }
}
public string this[string data]
{
    get
    {
        int count = 0;
        for (int i = 0; i<arrSize; i++)
        {
            if (data.Equals(this[i]))
            {
            count++;
            }
        }
        return count.ToString();
    }
    set
    {
        for (int i = 0; i<arrSize; i++)
        {
        if (myData[i] == data)
            {
                this[i] = value; 

            }
        }
    }
}
static void Main(string[] args)
{
    int size = 10;
    OvrIndexer myInd = new OvrIndexer(size);
    myInd[9] = "Some Value";
    myInd[3] = "Another Value";
    myInd[5] = "Any Value";
    myInd["empty"] = "no value";
    Console.WriteLine("\nIndexer Output\n");
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("myInd[{0}]: {1}", i, myInd[i]);
    }
    Console.WriteLine("\nNumber of \"no value\" entries: {0}", myInd["no value"]);
}
}*/

/*
#define SOUNDCARD // 이 부분을 지운 후 실행 해 보자
using System;
using System.Diagnostics;
class Test
{
    //Conditional Attribute인 경우 지정된 위치지정 파라미터가 정의 되어
    //있을 때 실행이 되는 것이다.
    [Conditional("SOUNDCARD")]
    static void print() { Console.WriteLine("도레미..."); }
    static void Main()
    {
        print();
    }
}*/

/*
using System;
using System.Runtime.InteropServices;
class Test
{
    //User32.dll 파일안의 MessageBox 함수를 불러와서 사용하는 예이다. DllImport
    //Attribute를
    //이용하여 사용할 코드가 포함되어 있는 DLL을 넘겨주고 extern 키워드를 통해
    //사용하려고 하는
    //메소드가 외부에 있음을 알린다. 이렇게 하면 닷넷 환경 밖에서 개발된 코드들도
    //C#안에서 쓸 수 있다.
[DllImport("User32.Dll")]
public static extern int MessageBox(int h, string m, string c, int type);
    static void Main() { MessageBox(0, "Hello!", "In C#", 0); }
}*/

/*
  //Attribute
using System;
[AttributeUsage(AttributeTargets.Class)]//class 위에 붙인다.
//[AttributeUsage(AttributeTargets.All )]//아무데나 위에 붙인다.
public class AdditionalInfoAttribute : Attribute  //Attribute를 상속받아라.
{
    string name; string update; string download;
    //생성자에 있는 두개의 인자는 위치지정 파라미터 이다.
    //즉 위치지정 파라미터는 클래스에 어트리뷰트를 붙일때 반드시 넘겨 줘야 한다.
    //항상 생성자에서 값을 넘겨 주게 되어 있으므로 name, update 인 경우 Property 에서
    //set 이 없다.
    public AdditionalInfoAttribute(string name, string update)
    {
        this.name = name; this.update = update;
    }
    public string Name { get { return name; } }
    public string Update { get { return update; } }
    public string Download
    {
        set { download = value; }
        get { return download; }
    }
}

namespace AttributeTest
{
    [AdditionalInfoAttribute("홍길동", "2018/10/1", Download = "http://ojc.asia")]
    class Test
    {
        static void Main()
        {
            Type type = typeof(Test);
            foreach (Attribute attr in type.GetCustomAttributes(true))
            {
                AdditionalInfoAttribute info = attr as AdditionalInfoAttribute;  //attr을 AdditionalInfoAttribute으로 형변환
                if (info != null)
                    Console.WriteLine("Name={0},Update Date={1},Download ={2}",
                    info.Name, info.Update, info.Download);
            }
        }
    }
}
*/

/*
//델리게이트(delegate)
using System;
public class Delegate1
{
    private delegate  int OnjSum(int i, int j); //1. 선언
    public static void Main(string[] args)
    {
        OnjSum myMethod = new OnjSum(Delegate1.Sum); //2. 생성, 메소드이름을 인자로
        //OnjSum myMethod = new OnjSum(Sum);            //2. 생성
        //OnjSum myMethod = Sum;                              //2. 생성
        Console.WriteLine("두수 합 : {0}", myMethod(10, 30));
    }
    static int Sum(int i, int j)
    {
        return i + j;
    }
}*/

/*
//델리게이트(delegate) 선언하지 않을시 리턴값있을시, Func(input파라메터 개수만큼, output파라메터 개수만큼)
using System;
public class Delegate1
{

    public static void Main(string[] args)
    {
        Func<int, int, int> myMethod = new Func<int,int,int>(Delegate1.Sum);
        Console.WriteLine("두수 합 : {0}", myMethod(10, 30));
    }
    static int Sum(int i, int j)
    {
        return i + j;
    }
}
*/

/*
//델리게이트(delegate) 선언하지 않고 리턴값 없을시, Action(input파라메터 개수만큼)
using System;
public class Delegate1
{
    public static void Main(string[] args)
    {
        //Action <int, int> myMethod = new Action<int, int> (Delegate1.Sum);
        Action<int, int> myMethod = Sum;  //new Action<int, int> (Delegate1)생략가능 
        myMethod.Invoke (10, 30);
        //myMethod(10, 30);
    }
    static void  Sum(int i, int j)
    {
        Console.WriteLine(i + j);
    }
}
*/
/*
using System;
delegate int SumDeli(int i, int j);
class DeliTest
{
    static void Main()
    {
//        SumDeli s1 = DeliTest.Sum1;
//        SumDeli s2 = new SumDeli(DeliTest.Sum2);
        SumDeli s1 = Sum1;
        SumDeli s2 = Sum2;

        S(s1);
        S(s2);
        //S(Sum1 );
        //S(Sum2);
    }
    //아래 메소드는 실제 할일(콜백)이 컴파일 타임에 결정되는 것이 아니라 런타임중에
    //인자로 넘어오는 델리게이트를 통해 결정된다. 이런 콜백의 구현은 델리게이트로
    static void S(SumDeli s)
    {
        Console.WriteLine(s(1, 2));
    }
    static int Sum1(int i, int j)
    {
        return i + j;
    }
    static int Sum2(int i, int j)
    {
        return i + j + 100;
    }
}*/

/*
//델리게이트 체인
using System;
using System.Collections.Generic;
using System.Text;
namespace deledatetest
{
    delegate void OnjDelegate(int a, int b);
    class MainApp
    {
        static void Plus(int a, int b) { Console.WriteLine("{0} + {1} = {2}", a, b, a + b); }
        static void Minus(int a, int b) { Console.WriteLine("{0} - {1} = {2}", a, b, a - b); }
        void Multiplication(int a, int b) { Console.WriteLine("{0} * {1} = {2}", a, b, a * b); }
        void Division(int a, int b) { Console.WriteLine("{0} / {1} = {2}", a, b, a / b); }

        static void Main()
        {
            MainApp m = new MainApp();
            //OnjDelegate CallBack = (OnjDelegate)Delegate.Combine(
            //new OnjDelegate(MainApp.Plus),
            //new OnjDelegate(MainApp.Minus),
            //new OnjDelegate(m.Multiplication),
            //new OnjDelegate(m.Division));

            OnjDelegate CallBack = new OnjDelegate(MainApp.Plus);
            CallBack += new OnjDelegate(MainApp.Minus);
            CallBack += new OnjDelegate(m.Multiplication);
            CallBack += new OnjDelegate(m.Division);

            CallBack(4, 3);
        }
    }
}
*/
/*
//델리게이트 이용한 버블정렬
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication24
{
    //우리가 만든 버블 소트기
    delegate bool OjcDeligate(object obj1, object obj2);
    class OjcSorter
    {
        //obj는 정렬 대상, 정렬의 타겟
        //deli는 뒤집을지 말지를 결정하는 메소드를 참조하는 델리게이트
        public static void BubbleSort(object[] obj, OjcDeligate deli)
        {
            object tmp;
            for (int i = 0; i < obj.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    //사용자가 작성한 정렬의 기준이되는 메소드를 호출하여 뒤짚을지를 결정
                    //비교대상 둘중 i는 뒤에 있는것, j는 앞에 있는것
                    if (deli(obj[j], obj[i]))
                    {
                        tmp = obj[i];
                        obj[i] = obj[j];
                        obj[j] = tmp;
                    }
                }
            }
        }
        //----------------------------------------------------------------------------------------
        class Dog
        {
            string name;
            public Dog(string name)
            {
                this.name = name;
            }
            public static bool MySort(object d1, object d2)
            {
                //이름순 오름차순정렬을 위해
                //앞에 있는 d1.name이 크면 뒤집으라고 true를 리턴
                //return String.Compare(d1.ToString(), d2.ToString()) > 0 ? true : false;
                //return ((((Dog)d1).name.CompareTo(((Dog)d2).name) > 0) ? true : false); 
                return ((((Dog)d1).name.CompareTo(((Dog)d2).name) < 0) ? true : false); //내림차순정렬

            }
            public override String ToString()
            {
                return "Dog : " + name;
            }
        }
        //--------------------------------------------------------------------------------------
        class Emp
        {
            string name;
            int sal;
            public Emp(string name, int sal)
            {
                this.name = name;
                this.sal = sal;
            }
            public static bool MySort(object e1, object e2)
            {
                //급여순 오름차순정렬을 위해
                //앞에 있는 e1.sal이 크면 뒤집으라고 true를 리턴
                //return ((((Emp)e1).sal > ((Emp)e2).sal) ? true : false);
                return ((((Emp)e1).sal < ((Emp)e2).sal) ? true : false); //내림차순정렬
            }
            public override String ToString()
            {
                return "Emp : " + name + ", " + sal;
            }
        }
        //---------------------------------------------------------------------------------
        class Program
        {
            static void Main(string[] args)
            {
                Dog[] d = new Dog[4];
                d[0] = new Dog("멍멍이"); d[1] = new Dog("푸들이");
                d[2] = new Dog("진도이"); d[3] = new Dog("삽살이");
                OjcDeligate deli = new OjcDeligate(Dog.MySort);
                //d:정렬대상, ojcDeligate:뒤집을기준을정의한 메소드를 참조하는 델리게이트
                OjcSorter.BubbleSort(d, deli);
                Console.WriteLine("<<<<<<<<< Dog 정렬된 후 >>>>>>>");
                foreach (Dog dog in d)
                {
                    Console.WriteLine(dog);
                }
                Console.ReadLine();
                Emp[] e = new Emp[4];
                e[0] = new Emp("홍길이", 900); e[1] = new Emp("남길이", 800);
                e[2] = new Emp("오라클자바커뮤니티", 5000); e[3] = new Emp("김길동", 100);
                deli = new OjcDeligate(Emp.MySort);
                //e:정렬대상, ojcDeligate:뒤집을기준을정의한 메소드를 참조하는 델리게이트
                OjcSorter.BubbleSort(e, deli);
                Console.WriteLine("<<<< Emp 급여순 정렬된 후 >>>>");
                foreach (Emp emp in e)
                {
                    Console.WriteLine(emp);
                }
            }
        }
    }
}
*/

/*
using System;
namespace ConsoleApplication11
{
    class Program
    {
        delegate int Calc(int i, int j);
        static void Main(string[] args)
        {
            Calc c = new Calc(MySum); //이 델리게이트는 이름있는 외부 메소드를 참조
            Console.WriteLine("1+2={0}", c(1, 2));
            //Calc c1 = (i, j) => i + j;
            Calc c1 = delegate (int i, int j) //델리게이트를 이용한 익명 메소드
            {
                return i + j;
            };
            Console.WriteLine("3+4={0}", c1(3, 4));
        }
        static int MySum(int i, int j)
        {
            return i + j;
        }
    }
}
*/

/*
//C# 이벤트 : System.EventHandler 델리게이트를 통한 이벤트 처리
using System;
namespace ConsoleApplication1
{
    //이벤트 게시자 클래스, 이벤트를 발생시키는 객체
    class EventPublisher
    {
        //public delegate void MyEventHandler(); //이벤트처리를위한델리게이트정의
        //public event MyEventHandler MyEvent; //이벤트 정의

        public event EventHandler MyEvent; //이벤트 정의

        public void Do()
        {
            //이벤트 가입자가 있는지 확인, 만약 구독자가 존재하는지 확인안하려면
            // public event MyEventHandler MyEvent = delegate { }; 라고 하면된다.
            //if (MyEvent != null) { MyEvent(); }//이벤트 발생 }
            //MyEvent?.Invoke(); //null이 아니면.. 위와 같다.

            if (MyEvent != null)
            {
                MyEvent(null, null); //이벤트 발생
            }

        }
    }

    //구독자 클래스
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            //C#1.0 에서의 이벤트에 가입하는 방법
            p.MyEvent += new EventHandler(doAction);
            //C#2.0 이상에서 이벤트에 가입하는 방법
            p.MyEvent += doAction;
            //C#2.0 이상에서 delegate 를 이용한 무명함수로 이벤트에 가입하는 방법
            p.MyEvent += delegate (object sender, EventArgs e)
            {
                Console.WriteLine("MyEvent 라는 이벤트 발생");
            };
            //C#3.0 이후 람다식을 이용한 무명함수로 이벤트에 가입하는 방법
            p.MyEvent += (sender, e) =>
            {
                Console.WriteLine("MyEvent 라는 이벤트 발생");
            };
            p.Do();
        }
        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent 라는 이벤트 발생");
        }
    }
}

*/

/*
//이벤트가 발생할 때 데이터를 넘기는 예제를 작성해 보자.
using System;
namespace ConsoleApplication1
{
    //이벤트 발생시 넘길 데이터(System.EventArgs 에서 파생)
    class EventPublisherArgs : EventArgs
    {
        public string myEventData;
        public EventPublisherArgs(string myEventData)
        {
            this.myEventData = myEventData;
        }
    }
    //이벤트 게시자 클래스
    class EventPublisher
    {
        public event EventHandler MyEvent; //이벤트 정의

        public void Do()
        {
            //이벤트 가입자가 있는지 확인
            if (MyEvent != null)
            {
                EventPublisherArgs args = new EventPublisherArgs("데이터");
                MyEvent(this, args); //이벤트 발생
            }
        }
    }
    //구독자 클래스
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            p.MyEvent += new EventHandler(doAction);
            p.Do();
        }
        //MyEvent 이벤트가 발생하면 호출되는 메서드
        //EventPublisherArgs 가 이벤트 발생시 넘어오는 데이터이다.
        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent 라는 이벤트 발생...");
            Console.WriteLine("이벤트 매개변수 : " + ((EventPublisherArgs) e).myEventData);
        }
    }
}
*/

/*
//사용자로부터 콤마로 구분해서 숫자들을 입력받아서 짝수일 때만 이벤트가 발생되어 아래와 같이 결과를 출력 
using System; 
namespace EventTest
{
    delegate void MyDelegate(int i);

    class EventPublsher
    {
        public event MyDelegate ClapEvent;

        public void Clap(int num)
        {
            if (num % 2 == 0) ClapEvent(num);
        }
    }

    class EventSub
    {
        public static void Main()
        {
            EventPublsher p = new EventPublsher();

            p.ClapEvent += new MyDelegate(Caller);
                       
            int[] iArr = Array.ConvertAll(

                        (Console.ReadLine()).Split(','),

                        i => int.Parse(i));

            foreach (int i in iArr)
            {
                p.Clap(i);
            }

        }

        static void Caller(int num)
        {
            Console.WriteLine("{0} : 짝~", num);
        }

    }

}
*/
/*
//Action 델리게이트를 이용하여 작성 
using System;
namespace EventTest
{
    class EventPublsher
    {
        public event Action<int> ClapEvent;

        public void Clap(int num)
        {
            if (num % 2 == 0) ClapEvent(num);
        }

    }

    class EventSub
    {
        public static void Main()
        {
            EventPublsher p = new EventPublsher();
            p.ClapEvent += new Action<int>(Caller);

            int[] iArr = Array.ConvertAll(
                       (
                        Console.ReadLine()).Split(','),
                        i => int.Parse(i)
                        );

            foreach (int i in iArr)
            {
                p.Clap(i);
            }
        }

        static void Caller(int num)
        {
            Console.WriteLine("{0} : 짝~", num);
        }

    }

}
*/

/*
//[델리게이트, 람다식을 이용한 익명메소드 구현]
using System;
namespace ConsoleApplication11
{
    class Program
    {
        delegate int Calc(int i, int j);
        static void Main(string[] args)
        {
            //Func<int, int, int> c = MySum;
            //Calc c = MySum;
            Calc c = new Calc(MySum); //이 델리게이트는 이름있는 외부 메소드를 참조
            Console.WriteLine("1+2={0}", c(1, 2));
            Calc c1 = delegate (int i, int j) //델리게이트를 이용한 익명 메소드
            {
                return i + j;
            };
            Console.WriteLine("3+4={0}", c1(3, 4));
            Calc c2 = (int a, int b) => a + b;
            Console.WriteLine("3+4={0}", c2(3, 4));
            // “형식 유추(Type Inference)”라고 해서 매개변수의 형식을 제거할 수 있다.
            // (델리게이트의 선언 코드로부터 형식을 유추함)
            Calc c3 = (a, b) => a + b;
            Console.WriteLine("3+4={0}", c3(3, 4));
        }
        static int MySum(int i, int j)
        {
            return i + j;
        }
    }
}*///[델리게이트 선언없이 Func 이용, 람다식을 이용한 익명메소드 구현]
using System;
namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            // (델리게이트의 선언 코드로부터 형식을 유추함)
            Func<int,int,int> c3 = (a, b) => a + b;
            Console.WriteLine("3+4={0}", c3(3, 4));
        }
        static int MySum(int i, int j)
        {
            return i + j;
        }
    }
}
