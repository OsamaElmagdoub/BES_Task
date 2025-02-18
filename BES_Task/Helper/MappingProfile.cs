using AutoMapper;
using BES_Task.Data.Models;
using BES_Task.DTO.DepartmentDTOs;
using BES_Task.DTO.LoginDtos;
using BES_Task.DTO.ManagerDTOs;
using BES_Task.ViewModel.DepartmentViewModels;
using BES_Task.ViewModel.ManagerViewModels;

namespace BES_Task.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<CreateDepartmentDTO, Department>();
            CreateMap<CreateManagerDto, Manager>();

            CreateMap<Department, DepartmentViewModel>()
            .ForMember(dest => dest.Managers, opt => opt.MapFrom(src => src.Managers));

            CreateMap<Manager, ManagerViewModel>();

            CreateMap<LoginDto, User>();


        }
    }
}
