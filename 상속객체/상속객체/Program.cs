using System;
namespace ConsoleApplication2
{
    public abstract class Emp // 추상 클래스, 틀, 스펙을 정의
    {
        public string Name
        {
            get; set;
        }
        public abstract void gotooffice(); // 추상 메소드
        //public abstract void getoff(); // 추상 메소드
    }
    public class Programmer : Emp
    {
        public override void gotooffice()
        {
            Console.WriteLine(Name + "가 출근한다.");
        }
        public  void getoff()
        {
            Console.WriteLine(Name + "가 퇴근한다.");
        }
    }
    public class Designer : Emp 
    {
        public override void gotooffice()
        {
            Console.WriteLine(Name + "가 화장하고 출근한다. ");
        }
        public  void getoff()
        {
            Console.WriteLine(Name + "가 모자쓰고 퇴근한다.");
        }
    }
    class EmpTest
    {
        static void Main()
        {
            Emp p = new Programmer(); p.Name = "개발자"; p.gotooffice (); ((Programmer )p).getoff ();
            Emp j = new Designer (); j.Name = "디자인너"; j.gotooffice (); ((Designer )j).getoff();
        }
    }
}