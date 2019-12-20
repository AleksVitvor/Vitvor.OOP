using System;
using System.IO;
using System.Reflection;

namespace Vitvor.OOP12
{
    class Reflector
    {
        private static string _dataway = @"data.txt";
        private static string _parameterway = @"param.txt";

        public static string addNamespace(string str) => "Vitvor.OOP12." + str;
        public void SeeAll(string classname)
        {
            Type type = Type.GetType(addNamespace(classname));
            using (StreamWriter sw= new StreamWriter(_dataway, false, System.Text.Encoding.Default))
            {
                sw.WriteLine($"All info about {classname}");
                foreach(MemberInfo item in type.GetMembers())
                {
                    sw.WriteLine($"{item.DeclaringType} {item.MemberType} {item.Name}");
                }
                sw.Close();
            }
        }
        public void SeeAllMethods(string classname)
        {
            Console.WriteLine($"All methods of {classname}");
            Type type = Type.GetType(addNamespace(classname));
            foreach(MethodInfo item in type.GetMethods())
            {
                Console.WriteLine($"{item.DeclaringType} {item.Name}");
            }
        }
        public void SeeFieldsAndProperties(string classname)
        {
            Console.WriteLine($"All fields and properties of {classname}");
            Type type = Type.GetType(addNamespace(classname));
            foreach(FieldInfo item in type.GetFields())
            {
                Console.WriteLine($"{item.DeclaringType} {item.MemberType} {item.Name}");
            }
            foreach(PropertyInfo item in type.GetProperties())
            {
                Console.WriteLine($"{item.DeclaringType} {item.MemberType} {item.Name}");
            }
        }
        public void AllMethodswithParm(string classname, Type parm)
        {
            Type type = Type.GetType(addNamespace(classname));
            foreach(MethodInfo item in type.GetMethods())
            {
                foreach(ParameterInfo parameter in item.GetParameters())
                {
                    if(parameter.ParameterType==parm)
                    {
                        Console.WriteLine($"{item.ReturnType.Name} {item.Name}");
                    }
                }
            }
        }
        public void CallAnything(string classname, string methodname)
        {
            Assembly asm = Assembly.LoadFrom("Vitvor.OOP12.exe");
            Type type = asm.GetType(addNamespace(classname));
            object obj = Activator.CreateInstance(type);
            MethodInfo method = type.GetMethod(methodname);
            using(StreamReader reader= new StreamReader(_parameterway))
            {
                int i = 0;
                string str;
                str = reader.ReadToEnd();
                string[] pars= str.Split(new char[] { ',' });
                method.Invoke(obj, new object[] { pars[0], Convert.ToInt32(pars[1]) });
            }
        }
    }
}
