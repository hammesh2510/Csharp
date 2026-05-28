using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();

            Console.WriteLine("please enter a name of Employee : ");
            e1.name = Console.ReadLine();
            Console.WriteLine("please enter a gender of Employee : ");
            e1.gender = Console.ReadLine();
            Console.WriteLine("please enter the age of Employee : ");
            e1.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the basic salary of Employee : ");
            e1.basicsalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the Rent allowance of Employee : ");
            e1.hra = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the Travel allowance of Employee : ");
            e1.ta = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the Future savings deduction of Employee : ");
            e1.pf = Convert.ToDouble(Console.ReadLine());

            e1.netsalary = (e1.basicsalary + e1.hra + e1.ta) - e1.pf;

            Console.WriteLine("so the net salary for the " + e1.name + " is " + e1.netsalary);
        }
    }

    class Employee
    {
        public string name;
        public string gender;
        public int age;

        public double basicsalary;
        public double hra;
        public double ta;
        public double pf;
        public double netsalary;

        public Employee()
        {

        }

        public Employee(string name,string gender,int age)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
    }
}
