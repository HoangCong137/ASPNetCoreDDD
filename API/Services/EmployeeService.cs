using API.Dtos;
using Domain.Employees;
using Domain.Interfaces;

namespace API.Services
{
    public class EmployeeService : IEmployeeService
    {
        public IUnitOfWork _unitOfWork;
        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddEmployee(EmployeeDto employeeDto)
        {
            var emp = new Employee
            {
                Employee_ID = employeeDto.Employee_ID,
                FirstName = employeeDto.FirstName,
                LastName = employeeDto.LastName,
                Sex = employeeDto.Sex,
                BirthDate = employeeDto.BirthDate,
                Email = employeeDto.Email,
                Phone = employeeDto.Phone
            };

            _unitOfWork.EmployeeRepository.Add(emp);
            await _unitOfWork.CommitAsync();

        }

        public async Task<IEnumerable<Employee>> GetALl()

         => await _unitOfWork.EmployeeRepository.GetAllAsync();

    }
}
