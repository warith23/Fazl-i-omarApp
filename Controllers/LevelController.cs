using Backend.Dto;
using Backend.Interface.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelController : ControllerBase
    {
        private readonly ILevelService _levelService;
        public LevelController(ILevelService levelService) 
        {
            _levelService = levelService;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromForm]LevelDto levelDto)
        {
            var result = await _levelService.Create(levelDto);
            return result.Status ? Ok(result) : BadRequest(result);
        }
    }
}
