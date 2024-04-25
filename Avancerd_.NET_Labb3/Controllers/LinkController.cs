using Avancerd_.NET_Labb3.Services.Interfaces;
using Labb3_Models_;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avancerd_.NET_Labb3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkController : ControllerBase
    {
        private Labb3Interface<Link> _link;
        public LinkController(Labb3Interface<Link> link)
        {
            _link = link;
        }

        [HttpGet("GetAllLinks")]
        public async Task<IActionResult> GetLinks()
        {
            try
            {
                return Ok(await _link.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   $"Error to get customerdata from DB.....{ex.Message}");
            }
        }
    }
}
