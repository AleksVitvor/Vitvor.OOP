using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool alive = true;
            byte bit1 = 101;
            short n1 = 100;
            int b = 10;
            long l = -11;
            float f = 34.11F;
            double d = 54.222;
            decimal dec = 8.955M;
            char c = 'A';
            string hello = "Hello";
            object o = 31.4;

            long b1 = (long)b;
            int bit2 = (int)bit1;
            float d1 = (float)d;
            int l1 = (int)l;
            decimal d2 = (decimal)d;

            long b2 = b;
            float b3 = b;
            long n2 = n1;
            int n3 = n1;
            short bit3 = bit1;

            object Obj = b;
            short b4 = (short)Obj;
            int b5 = (int)Obj;

            var HelloWorld = "Hello World";
            var v = 144;

            int? z1 = 5;
            Console.WriteLine(z1.Value);
            Console.WriteLine(z1.HasValue);
            int? z2 = null;
            Console.WriteLine(z2.Value);

            string world = " world";
            String.Compare(world, hello);
            String.Copy(HelloWorld);
            Console.WriteLine(HelloWorld.Contains(hello));
            Console.WriteLine(HelloWorld.Split(' '));
            Console.WriteLine(HelloWorld.Insert(3, hello));
            Console.WriteLine(HelloWorld.Replace(" hello",""));
            string fake = "";
            string fake1 = null;
            Console.WriteLine(String.IsNullOrEmpty(fake));
            Console.WriteLine(String.IsNullOrEmpty(fake1));
            StringBuilder sb = new StringBuilder("Привет мир");
            sb.Remove(4, 1);
            sb.Append("!");
            sb.Insert(0, "!");
            Console.WriteLine(sb);

            int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };
            int rows = nums2.GetUpperBound(0) + 1;
            int colomns = nums2.Length;
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < colomns; j++)
                {
                    Console.WriteLine($"{nums2[i, j]} \t");
                }
                Console.WriteLine();
            }

            string[] vs = { "first", "second", "third" };
            Console.WriteLine(vs.Length);
            int vssize = vs.Count();
            for (int i = 0; i < vssize; i++)
            {
                Console.WriteLine($"{vs[i]}, ");
            }
            int position = Convert.ToInt32(Console.ReadLine());
            string newstr = Console.ReadLine();
            vs[position] = newstr;

            double[][] nums = new double[3][];
            nums[0] = new double[2];
            nums[1] = new double[3];
            nums[2] = new double[4];
            for (int i = 0; i < 3; i++)
            {
                for(int j=0;j<nums[i].Length;j++)
                {
                    nums[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            (int age, string name, char klass, string surname, long middle) person = (17, "Tom", 'A', "Baron", (long)18.155);
            Console.WriteLine(person.ToString());
            Console.WriteLine(person.age);
            Console.WriteLine(person.klass);
            Console.WriteLine(person.surname);

            string name = person.name;

            (string name, int age) boy = ("Sasha", 19);

            Console.WriteLine(Tuple.Equals(person, boy));
            int[] mass1 = { 1, 2, 3, 0, 10 };
            Tuple localFunction(int[] mass, string str)
            {
                var result = (mass.Max(), mass.Min(), mass.Sum(), str[0]);
                return result;
            }
            var result=localFunction(mass1, HelloWorld);
            Console.WriteLine(result.ToString());
        }  
    }
}
