using System;

namespace Property_Test
{
    class Emp : Object   {

        private  int empno;

        public void SetEmpno(int empno) //Setter
        {
            this.empno = empno;  // this.empno = private int empno 이고 empno = SetEmpno(int empno) 
        }

        public int GetEmpno() //Getter
        {
            return this.empno;
        }

        public override string ToString()  // override 는 재정의
        {
            return $"[사원 : {empno }]";
        }
    }
    class EmpTest
    {
        static void Main(string[] args)
        {
            Emp e = new Emp(); e.SetEmpno(111);
            Console.WriteLine(e.GetEmpno ());
            Console.WriteLine(e);
            Console.WriteLine(e.ToString ());

        }
    }
}
