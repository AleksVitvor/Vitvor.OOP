using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP9
{
    class Worker
    {
        public Worker(int basesalary)
        {
            salary = basesalary;
        }
        public double salary { get; set; }
        public void OurBadWork(double num)
        {
            salary = salary * (1 - num);
            Console.WriteLine($"Salary after panalty is {salary}");
        }
        public void OurGoodWork(int num)
        {
            salary += num;
            Console.WriteLine($"Salary after panalty is {salary}");
        }
    }
}
