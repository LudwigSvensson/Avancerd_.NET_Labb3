
using Avancerd_.NET_Labb3.Data;
using Avancerd_.NET_Labb3.Services.Interfaces;
using Avancerd_.NET_Labb3.Services.Repositories;
using Labb3_Models_;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Avancerd_.NET_Labb3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private Labb3Interface<Person> _person;

        public PersonController(Labb3Interface<Person> person) 
        {
            _person = person;
        }

        [HttpGet("GetAllPersons")]
        public async Task<IActionResult> GetPersons()
        {
            try
            {
                return Ok(await _person.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   $"Error to get customerdata from DB.....{ex.Message}");
            }
        }

        [HttpGet("{id:int}GetHobbies&LinksForSpecificPersonByPersonsID")]
        public async Task<ActionResult<Hobby>> GetHobbiesForSpecificPerson(int id)
        {
            try
            {
                var result = await _person.GetSingle(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"Error to retrieve orderdata from DB.....{ex.Message}");
            }
        }
    }
}
