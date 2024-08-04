using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
