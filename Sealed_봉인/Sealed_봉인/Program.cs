using System;

namespace Sealed_봉인
{
    class X
    {
        public virtual void F1() { Console.WriteLine("X.F1"); }
        public virtual void F2() { Console.WriteLine("X.F2"); }
        public virtual void F3() { Console.WriteLine("X.F3"); }
    }
    class Y : X
    {
        //F1 메소드는 자식이 재정의 불가
        sealed public override void F1() { Console.WriteLine("Y.F1"); }
        public override void F2() { Console.WriteLine("Y.F2"); }
        public virtual void F4() { Console.WriteLine("Y.F4"); }
    }
    class Z : Y
    {
        public override void F2() { Console.WriteLine("Z.F2"); }
        public virtual void F4() { Console.WriteLine("Z.F4"); }
    }
    public class Test
    {
        static void Main()
        {
            X x1 = new Z();
               x1.F1(); //Y.F1
               x1.F3(); //X.F3
               x1.F2(); //Z.F2
            Y y1 = new Z();
               y1.F1(); //Y.F1
               y1.F2(); //Z.F2
               y1.F3(); //X.F3
               y1.F4(); //Y.F4
            X x2 = new Y();
               x2.F1(); //Y.F1
               x2.F2(); //Y.F2
               x2.F3(); //X.F3
            Z z1 = new Z();
               z1.F1(); //Y.F1
               z1.F2(); //Z.F2
               z1.F3(); //X.F3
               z1.F4(); //Z.F4
        }
    }
}
