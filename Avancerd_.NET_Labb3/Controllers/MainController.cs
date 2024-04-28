using Avancerd_.NET_Labb3.Data;
using Avancerd_.NET_Labb3.Services.Interfaces;
using Labb3_Models_;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Avancerd_.NET_Labb3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private Labb3Interface<Person> _person;
        private Labb3Interface<Link> _link;
        private Labb3Interface<Hobby> _hobby;


        public MainController(Labb3Interface<Person> person, Labb3Interface<Hobby> hobby, Labb3Interface<Link> link)
        {
            _hobby = hobby;
            _person = person;
            _link = link;

        }

        [HttpPost("{personId}/AddNewHobbyToPerson/{hobbyId}")]
        public async Task<IActionResult> AddHobbyToPerson(int personId, int hobbyId)
        {
            try
            {
                var person = await _person.GetSingle(personId);

                if (person == null)
                {
                    return NotFound("Person not found.");
                }

                var hobby = await _hobby.GetSingle(hobbyId);

                if (hobby == null)
                {
                    return NotFound("Hobby not found.");
                }

                person.Hobbies.Add(hobby);
                await _person.Update(person);

                return Ok("Hobby added to person.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"Error to retrieve orderdata from DB.....{ex.Message}");
            }
        }

        [HttpPost("{personId}/AddNewLinksToHobbies/{hobbyId}/links")]
        public async Task<IActionResult> AddLinkToHobbyAndPerson(int personId, int hobbyId, Link newLink)
        {
            try
            {

                var person = await _person.GetSingle(personId);

                if (person == null)
                {
                    return NotFound("Person not found.");
                }
                var hobby = await _hobby.GetSingle(hobbyId);

                if (hobby == null)
                {
                    return NotFound("Hobby not found.");
                }
                newLink.Hobbies.Add(hobby);
                newLink.Persons.Add(person);

                await _link.Add(newLink);


                return Ok("Link added to hobby.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                     $"Error to retrieve data from DB.....{ex.Message}");
            }
        }
    }
}
