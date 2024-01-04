using Backend.Dto;
using Backend.Interface.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService) 
        {
            _roleService = roleService;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(RoleDto roleDto)
        {
            var result = await _roleService.CreateRole(roleDto);
            return result.Status ? Ok(result) : BadRequest(result);
        }
    }
}
