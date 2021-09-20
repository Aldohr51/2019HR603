using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _2019HR603.Models;

namespace _2019HR603.Controllers
{
    [ApiController]
    public class estados_equipoController : ControllerBase
    {
        private readonly _2019HR603Context _contexto;

        public estados_equipoController(_2019HR603Context miContexto){
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/estados")]
        public IActionResult Get(){
            var estados_equipoList = _contexto.estados_equipo;
                return Ok(estados_equipoList);
        }
    }
}