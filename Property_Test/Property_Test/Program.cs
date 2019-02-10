using System;

namespace Property_Test
{
    class Emp : Object   {

        //private  int empno;
        /*
                public void SetEmpno(int empno) //Setter
                {
                    this.empno = empno;  // this.empno = private int empno 이고 empno = SetEmpno(int empno) 
                }

                public int GetEmpno() //Getter
                {
                    return this.empno;
                }
        */

        /*
    public int Empno  //위 주석과 같음.  일반 속성(=Property) 이라 명명함.
    {
        get
        {
            return this.empno;
        }

        set
        {
            this.empno = value;
        }
    }
    */

        public int Empno { get; set; }  //위 주석과 같음.  자동구현속성(=Property) 이라 명명함.

        public override string ToString()  // override 는 재정의
        {
            return $"[사원 : {Empno }]";
        }
    }
    class EmpTest
    {
        static void Main(string[] args)
        {
            Emp e = new Emp(); e.Empno =999;
            Console.WriteLine(e.Empno);
            Console.WriteLine(e);
            Console.WriteLine(e.ToString ());

        }
    }
}
