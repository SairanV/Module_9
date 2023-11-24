using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager("Айдын", 95, 499998, 23);
            Developer d = new Developer("Темирлан", 19, 499550, 10000);


            m.GetInfo();
            Console.WriteLine("Годовая зарплата: {0}", m.CalculateAnnualSalary());
            Console.WriteLine();

            d.GetInfo();
            Console.WriteLine("Годовая зарплата: {0}", d.CalculateAnnualSalary());
            Console.WriteLine();
        }
    }
}
