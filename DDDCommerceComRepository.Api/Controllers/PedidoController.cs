using DDDCommerceComRepository.Domain;
using DDDCommerceComRepository.Infra;
using DDDCommerceComRepository.Infra.RedeSocial.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace DDDCommerceComRepository.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IUsuarioRepository _context;

        public PedidosController(IUsuarioRepository context)
        {
            _context = context;
        }

        //// GET: api/Pedidos
        //[HttpGet]
        //public ActionResult<List<Usuario>> GetPedidos()
        //{
        //    return _context.GetAll();
        //}

        //// GET: api/Pedidos/5
        //[HttpGet("{id}")]
        //public ActionResult<Usuario> GetPedido(int id)
        //{
        //    var pedido = _context.GetPedidoById(id);

        //    if (pedido == null)
        //    {
        //        return NotFound();
        //    }

        //    return pedido;
        //}

        ////// PUT: api/Pedidos/5
        ////// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        ////[HttpPut("{id}")]
        ////public async Task<IActionResult> PutPedido(int id, Pedido pedido)
        ////{
        ////    if (id != pedido.Id)
        ////    {
        ////        return BadRequest();
        ////    }

        ////    _context.Entry(pedido).State = EntityState.Modified;

        ////    try
        ////    {
        ////        await _context.SaveChangesAsync();
        ////    }
        ////    catch (DbUpdateConcurrencyException)
        ////    {
        ////        if (!PedidoExists(id))
        ////        {
        ////            return NotFound();
        ////        }
        ////        else
        ////        {
        ////            throw;
        ////        }
        ////    }

        ////    return NoContent();
        ////}

        //// POST: api/Pedidos
        //[HttpPost]
        //public ActionResult<Usuario> PostPedido(Usuario pedido)
        //{
        //    _context.AddPedido(pedido);
        //    return CreatedAtAction("GetPedido", new { id = pedido.Id }, pedido);
        //}

        //// DELETE: api/Pedidos/5
        //[HttpDelete("{id}")]
        //public IActionResult DeletePedido(int id)
        //{
        //    if (_context.DeletePedido(id)) 
        //    return Ok("Pedido Deletado com sucesso");

        //    return NotFound("Id nao encontrado");
        //}

    }
}
