using EquiposWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EquiposWebAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class EquiposController : ControllerBase
    {
        

        //configurar mi variable de conexion al contexto db
        private readonly prestamosContext _contexto;

        public EquiposController(prestamosContext miContexto)
        {
            _contexto = miContexto;
        }

        [HttpGet]
        [Route("api/equipos")]
        
        public IActionResult Get()
        {
            IEnumerable<equipos> equiposList = (from e in _contexto.equipos
                                                select e);

            if (equiposList.Count() > 0)
            {
                return Ok(equiposList);
            }
            return NotFound();
        }
    }
}
