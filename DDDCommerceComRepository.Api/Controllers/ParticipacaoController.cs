using DDDCommerceComRepository.Application.RedeSocial.ApplicationServices;
using DDDCommerceComRepository.Application.RedeSocial.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDDCommerceComRepository.Api.RedeSocial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipacaoController : ControllerBase
    {
        private readonly EventoService _eventoAppService;

        public ParticipacaoController(EventoService eventoAppService)
        {
            _eventoAppService = eventoAppService;
        }

        [HttpPost]
        public ActionResult Participar([FromBody] ParticipacaoDto participacao)
        {
            var resultado = _eventoAppService.ParticiparDoEvento(participacao.UsuarioId, participacao.EventoId).Result;
            if (!resultado)
            {
                return BadRequest("Erro ao definir uma participação");
            }
            return Ok(resultado);
        }
    }

}
