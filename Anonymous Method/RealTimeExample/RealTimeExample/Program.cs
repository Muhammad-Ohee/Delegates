//Console.WriteLine("Hello, OS");

namespace RealTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 3: 
            // Create an instance of Predicate<Employee> delegate and 
            // pass the method name as an argument to the delegate constructor 
            Predicate<Employee> employeePredicate = new Predicate<Employee>(IsEmployeeExist);

            //Step4
            //Create a collection of List of Employees
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee(){ID = 101, Name = "Ghost", Gender = "Male", Salary = 100000},
                new Employee(){ID = 102, Name = "Oblivion", Gender = "Male", Salary = 200000},
                new Employee(){ID = 103, Name = "Tom", Gender = "Male", Salary = 300000},
                new Employee(){ID = 104, Name = "Angel", Gender = "Female", Salary = 400000},
                new Employee(){ID = 105, Name = "Angelina", Gender = "Female", Salary = 500000}
            };

            // Step 5: 
            // Now pass the delegate instance as the
            // argument to the Find() method of List collection
            Employee employee2 = employeeList.Find(x => employeePredicate(x));
            Employee employee = employeeList.Find(
                delegate(Employee x)
                {
                    return x.ID == 104;

                }
            );


            Console.WriteLine("ID : {0},\nName : {1},\nGender : {2},\nSalary : {3}\n", employee.ID, employee.Name, employee.Gender, employee.Salary);

            // Step 2: 
            // Create a method whose signature matches with the
            // signature of Predicate<Employee> generic delegate
            bool IsEmployeeExist(Employee employee)
            {
                return employee.ID == 104;
            }
        }
    }
}

