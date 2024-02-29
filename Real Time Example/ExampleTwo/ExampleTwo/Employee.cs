using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTwo
{
    public delegate bool EligibleToPromotion(Employee  employeeToPromotion);
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<Employee> employeesList, EligibleToPromotion isEmployeeEligible)
        {
            foreach (var employee in employeesList)
            {
                if (isEmployeeEligible(employee))
                {
                    Console.WriteLine($"Employee {employee.Name} is promoted.");
                }
            }
        }
    }
    

}
