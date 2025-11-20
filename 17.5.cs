using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _17._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee("Боба", new DateTime(2020, 3, 15), EmploymentStatus.Active);
            Console.WriteLine(emp.GetYearsWorked());
            emp.HireDate = null;
            Console.WriteLine(emp.GetYearsWorked());
        }
    }
    enum EmploymentStatus
    {
        Active,
        OnLeave,
        Terminated
    }
    class Employee
    {
        public string Name;
        public DateTime? HireDate;
        public EmploymentStatus Status;
        public Employee(string name, DateTime? hireDate, EmploymentStatus status)
        {
            Name = name;
            HireDate = hireDate;
            Status = status;
        }
        public int GetYearsWorked()
        {
            if (HireDate != null)
                return (DateTime.Now.Year - HireDate.Value.Year);
            else
            {
                return -1;
            }
        }
    }
}
