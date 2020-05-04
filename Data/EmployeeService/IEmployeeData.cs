using System.Collections.Generic;
using SecondServer.models;

namespace SecondServer.Data.EmployeeService
{
    public interface IEmployeeData
    {
        public IEnumerable<Employee> GetEmployees();
        public Employee GetEmployee(int Id);
        
    }
}