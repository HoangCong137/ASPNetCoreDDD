using API.Dtos;
using Domain.Employees;
using System.Collections.Immutable;

namespace API.Services
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<Employee>> GetALl();
        public Task AddEmployee(EmployeeDto employee);
    }
}
