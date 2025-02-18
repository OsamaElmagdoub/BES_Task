using BES_Task.DTO.DepartmentDTOs;
using BES_Task.ViewModel.DepartmentViewModels;

namespace BES_Task.Services.DepartmentServices
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentViewModel>> GetAllDepartments();
        Task<DepartmentViewModel> GetDepartmentById(int id);
        Task AddDepartment(CreateDepartmentDTO departmentDTO);
        Task UpdateDepartment(int id ,CreateDepartmentDTO createDepartmentDTO);
        Task DeleteDepartment(int id);
    }
}
