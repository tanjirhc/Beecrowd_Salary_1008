using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd_Salary_1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, Hour;
            double Amount, Salary;
            n = Convert.ToInt32(Console.ReadLine());
            Hour = Convert.ToInt32(Console.ReadLine());
            Amount = Convert.ToDouble(Console.ReadLine());
            
            Salary = Hour * Amount;
            Console.WriteLine("NUMBER = {0}" , n);
            Console.WriteLine("SALARY = U$ {0}" , Salary.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
