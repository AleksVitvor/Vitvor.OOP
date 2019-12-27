using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vitvor.OOP16
{
    class Eratosfen
    {
        List<int> simple;

        public Eratosfen()
        {
            
        }
        public void Do(int MaxNumber)
        {
            simple = new List<int>();
            for (int i = 1; i < MaxNumber; i++)
                simple.Add(i);
            DoEratosfen();
        }
        public int[] DoD(int MaxNumber)
        {
            simple = new List<int>();
            for (int i = 1; i < MaxNumber; i++)
                simple.Add(i);
            DoEratosfen();
            return this.Simple;
        }
        public void Do(int MaxNumber, CancellationToken source)
        {
            simple = new List<int>();
            for (int i = 1; i < MaxNumber; i++)
                simple.Add(i);
            DoEratosfen(source);
        }

        int Step(int Prime, int startFrom)
        {
            int i = startFrom + 1;
            int Removed = 0;
            while (i < simple.Count)
                if (simple[i] % Prime == 0)
                {
                    simple.RemoveAt(i);
                    Removed++;
                }
                else
                    i++;
            return Removed;
        }

        void DoEratosfen()
        {
            int i = 1;
            while (i < simple.Count)
            {
                Step(simple[i], i);
                i++;
            }
        }

        void DoEratosfen(CancellationToken source)
        {
            int i = 1;
            while (i < simple.Count)
            {
                Step(simple[i], i);
                i++;
                if(source.IsCancellationRequested)
                {
                    Console.WriteLine("Операция прервана токеном");
                    return;
                }
            }
        }
        public int[] Simple
        {
            get
            {
                return simple.ToArray();
            }
        }

    }
}
