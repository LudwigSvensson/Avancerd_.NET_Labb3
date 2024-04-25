using Avancerd_.NET_Labb3.Services.Interfaces;
using Avancerd_.NET_Labb3.Services.Repositories;
using Labb3_Models_;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avancerd_.NET_Labb3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HobbyController : ControllerBase
    {
        private Labb3Interface<Hobby> _hobby;

        public HobbyController(Labb3Interface<Hobby> hobby)
        {
            _hobby = hobby;
        }

        [HttpGet("GetAllHobbies")]
        public async Task<IActionResult> GetHobbies()
        {
            try
            {
                return Ok(await _hobby.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   $"Error to get customerdata from DB.....{ex.Message}");
            }
        }     
    }
}
