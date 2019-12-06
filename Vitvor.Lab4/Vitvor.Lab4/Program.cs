using System;

namespace Vitvor.Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Vitvor_List<ObjectInList> vitvor_List=new Vitvor_List<ObjectInList>();
                Console.WriteLine(vitvor_List.Look(1));
            }
            catch(Error)
            {
                Console.WriteLine("Найдена ошибка");
            }
            finally
            {
                Console.WriteLine("Код завершён с ошибкой");
            }
        }
    }
}
