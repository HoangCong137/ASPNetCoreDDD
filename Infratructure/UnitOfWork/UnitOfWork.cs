using Domain.Deparment;
using Domain.Employees;
using Domain.Interfaces;
using Infratructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infratructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        private IEmployeeRepository _employeeRepository;
        private IDeparmentRepository _deparmentRepository;
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEmployeeRepository EmployeeRepository
        {
            get { return _employeeRepository = _employeeRepository ?? new EmployeeRepository(_dbContext); }
        }
        public IDeparmentRepository DeparmentRepository
        {
            get { return _deparmentRepository = _deparmentRepository ?? new DepartmentRepository(_dbContext); }
        }

        public async Task CommitAsync()
        => await _dbContext.SaveChangesAsync();

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
