/*
using System;
using System.Windows.Forms;

class Program : Form
{
    static void Main(string[] args)
    {
        Program form = new Program();
        form.Click += new EventHandler(form.Form_Click);

        Console.WriteLine("윈도우 시작...");
        Application.Run(form);
        Console.WriteLine("윈도우 종료...");
    }

    void Form_Click(object sender, EventArgs e)
    {
        Console.WriteLine("폼클릭 이벤트...");
        MessageBox.Show("성공..");
        Application.Exit();
    }

}
*/

/*
//[람다식을 이용한 무명함수로 이벤트 처리]using System;
using System.Windows.Forms;

class Program : Form
{
    static void Main(string[] args)
    {
        Program form = new Program();

        form.Click += new EventHandler(
                    (sender, eventArgs) =>
                    {
                        Console.WriteLine("폼클릭 이벤트...");
                        Application.Exit();
                    }                    );

        Console.WriteLine("윈도우 시작...");
        Application.Run(form);
        Console.WriteLine("윈도우 종료...");
    }
}
*/

/*
//Application 클래스의 AddMessageFilter() 메소드
using System;
using System.Windows.Forms;
namespace ConsoleApplication9
{
    class OnjMessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            //마우스 클릭시 필터링 시킴
            if (m.Msg == 0x201)
            {
                Console.WriteLine("마우스 클릭 필터링됨...");
                //필터에서 처리했으니 응용프로그램에서 처리안해도된다는 의미
                //Form에 걸려 있는 Click 이벤트 동작안함.즉 윈도우가 종료되지않는다
                //이 부분을 false로 바꾼 후 실행해 보라
                return true;
            }

            //보통 윈도우에서 ALT+F4키는 윈도우를 종료 시키는데 이 키를 필터를 통해 막아보자.
            const int WM_SYSKEYDOWN = 0x0104;
            if (m.Msg == WM_SYSKEYDOWN)
            {
                bool alt = ((int)m.LParam & 0x20000000) != 0;
                if (alt && (m.WParam == new IntPtr((int)Keys.F4)))
                    Console.WriteLine("ALT+F4 Filtering됨.");
                return true; // 이벤트를 처리했으니 뒤쪽으로 넘기지 않는다.
            }
            return false;
        }        

    }

    class Program : Form
    {
        static void Main(string[] args)
        {
            Application.AddMessageFilter(new OnjMessageFilter());
            Program form = new Program();
            form.Click += new EventHandler(form.Form_Click);
            Application.Run(form);
        }
        void Form_Click(object sender, EventArgs e)
        {
            Console.WriteLine("마우스 클릭 이벤트 발생...");
            Application.Exit();
        }
    }
}
*/

using System;
using System.Windows.Forms;
class Program : Form
{
    public void MouseHandler(object sender, MouseEventArgs e)
    {
        Console.WriteLine("Sender : " + ((Form)sender).Text);
        Console.WriteLine("Sender : " + ((Form)sender).Name);
        Console.WriteLine("X:{0}, Y:{1}", e.X, e.Y);
        Console.WriteLine("Button:{0}, Clicks:{1}", e.Button, e.Clicks);
    }
    public Program(String title)
    {
        this.Text = title;
        this.Name = "윈폼";
        //MouseDown 이벤트 처리기 등록
        this.MouseDown += new MouseEventHandler(MouseHandler);
    }
    static void Main(string[] args)
    {
        Application.Run(new Program("마우스 이벤트 예제"));
    }
}