/*
using System;
namespace Lambda
{
    class Program
    {
        //delegate int Sum(int[] arg);
        static void Main(string[] args)
        {
                //Sum sumdeli = (arg) => {
                Func<int[],int>sumdeli = (arg) => {

                int mySum = 0;
                foreach (int i in arg) mySum += i;
                return mySum;
            };
            int sum = sumdeli(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("1+2+3+4+5=" + sum);
        }
    }
}*/

/*
using System;
using System.Linq;
using System.Collections.Generic;
namespace from
{
    class Onj
    {
        
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var onjQuery1 = num.Where(i=> i % 2 == 1);
            //var onjQuery1 = from k in num
            //                where k % 2 == 1
            //               orderby k  
            //                select k;
            foreach (int i in onjQuery1)
                Console.WriteLine("홀수 : {0}", i);
            // Query Expression.
            IEnumerable<int> onjQuery2 = //query variable
            from n in num //데이터소스 및 범위변수(필수)
 where n > 3 // 생략가능
 orderby n descending // 내림차순정렬(생략가능)
 select n; //select or group으로 끝나야 한다.
            foreach (int i in onjQuery2)
            {
                Console.WriteLine(i);
            }
        }
    }
}*/
/*
using System;
using System.Threading;
public class ThreadTest
{
    public void FirstWork()
    {
        for (int i = 0; i < 100; i++)
        {
            Thread.Sleep(100); //밀리세컨드 단위. 1초단위
            Console.Write("F{0} ", i);
        }
    }
    public void SecondWork()
    {
        for (int i = 0; i < 100; i++)
        {
            Thread.Sleep(100);
            Console.Write("S{0} ", i);
        }
    }
    //[MTAThread] //attribute
    public static void Main()
    {
        ThreadTest t = new ThreadTest();
        //Thread는 생성자에 ThreadStart형 Delegate를 인자로 받는다.ThreadStart형 생략가능
        Thread first = new Thread(t.FirstWork);
        Thread second = new Thread(new ThreadStart(t.SecondWork));
        first.Priority = ThreadPriority.Lowest;
        second.Priority = ThreadPriority.Highest;
        first.Start(); second.Start();
    }
}*/
/*
// C# 멀티 쓰레드(Suspend, Resume)
using System;
using System.Threading;
public class ThreadTest2
{
    public bool sleep = false;
    public void FirstWork()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine("F{0}", i);
            if (i == 5)
            {
                sleep = true;
                Console.WriteLine("");
                Console.WriteLine("first 쉼...");
                Thread.CurrentThread.Suspend();
            }
        }
    }
    public static void Main()
    {
        ThreadTest2 t = new ThreadTest2();
        Thread first = new Thread(new ThreadStart(t.FirstWork));
        first.Start();
        while (t.sleep == false) { }
        Console.WriteLine("first를 깨웁니다...2초후 깨어 납니다.");
        Thread.Sleep(2000);
        first.Resume();
    }
}
*/
/*
// C# 멀티 쓰레드(Interrupt를 이용한 쓰레드 종료방법)
using System.Threading;
using System;
namespace ThreadInterrupt
{
    class Program
    {
        public static Thread sleeperThread;
        public static void Main(string[] args)
        {
            sleeperThread = new Thread(ThreadToSleep);
            sleeperThread.Start();
            sleeperThread.Interrupt();
        }
        private static void ThreadToSleep()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("[Sleeper : " + i++ + "]");

            if (i == 9)
                {
                    try
                    {
                        Console.WriteLine("i 가 " + i + " 가 되어 1 초쉼...");
                        Thread.Sleep(1000);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        Console.WriteLine("ThreadInterruptedException ...");
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}*/

/*
//C# 멀티 쓰레드(AutoResetEvent, ManualResetEvent)

using System;
using System.Threading;
public class ThreadTest2
{
    bool sleep = false;

    //차단기가 내려간 상태
    static AutoResetEvent autoEvent = new AutoResetEvent(false);
    public void FirstWork()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine("F{0}", i);
            if (i == 5)
            {
                sleep = true;
                Console.WriteLine("");
                Console.WriteLine("first 쉼...");
                autoEvent.WaitOne();
            }
        }
    }
    public static void Main()
    {
        ThreadTest2 t = new ThreadTest2();
        Thread first = new Thread(new ThreadStart(t.FirstWork));
        first.Start();
        while (t.sleep == false) { }
        Console.WriteLine("first를 깨웁니다...2초후 깨어 납니다.");
        Thread.Sleep(2000);
        autoEvent.Set();
    }
}*/
/*
// ThreadStart 델리게이트를 이용하여 작성
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ConsoleApplication3
{
    class Program
    {
        static int mysum = 0;
        static void Sum(object n)
        {
            int sum = 0;
            int[] number = (int[])n;
            for (int i = number[0]; i <= number[1]; i++)
            {
                sum += i;
            }
            mysum += sum;
        }
        static void Main(string[] args)
        {
            //Thread t1 = new Thread(new ThreadStart(() => Sum(new int[] { 1, 10 })));
            //Thread t2 = new Thread(new ThreadStart(() => Sum(new int[] { 11, 20 })));
            //Thread t3 = new Thread(new ThreadStart(() => Sum(new int[] { 21, 30 })));
            //Thread t4 = new Thread(new ThreadStart(() => Sum(new int[] { 31, 40 })));
            //Thread t5 = new Thread(new ThreadStart(() => Sum(new int[] { 41, 50 })));

            Thread t1 = new Thread(new ParameterizedThreadStart(Sum));
                        
            t1.Start(new int[] { 1, 10 });
            //t1.Start();
            //t2.Start();
            //t3.Start();
            //t4.Start();
            //t5.Start();

            t1.Join();
            //t2.Join();
            //t3.Join();
            //t4.Join();
            //t5.Join();
            Console.WriteLine(mysum);
        }
    }
}
*/

//C# 멀티 쓰레드(동기화, lock)
using System;
using System.Threading;
public class ThreadTest3
{
    public string lockString = "Hello";
    private static Mutex mutex = new Mutex();
    private object obj = new object();
    public void Print1(string rank)
    {
        //lock을 걸어준 구문은 처음 쓰레드가 끝날때 까지 다른 쓰레드가 접근 금지
        //lock (obj)

        //Monitor.Enter 구문은 처음 쓰레드가 끝날때 까지 다른 쓰레드가 접근 금지. Monitor.Enter은  Monitor.Exit(obj)와 같이 사용
        //Monitor.Enter(obj);

        //WaitOne을 걸어준 구문은 처음 쓰레드가 끝날때 까지 다른 쓰레드가 접근 금지. mutex.WaitOne은  mutex.ReleaseMutex()와 같이 사용
        mutex.WaitOne();
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Thread.Sleep(100);
                    Console.Write(",");
                }
                Console.WriteLine("{0}{1} ", rank, lockString);
            }
        }

        //Monitor.Exit(obj);
        mutex.ReleaseMutex();

    }
    public void FirstWork() { Print1("F : "); }
    public void SecondWork() { Print1("S : "); }
}
class TestMain
{
    [MTAThread]
    public static void Main()
    {
        ThreadTest3 t = new ThreadTest3();
        Thread first = new Thread(new ThreadStart(t.FirstWork));
        Thread second = new Thread(new ThreadStart(t.SecondWork));
        first.Start();
        second.Start();
    }
}