using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;


namespace Vitvor.OOP10
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Random random = new Random();
            for (short i = 0; i < 5; i++)
            {
                arrayList.Add(random.Next(11, 99));
            }
            Console.WriteLine("Первая коллекция из случайных чисел и другого включает: ");
            arrayList.Add("My substr");
            arrayList.RemoveAt(3);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("Count " + arrayList.Count);
            Console.WriteLine(arrayList.Contains("My substr"));

            Stack<char> vs = new Stack<char>();
            vs.Push('a');
            vs.Push('c');
            Console.WriteLine("Введите количество входных символов");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                char sym = Convert.ToChar(Console.ReadLine());
                vs.Push(sym);
            }
            Console.WriteLine("Введите колчество элементов для удаления");
            int toDel = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < toDel; i++)
            {
                vs.Pop();
            }
            foreach (char item in vs)
                Console.WriteLine(item + " ");
            List<char> vs1 = new List<char>();
            for (int i = 0; i < vs.Count; i++)
            {
                vs1.Add(vs.Pop());
            }
            foreach (char item in vs1)
                Console.WriteLine(item);
            Console.WriteLine(vs1.Contains('a'));

            Transport first = new Transport(500, 30);
            Transport second = new Transport(300, 25);
            Transport third = new Transport(700, 50);
            Stack<Transport> airline = new Stack<Transport>();
            airline.Push(first);
            airline.Push(second);
            airline.Push(third);
            foreach (Transport item in airline)
                Console.WriteLine(item.ToString());
            Console.WriteLine("Введите колчество элементов для удаления");
            int ToDelete = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ToDelete; i++)
                airline.Pop();
            foreach (Transport item in airline)
                Console.WriteLine(item.ToString());
            List<Transport> transports = new List<Transport>();
            for (int i = 0; i < airline.Count; i++)
            {
                transports.Add(airline.Pop());
            }
            foreach (Transport item in transports)
                Console.WriteLine(item.ToString());
            ObservableCollection<Transport> observableCollection = new ObservableCollection<Transport>();
            observableCollection.CollectionChanged += Notification;
            observableCollection.Add(first);
            observableCollection.Remove(first);
            Console.ReadLine();
        }
        static void Notification(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("The collection has been changed");
        }

    }
}
