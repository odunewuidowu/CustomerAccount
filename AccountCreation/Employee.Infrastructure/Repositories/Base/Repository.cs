using Employee.Core.Repositories.Base;
using Employee.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AccountContext _EmployeeContext;

        public Repository(AccountContext EmployeeContext)
        {
            _EmployeeContext = EmployeeContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _EmployeeContext.Set<T>().AddAsync(entity);
            await _EmployeeContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _EmployeeContext.Set<T>().Remove(entity);
            await _EmployeeContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _EmployeeContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _EmployeeContext.Set<T>().FindAsync(id);
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
