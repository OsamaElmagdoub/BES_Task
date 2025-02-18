using AutoMapper;
using BES_Task.Data.Models;
using BES_Task.DTO.DepartmentDTOs;
using BES_Task.DTO.ManagerDTOs;
using BES_Task.Repository.Departments;
using BES_Task.Repository.Mangers;
using BES_Task.Services.DepartmentServices;
using BES_Task.ViewModel.DepartmentViewModels;
using BES_Task.ViewModel.ManagerViewModels;

namespace BES_Task.Services.ManagerServices
{
    public class ManagerService : IManagerService
    {
      
        private readonly IManagerRepository _managerRepository;
        private readonly IMapper _mapper;

        public ManagerService(IManagerRepository managerRepository, IMapper mapper)
        {
            _managerRepository = managerRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ManagerViewModel>> GetAllManagers()
        {
            var managers = await _managerRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ManagerViewModel>>(managers);
        }

        public async Task<ManagerViewModel> GetManagerById(int id)
        {
            var manager = await _managerRepository.GetByIdAsync(id);


            return manager != null ? _mapper.Map<ManagerViewModel>(manager) : null;


        }

        public async Task AddManager(CreateManagerDto managerDto)
        {
            var manager = _mapper.Map<Manager>(managerDto);

            await _managerRepository.AddAsync(manager);
            await _managerRepository.SaveChangesAsync();
        }

        public async Task UpdateManager(int id, CreateManagerDto managerDto)
        {
            var manager = await _managerRepository.GetByIdAsync(id);
            if (manager != null)
            {
                _mapper.Map(managerDto, manager);
                _managerRepository.Update(manager);
                await _managerRepository.SaveChangesAsync();
            }

        }
        public async Task DeleteManager(int id)
        {
            var manager = await _managerRepository.GetByIdAsync(id);
            if (manager != null)
            {
                _managerRepository.Delete(manager);
                await _managerRepository.SaveChangesAsync();

            }

            }
        }

    }

