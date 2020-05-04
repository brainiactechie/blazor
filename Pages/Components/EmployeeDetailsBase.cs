using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using SecondServer.Data.EmployeeService;
using SecondServer.models;

namespace SecondServer.Pages.Components
{
    public class EmployeeDetailsBase : ComponentBase
    {
        public Employee Emp { get; set; }
        [Inject]
        public IEmployeeData emp { get; set; }
        [Parameter]
        public string IdParam { get; set; }
        protected override Task OnInitializedAsync()
        {
            Emp = emp.GetEmployee(int.Parse(IdParam));
            return base.OnInitializedAsync();
        }
    }
}