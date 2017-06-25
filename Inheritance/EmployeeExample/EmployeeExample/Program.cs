using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee zhangSan = new WageEmployee("ZhangSan",30,40);
            Manager liSi = new Manager("LiSi",5000);
            liSi.HireEmployee(zhangSan);
            Manager wangEr = new Manager("wangEr",6000);
            liSi.HireEmployee(wangEr);
            Project project1 = new Project("Project Awesome");

            liSi.AssignEmployeeToProject(zhangSan, project1);

            Console.WriteLine(liSi.Name);
            Console.WriteLine(liSi.GetSalary());

            Employee john = new WageEmployee("John", 20, 30);
            Employee joe = new SalaryEmployee("Joe", 3500);
            Console.WriteLine("John Salary: "+john.MonthlySalary);
            Console.WriteLine("Joe Salary: "+joe.MonthlySalary);

            Console.WriteLine(liSi.GetMonthlySalaryForEmployee(zhangSan));



        }
    }

    internal class Project
    {
        private string name;

        public Project(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }

    internal class Manager:SalaryEmployee
    {
        public Manager(string managerName, double salary):base(managerName,salary)
        {
        }

        public void HireEmployee(Employee employee)
        {
            Console.WriteLine("Manager {0} hired employee {1}", Name, employee.Name);
        }

        public void FireEmployee(Employee employee)
        {
            Console.WriteLine("Manager {0} fired employee {1}", Name, employee.Name);
        }

        public void AssignEmployeeToProject(Employee employee, Project project)
        {
            Console.WriteLine("Manager {0} assigne employee {1} to project {2}", Name, employee.Name,project.Name);
        }

        public double GetMonthlySalaryForEmployee( Employee employee)
        {
            return employee.MonthlySalary;
        }
    }

    public abstract class Employee
    {
        private string name;

        public Employee(string  employeeName)
        {
            this.name = employeeName;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public virtual double MonthlySalary { get; set; }

        public double GetSalary()
        {
            return 1000;
        }
    }

    public class WageEmployee:Employee
    {
        private double monthlySalary;
        private double wage;
        private double hoursPerWeek;
        public WageEmployee(string name, double wage,double hoursPerWeek):base(name)
        {
            this.wage = wage;
            this.hoursPerWeek = hoursPerWeek;
        }
        public override double MonthlySalary
        {
            get
            {
                return 4 * wage * hoursPerWeek;
            }

            set
            {
                monthlySalary = value;
            }
        }

        public double Wage
        {
            get
            {
                return wage;
            }

            set
            {
                wage = value;
            }
        }

        public double HoursPerWeek
        {
            get
            {
                return hoursPerWeek;
            }

            set
            {
                hoursPerWeek = value;
            }
        }
    }
    public class SalaryEmployee:Employee
    {
        private double monthlySalary;
        private double salary;
        public SalaryEmployee(string name,double salary):base(name)
        {
            this.salary = salary;
        }
        public override double MonthlySalary
        {
            get
            {
                return salary;
            }

            set
            {
                monthlySalary = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }
    }
}
