using DapperWithApiNet6.Services;
using Microsoft.AspNetCore.Mvc;

namespace DapperWithApiNet6.Controllers
{
    [ApiController]
    [Route("api/personals")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IPersonalRepository _personalRepository;
        public WeatherForecastController(IPersonalRepository personalRepository)
        {
            _personalRepository = personalRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetPersonals()
        {
            try
            {
                var companies = await _personalRepository.GetPersonals();
                return Ok(companies);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
    }
}