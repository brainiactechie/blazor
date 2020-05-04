using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using SecondServer.Data.EmployeeService;
using SecondServer.models;
namespace SecondServer.Pages.Components
{
    public class EmployeeBase : ComponentBase
    {
        // private readonly IEmployeeData emp;
    
        public List<Employee> Employees { get; set; }
        [Inject]
        public IEmployeeData Emps { get; set; }
        public EmployeeBase()
        {
                Employees = new List<Employee>();
        }
      
        protected override Task OnInitializedAsync()
        {
            Employees = Emps.GetEmployees().ToList();
            return base.OnInitializedAsync();
        }

    }
}