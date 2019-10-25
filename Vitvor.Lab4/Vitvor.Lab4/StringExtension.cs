using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.Lab4
{
    public static class StringExtension
    {
        public static void Delete5(this string str)
        {
            str.Remove(0, 5);
        }
        public static void DeleteAllVovel(this string str)
        {
            string[] vs = { "a", "e", "i", "o", "u" };
            for (short i = 0; i < vs.Length; i++)
            {
                str.Replace(vs[i], "");
            }
        }
    }
}
