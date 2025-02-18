using BES_Task.Data.Models;
using BES_Task.Repository.GenericRepository;

namespace BES_Task.Repository.Departments
{
    public interface IDepartmentRepository : IRepository<Department> 
    {
        Task<IEnumerable<Department>> GetAllDepartmentsWithManagersAsync();

    }
}
