using LearnMapster.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnMapster.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleMappController : ControllerBase
    {
        [HttpGet("new-person")]
        public IActionResult Test()
        {
            var data = MappingFunctions.MapPersonToNewDto();
            return Ok(data);
        }
        [HttpGet("existing-person")]
        public IActionResult TestII()
        {
            var data = MappingFunctions.MapPersonToNewDto();
            return Ok(data);
        }
        [HttpGet("list-person")]
        public IActionResult TestIII()
        {
            var data = MappingFunctions.MapPersonQueryableToDtoQueryable();
            return Ok(data);
        }
        [HttpGet("short-person")]
        public IActionResult GetShortPerson()
        {
            var person = MappingFunctions.CustomMapPersonToShortInfoDto();

            return Ok(person);
        }

        [HttpGet("short-person-address")]
        public IActionResult GetShortPersonWithAddress()
        {
            var person = MappingFunctions.CustomMapPersonToShortInfoDtoWithAddress();

            return Ok(person);
        }

        [HttpGet("parent-poco")]
        public IActionResult GetParentPoco()
        {
            var person = MappingFunctions.CustomParentPoco();

            return Ok(person);
        }
        [HttpGet("parent-poco-2")]
        public IActionResult GetParentPoco2()
        {
            var person = MappingFunctions.CustomParentPoco2();

            return Ok(person);
        }





    }
}
