using HW_9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9
{
    public class Manager : Employee
    {
        // Бонус за успешный проект
        private double bonus;

        public Manager(string name, int age, double salary, double bonus) : base(name, age, salary)
        {
            this.bonus = bonus;
        }

        /// <summary>
        /// Метод GetInfo(): выводит информацию о менеджере
        /// </summary>
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Бонус: {0}", bonus);
        }

        /// <summary>
        /// Метод CalculateAnnualSalary(): рассчитывает и возвращает годовую зарплату менеджера с учетом бонуса
        /// </summary>
        /// <returns></returns>
        public override double CalculateAnnualSalary()
        {
            return base.CalculateAnnualSalary() + bonus;
        }
    }
}
