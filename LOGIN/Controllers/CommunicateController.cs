using LOGIN.Dtos.Communicates;
using LOGIN.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LOGIN.Controllers
{
    [Route("api/communicate")]
    [ApiController]
    public class CommunicateController : ControllerBase
    {
        private readonly IComunicateServices _comunicateServices;

        public CommunicateController(IComunicateServices comunicateServices)
        {
            _comunicateServices = comunicateServices;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCommunicate([FromBody] CreateCommunicateDto model)
        {
            var response = await _comunicateServices.CreateCommunicate(model);

            if (response.Status)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCommunicates()
        {
            var response = await _comunicateServices.GetAllCommunicates();

            if (response.Status)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }



        //editar comunicado
        [HttpPut]
        public async Task<IActionResult> UpdateCommunicate([FromBody] CommunicateDto model)
        {
            var response = await _comunicateServices.UpdateCommunicate(model);

            if (response.Status)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }

        //eliminar comunicado
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommunicate(Guid id)
        {
            var response = await _comunicateServices.DeleteCommunicate(id);

            if (response.Status)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }

    }
}