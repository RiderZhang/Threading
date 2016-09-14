using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threading
{
    public delegate void ParameterizedThreadStart(string obj);
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "yyr";
            string show = "love";
            for (int i = 0; i < 2; i++)
            {
                if (i % 2 == 1)
                {
                    Thread th = new Thread(delegate () { ShowMsg(msg, show); });
                    th.Start();
                }
                if (i % 2 == 0)
                {
                    Thread th1 = new Thread(delegate () { ShowMsg("zxh", "love yyr"); });
                    th1.Start();
                }
            }

            Console.WriteLine("Hello World!" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ms"));

        }
        public static void ShowMsg(string msg, string show)
        {
            //Thread.Sleep(3000); //设定3s后执行
            Console.WriteLine("Hello Girl,{0}", msg + show + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ms"));
        }
        public static void test()
        {
            string name = "zxh";

        }
    }
}
