using BES_Task.Data.Context;
using BES_Task.Data.Models;
using BES_Task.Repository.GenericRepository;
using System;

namespace BES_Task.Repository.Departments
{
    public class DepartmentRepository : Repository<Department> ,IDepartmentRepository
        
    {
        public DepartmentRepository(ApplicationDBContext context) : base(context) { }

        public async Task<IEnumerable<Department>> GetAllDepartmentsWithManagersAsync()
        {
            return await GetAllWithIncludesAsync(d => d.Managers);
        }
    }
}
