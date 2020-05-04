
using System;
using System.Collections.Generic;
using System.Linq;
using SecondServer.models;

namespace SecondServer.Data.EmployeeService
{
    public class EmployeeService : IEmployeeData
    {
        public List<Employee> Employees { get; set; }
        public EmployeeService()
        {
            InitalizeEmployees();
        }

        private void InitalizeEmployees()
        {
            Employees = new List<Employee>();
            for (int i = 1; i <= 100; i++)
            {
                Employees.Add(new Employee()
                {

                    Id = 1,
                    Address = "Address - " + i,
                    Age = i * 10,
                    Name = "Emp - " + i
                });
            }
        }

        public Employee GetEmployee(int Id)
        {
            return Employees.FirstOrDefault(emp => emp.Id == Id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return Employees;
        }
    }
}