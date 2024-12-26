using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapperAPI.DTOS.ToDoListDtos;
using RealEstateDapperAPI.Repositories.Implementations;
using RealEstateDapperAPI.Repositories.Interfaces;

namespace RealEstateDapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private readonly IToDoListRepository _toDoListRepository;
        public ToDoListController(IToDoListRepository toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }

        [HttpGet("GetAllToDoListAsync")]
        public async Task<IActionResult> GetAllToDoListAsync()
        {
            var values=await _toDoListRepository.GetAllToDoListAsync();

            return Ok(values);
        }

        [HttpPost("CreateToDoListAsync")]
        public async Task<IActionResult> CreateToDoList(CreateToDoListDto createToDoListDto)
        {
            _toDoListRepository.CreateToDoList(createToDoListDto);
            return Ok("ToDoList added successfully!");
        }
    }
}
