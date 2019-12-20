using System;

namespace Vitvor.OOP12
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflector reflector = new Reflector();
            reflector.SeeAll("Boss");
            reflector.SeeAllMethods("Date");
            reflector.SeeFieldsAndProperties("Boss");
            reflector.AllMethodswithParm("Date", typeof(int));
            reflector.CallAnything("Date", "WriteSth");
            Console.ReadKey();
        }
    }
}
