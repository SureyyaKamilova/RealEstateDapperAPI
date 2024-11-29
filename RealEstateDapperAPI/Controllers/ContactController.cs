using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapperAPI.Repositories.Implementations;
using RealEstateDapperAPI.Repositories.Interfaces;

namespace RealEstateDapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;
        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [HttpGet("GetLastFourContactAsync")]
        public async Task<IActionResult> GetLastFourContactAsync()
        {
            var values = await _contactRepository.GetLastFourContactAsync();
            return Ok(values);
        }
    }
}
