using AutoMapper;
using BES_Task.Data.Models;
using BES_Task.DTO.DepartmentDTOs;
using BES_Task.Repository.Departments;
using BES_Task.ViewModel.DepartmentViewModels;

namespace BES_Task.Services.DepartmentServices
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public DepartmentService(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<DepartmentViewModel>> GetAllDepartments()
        {
            var departments = await _departmentRepository.GetAllDepartmentsWithManagersAsync();
            return _mapper.Map<IEnumerable<DepartmentViewModel>>(departments);
        }

        public async Task<DepartmentViewModel> GetDepartmentById(int id)
        {
            var department = await _departmentRepository.GetByIdAsync(id);


            return department != null ? _mapper.Map<DepartmentViewModel>(department) : null;

          


        }

        public async Task AddDepartment(CreateDepartmentDTO departmentDTO)
        {
            var department = _mapper.Map<Department>(departmentDTO);

            await _departmentRepository.AddAsync(department);
            await _departmentRepository.SaveChangesAsync();
        }

        public async Task UpdateDepartment(int id, CreateDepartmentDTO departmentDTO)
        {
            var department = await _departmentRepository.GetByIdAsync(id);
            if (department != null)
            {
                _mapper.Map(departmentDTO, department);
                _departmentRepository.Update(department);
                await _departmentRepository.SaveChangesAsync();
            }

        }
        public async Task DeleteDepartment(int id)
        {
            var department = await _departmentRepository.GetByIdAsync(id);
            if (department != null)
            {
                _departmentRepository.Delete(department);
                await _departmentRepository.SaveChangesAsync();

            }

        }
    }
}