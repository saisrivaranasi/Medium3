using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Employee emp = new Employee();
            List<Employee> empList = new List<Employee>();
            void SortAndPrintEmployee()
            {
                empList.Sort();
                Console.WriteLine("The sorted employee list\n");
                foreach (var item in empList)
                {
                    Console.WriteLine("Employee ID: {0}\nName: {1}\nAge: {2}\nSalary:{3}\n--------------\n", item.Id, item.Name, item.Age, item.Salary);

                }
            }
            void PrintEmployee()
            {
                Console.WriteLine("Please enter the employee Name\n");
                string employeeName = Console.ReadLine();
                var result = from item in empList where item.Name == employeeName select item;
                foreach (Employee empobj in result)
                {
                    Console.WriteLine(empobj);
                }
            }
            do
            {
                emp.EmployeeDetails();
                empList.Add(new Employee() { Id = emp.Id, Name = emp.Name, Age = emp.Age, Salary = emp.Salary });
                Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a != 0);


            SortAndPrintEmployee();
            PrintEmployee();

            Console.ReadKey();
        }
    }

    class Employee : IComparable<Employee>
    {
        int id, age;
        string name;
        double salary;

        public Employee()
        {
        }

        public Employee(int id, int age, string name, double salary)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.salary = salary;
        }
        public int CompareTo(Employee other)
        {
            if (this.Salary < other.Salary)
            {
                return 1;
            }
            else if (this.Salary > other.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public void EmployeeDetails()
        {
            Console.WriteLine("Please enter the employee ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee salary");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Employee ID : " + id + "\nName : " + name + "\nAge : " + age + "\nSalary : " + salary;
        }

        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

    }

}

        
