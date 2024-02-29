//Console.WriteLine("Hello, OS");

namespace ExampleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Ghost",
                Gender = "Male",
                Experience = 5,
                Salary = 10000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Angelina",
                Gender = "Female",
                Experience = 10,
                Salary = 20000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Angel",
                Experience = 15,
                Salary = 30000
            };

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);

            EligibleToPromotion delegateObject = new EligibleToPromotion(PromotionLogic);
            //Employee.PromoteEmployee(employeeList, delegateObject);

            Employee.PromoteEmployee(employeeList, x => x.Experience>5);
        }

        static bool PromotionLogic(Employee employee)
        {
            // if (employee.Experience > 10) return true;
            return employee.Salary > 15000;
        }

    }
}

