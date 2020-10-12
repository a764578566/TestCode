using System;
using System.Linq;
using System.Threading;

namespace ProcessManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            while (true)
            {
                Thread.Sleep(200);//让这个循环每次循环都等待0.2秒，这样达到实现效果：没0.2秒检查一次程序是否在运行

                if (System.Diagnostics.Process.GetProcessesByName("ConsoleAppTest").ToList().Count > 0)
                {
                    Console.WriteLine("存在列表，不知运行状态");
                }
                else
                {
                    Console.WriteLine("不存在列表，该进程没有运行");
                }
            }
        }
    }
}
