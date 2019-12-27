using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vitvor.OOP16
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Eratosfen eratosfen = new Eratosfen();
            Task task = Task.Run(() => eratosfen.Do(1000));
            Console.WriteLine($"Status: {task.Status}\n ID:{task.Id} ");
            task.Wait();
            Console.WriteLine("Task1 is ready");
            Console.ReadLine();

            CancellationTokenSource source = new CancellationTokenSource();
            CancellationToken token = source.Token;
            Task task1 = Task.Run(() => eratosfen.Do(9999, token));
            Console.WriteLine("Введите Y для отмены операции или другой символ для продолжения");
            string s = Console.ReadLine();
            if (s == "Y")
            {
                source.Cancel();
            }
            Console.WriteLine("Task2 is ready");
            Console.ReadLine();

            Task<int[]> task2 = new Task<int[]>(() => eratosfen.DoD(1000));
            Task<int> task3 = new Task<int>(() => Sum(200, 10));
            Task<int[]> task4 = new Task<int[]>(() => eratosfen.DoD(300));
            task2.Start();
            task3.Start();
            task4.Start();
            int mainresult = task2.Result.Max() + task3.Result + task4.Result.Max();
            Console.WriteLine(mainresult);
            Console.WriteLine("Task3 is ready");
            Console.ReadLine();

            Task<int> task5 = new Task<int>(() => Sum(6, 10));
            Task task6 = task5.ContinueWith(sum => Display(sum.Result));
            task5.Start();
            task6.Wait();
            Console.ReadLine();

            Task<int> task7 = new Task<int>(() => Sum(6, 10));
            task7.Start();
            var awaiterfortask5 = task7.GetAwaiter();
            int res = 0;
            awaiterfortask5.OnCompleted(() => { res = awaiterfortask5.GetResult(); });
            Console.WriteLine(res);
            Console.WriteLine("Task4 is ready");
            Console.ReadLine();

            Parallel.For(0, task2.Result.Length, Writer);
            Parallel.ForEach(task2.Result, Writer);
            Console.WriteLine("Task5 is ready");
            Console.ReadLine();

            Parallel.Invoke(Display,
                () =>
                {
                    Console.WriteLine($"Выполняется задача: {Task.CurrentId}");
                    Thread.Sleep(3000);
                },
                () => Writer(task2.Result));
            Console.WriteLine("Task6 is ready");
            Console.ReadLine();

            Task task8 = Task.Run(() => Take());
            task8.Wait();
            Console.WriteLine("Task7 is ready");
            Console.ReadLine();
            DateTime dateTime1 = DateTime.Now;
            Console.WriteLine($"Работа программы завершена за {dateTime1.Subtract(dateTime) }");
            Console.ReadKey();
        }
        static int Sum(int a, int b) => a + b;
        static void Display()
        {
            Console.WriteLine($"Выполняется задача {Task.CurrentId}");
        }
        static void Display(int sum)
        {
            Console.WriteLine($"Sum {sum}");
        }
        static void Writer(int x)
        {
            Console.WriteLine(x);
        }
        static void Writer(int[] x)
        {
            foreach (int i in x)
                Console.WriteLine(i);
        }
        public static async Task Take()
        {
            using (BlockingCollection<Product> bc = new BlockingCollection<Product>())
            {

                using (Task p1 = Task.Run(() =>
                {
                    Console.WriteLine("Добавлен телевизор");
                    if (bc.TryAdd(new Product("Телевизор")))

                    foreach (Product p in bc)
                    {
                        Console.WriteLine(p.Name);
                    }
                }))
                using (Task p2 = Task.Run(() =>
                {
                    Console.WriteLine("Добавлен планшет");
                    if (bc.TryAdd(new Product("Планшет")))


                    foreach (Product p in bc)
                    {
                        Console.WriteLine(p.Name);
                    }
                }))
                using (Task p3 = Task.Run(() =>
                {
                    Console.WriteLine("Добавлена ноутбук");
                    if (bc.TryAdd(new Product("Ноутбук")))

                    foreach (Product p in bc)
                    {
                        Console.WriteLine(p.Name);
                    }
                }))
                using (Task p4 = Task.Run(() =>
                {
                    Console.WriteLine("Добавлены часы");
                    if (bc.TryAdd(new Product("Часы")))

                    foreach (Product p in bc)
                    {
                        Console.WriteLine(p.Name);
                    }
                }))
                using (Task p5 = Task.Run(() =>
                {
                    Console.WriteLine("Добавлена мышка");
                    if (bc.TryAdd(new Product("Мышка")))

                    foreach (Product p in bc)
                    {
                        Console.WriteLine(p.Name);
                    }
                }))
                using(Task m1=Task.Run(()=>
                {
                    Task.WaitAll(p1, p2, p3, p4, p5);
                    Console.WriteLine("Поставок больше нет");
                    if (p1.IsCompleted && p2.IsCompleted && p3.IsCompleted && p4.IsCompleted && p5.IsCompleted)
                        bc.CompleteAdding();
                }))
                {
                    using (Task b1 = Task.Run(() =>
                    {
                        try
                        {
                            while (true) Console.WriteLine($"1 take {bc.Take().Name}");

                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("First is all");
                        }
                    }))
                    using (Task b2 = Task.Run(() =>
                    {
                        try
                        {
                            while (true) Console.WriteLine($"2 take {bc.Take().Name}");
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Second is all");
                        }
                    }))
                    using (Task b3 = Task.Run(() =>
                    {
                        try
                        {
                            while (true) Console.WriteLine($"3 take {bc.Take().Name}");
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Third is all");
                        }
                    }))
                    using (Task b4 = Task.Run(() =>
                    {
                        try
                        {
                            while (true) Console.WriteLine($"4 take {bc.Take().Name}");
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Fourth is all");
                        }
                    }))
                    using (Task b5 = Task.Run(() =>
                    {
                        try
                        {
                            while (true) Console.WriteLine($"5 take {bc.Take().Name}");
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Five is all");
                        }
                    }))
                    using (Task b6 = Task.Run(() =>
                    {
                        try
                        {
                            while (true) Console.WriteLine($"6 take {bc.Take().Name}");
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Six is all");
                        }
                    }))
                    using (Task b7 = Task.Run(() =>
                    {
                        try
                        {
                            while (true) Console.WriteLine($"7 take {bc.Take().Name}");
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Seven is all");
                        }
                    }))
                    using (Task b8 = Task.Run(() =>
                    {
                        try
                        {
                            while (true) Console.WriteLine($"8 take {bc.Take().Name}");
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Eight is all");
                        }
                    }))
                    using (Task b9 = Task.Run(() =>
                    {
                        try
                        {
                            while (true) Console.WriteLine($"9 take {bc.Take().Name}");
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Nine is all");
                        }
                    }))
                    using (Task b10 = Task.Run(() =>
                    {
                        try
                        {
                            while (true) Console.WriteLine($"10 take {bc.Take().Name}");
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Ten is all");
                        }
                    }))

                    {
                        await Task.WhenAll(p1, p2, p3, p4, p5, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, m1);
                    }

                }
            }
        }
    }
}
