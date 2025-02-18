using BES_Task.DTO.DepartmentDTOs;
using BES_Task.DTO.ManagerDTOs;
using BES_Task.ViewModel.ManagerViewModels;

namespace BES_Task.Services.ManagerServices
{
    public interface IManagerService
    {
        Task<IEnumerable<ManagerViewModel>> GetAllManagers();
        Task<ManagerViewModel> GetManagerById(int id);
        Task AddManager(CreateManagerDto managerDto);
        Task UpdateManager(int id, CreateManagerDto managerDto);
        Task DeleteManager(int id);
    }
}
