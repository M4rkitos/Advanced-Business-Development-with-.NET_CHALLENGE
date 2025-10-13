using EasyAccess.Application.DTOs;
using EasyAccess.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace EasyAccess.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VagasController : ControllerBase
    {
        private readonly VagaService _vagaService;

        public VagasController(VagaService vagaService)
        {
            _vagaService = vagaService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ReservaVagaDto reservaDto)
        {
            await _vagaService.RealizarReservaVagaAsync(reservaDto);
            return Ok();
        }
    }
}