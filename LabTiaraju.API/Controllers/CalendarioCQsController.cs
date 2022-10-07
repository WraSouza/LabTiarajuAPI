using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LabTiaraju.API.Controllers
{
    [Route("api/calendariocqs")]
    [ApiController]
    public class CalendarioCQsController : ControllerBase
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

        // api/calendariocqs/1/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {            
            return NoContent();
        }

        // api/calendariocqs/1/finish
        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {            
            return NoContent();
        }

        //api/calendariocqs/numero_qualquer
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {           

            //PUT não retorna nada
            return NoContent();
        }

        ////api/calendariocqs/numero_qualquer
        //[HttpPut("{id}")]
        //public IActionResult Put(int id, [FromBody] UpdateProjectInputModel inputModel)
        //{
        //    if (inputModel.Description.Length > 50)
        //    {
        //        return BadRequest();
        //    }            

        //    //PUT não retorna nada
        //    return NoContent();
        //}
    }
}
