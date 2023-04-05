using API.Dtos;
using API.Services;
using Domain.Employees;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        public IEmployeeService _employeeService { get; set; }
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet(Name = "Employee")]
        public async Task<IEnumerable<Employee>> GetAll()
          => await _employeeService.GetALl();

        [HttpPost]
        public async Task AddBook([FromBody] EmployeeDto book)
        {
            await _employeeService.AddEmployee(book);
        }
    }
}
