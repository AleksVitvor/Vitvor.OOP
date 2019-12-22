using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vitvor.OOP15
{
    class Program
    {
        private static readonly Barrier barrier = new Barrier(2);
        static void Main(string[] args)
        {
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine($"ID: {process.Id} Name: {process.ProcessName}");
            }
            Process proc = Process.GetProcessesByName("devenv")[0];
            AppDomain domain = AppDomain.CreateDomain("HelloWorld");
            Assembly assembly = Assembly.GetExecutingAssembly();
            domain.Load(assembly.FullName);
            AppDomain.Unload(domain);

            Thread thread = new Thread(PrimeNumbers);
            thread.Name = "Поток простых чисел";
            thread.Start();
            thread.Suspend();
            Console.WriteLine($"Priority: {thread.Priority}; Name: {thread.Name}; State: {thread.ThreadState}");
            thread.Resume();
            thread.Join();
            Thread thread1 = new Thread(new ParameterizedThreadStart(Numbers));
            Thread thread2 = new Thread(new ParameterizedThreadStart(NENumbers));
            Console.WriteLine("Введите макс. число");
            int x = Convert.ToInt32(Console.ReadLine());
            thread1.Start(x);
            thread2.Start(x);
            thread1.Join();
            thread2.Join();
            Console.ReadLine();
        }
        public static void PrimeNumbers()
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            Eratosfen eratosfen = new Eratosfen(n);
            int[] result = eratosfen.Simple;
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
        }
        public static void Numbers(object x)
        {
            for (int i = 1; i <= (int)x; i++) 
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                barrier.SignalAndWait();
            }
        }
        public static void NENumbers(object x)
        {
            for (int i = 1; i <= (int)x; i++) 
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
                barrier.SignalAndWait();
            }
        }
    }
}
