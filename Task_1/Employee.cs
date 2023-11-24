using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_9
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        
        public Employee(string name, int age, double salary) 
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        /// <summary>
        /// Метод GetInfo(): выводит информацию о сотруднике
        /// </summary>
        public virtual void GetInfo()
        {
            Console.WriteLine("Имя: {0}", Name);
            Console.WriteLine("Возраст: {0}", Age);
            Console.WriteLine("Зарплата: {0}", Salary);
        }

        /// <summary>
        ///Метод CalculateAnnualSalary(): рассчитывает и возвращает годовую зарплату сотрудника
        /// </summary>      
        public virtual double CalculateAnnualSalary()
        {
            return Salary * 12;
        }
    }
}
