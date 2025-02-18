using BES_Task.DTO.DepartmentDTOs;
using BES_Task.Repository.Departments;
using BES_Task.Services.DepartmentServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BES_Task.Controllers.DepartmentController
{
    

    public class DepartmentController : BaseController
    {
        private readonly IDepartmentService _departmentService;


        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

       [HttpGet]
       [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> GetAll() 
            => Ok(await _departmentService.GetAllDepartments());

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> GetById(int id)
        {
            var department = await _departmentService.GetDepartmentById(id);
            return department != null ? Ok(department) : NotFound();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(CreateDepartmentDTO departmentDTO)
        {
             await _departmentService.AddDepartment(departmentDTO);

            return Ok("Department created successfully");
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int id,  CreateDepartmentDTO departmentDTO)
        {
           await _departmentService.UpdateDepartment(id, departmentDTO);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            await _departmentService.DeleteDepartment(id);
            return NoContent();
        }
    }
}
