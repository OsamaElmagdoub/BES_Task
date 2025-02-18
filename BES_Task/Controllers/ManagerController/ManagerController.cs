using BES_Task.DTO.DepartmentDTOs;
using BES_Task.DTO.ManagerDTOs;
using BES_Task.Services.DepartmentServices;
using BES_Task.Services.ManagerServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BES_Task.Controllers.ManagerController
{
   
    public class ManagerController : BaseController
    {

        
            private readonly IManagerService _managerService;


            public ManagerController(IManagerService managerService)
            {
            _managerService = managerService;
            }

            [HttpGet]
             [Authorize(Roles = "Admin,User")]
            public async Task<IActionResult> GetAll() 
                => Ok(await _managerService.GetAllManagers());

            [HttpGet("{id}")]
            [Authorize(Roles = "Admin,User")]
            public async Task<IActionResult> GetById(int id)
            {
                var department = await _managerService.GetManagerById(id);
                return department != null ? Ok(department) : NotFound();
            }

            [HttpPost]
            [Authorize(Roles = "Admin")]
            public async Task<IActionResult> Create( CreateManagerDto managerDto)
            {
                await _managerService.AddManager(managerDto);

                return Ok("Manager created successfully");
            }

            [HttpPut("{id}")]
            [Authorize(Roles = "Admin")]
            public async Task<IActionResult> Update(int id, [FromBody] CreateManagerDto managerDto)
            {
                await _managerService.UpdateManager(id, managerDto);
                return NoContent();
            }

            [HttpDelete("{id}")]
            [Authorize(Roles = "Admin")]
            public async Task<IActionResult> Delete(int id)
            {
                await _managerService.DeleteManager(id);
                return NoContent();
            }
        }

    }

