using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _2019HR603.Models;

namespace _2019HR603.Controllers
{
    [ApiController]
    public class marcasController : ControllerBase
    {
        private readonly _2019HR603Context _contexto;

        public marcasController(_2019HR603Context miContexto){
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/marcas")]
        public IActionResult Get(){
        var marcasList = _contexto.marcas;
        return Ok(marcasList);
        }
    }
}