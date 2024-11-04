using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapperAPI.DTOS.CatagoryDtos;
using RealEstateDapperAPI.DTOS.ServiceDtos;
using RealEstateDapperAPI.Repositories.Implementations;
using RealEstateDapperAPI.Repositories.Interfaces;

namespace RealEstateDapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllServices()
        {
            var value =await _serviceRepository.GetAllServiceAsync();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateServiceDto ServiceDto)
        {
            _serviceRepository.CreateService(ServiceDto);
            return Ok("Service added successfully!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            _serviceRepository.DeleteService(id);
            return Ok("Service deleted!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDto ServiceDto)
        {
            _serviceRepository.UpdateService(ServiceDto);
            return Ok("Service updated!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var values = await _serviceRepository.GetService(id);
            return Ok(values);
        }

    }
}
