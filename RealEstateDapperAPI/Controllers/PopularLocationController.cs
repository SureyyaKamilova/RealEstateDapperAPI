using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapperAPI.DTOS.PopularLocationDtos;
using RealEstateDapperAPI.Repositories.Implementations;
using RealEstateDapperAPI.Repositories.Interfaces;

namespace RealEstateDapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationController : ControllerBase
    {
        private readonly IPopularLocationRepository _popularLocation;

        public PopularLocationController(IPopularLocationRepository popularLocation)
        {
            _popularLocation = popularLocation;
        }

        [HttpGet]
        public async Task<IActionResult> GetPopularLocation()
        {
            var values = await _popularLocation.GetAllPopularLocationAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreatePopularLocationDto popularLocationDto)
        {
            _popularLocation.CreatePopularLocation(popularLocationDto);
            return Ok("PopularLocation added successfully!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePopularLocation(int id)
        {
            _popularLocation.DeletePopularLocation(id);
            return Ok("PopularLocation deleted!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePopularLocation(UpdatePopularLocationDto popularLocationDto)
        {
            _popularLocation.UpdatePopularLocation(popularLocationDto);
            return Ok("PopularLocation updated!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPopularLocation(int id)
        {
            var values = await _popularLocation.GetPopularLocation(id);
            return Ok(values);
        }
    }
}
