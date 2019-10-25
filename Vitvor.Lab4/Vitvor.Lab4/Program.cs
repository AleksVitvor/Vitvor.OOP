using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter numbers of members in list");
            int numbers = Convert.ToInt32(Console.ReadLine());
            Vitvor_List list = new Vitvor_List(numbers);
            list.Create(numbers);
            Vitvor_List list1 = new Vitvor_List(3);
            list1.Create(3);
            ObjectInList Object = list1[1].Sum(list[1]);
            Vitvor_List list2 = list + list1;
            Console.WriteLine(list != list1);
            Console.WriteLine(list1 > list1[3]);
            Console.ReadLine();
            Console.WriteLine(list1.ToString());
            list1[0].nameofcoach.DeleteAllVovel();
        }
    }
}
