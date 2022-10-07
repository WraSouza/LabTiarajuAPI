using Microsoft.AspNetCore.Mvc;

namespace LabTiaraju.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post()
        {
            return NoContent();
        }

        //api/users/numero_qualquer
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {

            //PUT não retorna nada
            return NoContent();
        }
    }
}
