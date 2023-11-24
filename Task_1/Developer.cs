using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9
{
    public class Developer : Employee
    {
        // Количество строк кода, написанных в день
        private int linesOfCodePerDay;

        public Developer(string name, int age, double salary, int linesOfCodePerDay) : base(name, age, salary)
        {
            this.linesOfCodePerDay = linesOfCodePerDay;
        }

        /// <summary>
        /// Метод GetInfo(): выводит информацию о разработчике
        /// </summary>
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Строк кода в день: {0}", linesOfCodePerDay);
        }

        /// <summary>
        /// Метод CalculateAnnualSalary(): рассчитывает и возвращает годовую зарплату разработчика с учетом дополнительной оплаты за количество написанных строк кода
        /// </summary>
        /// <returns></returns>
        public override double CalculateAnnualSalary()
        {
            // Дополнительная оплата за одну строку кода равна 0.05
            return base.CalculateAnnualSalary() + linesOfCodePerDay * 0.05 * 12;
        }
    }
}
