using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _2019HR603.Models;

namespace _2019HR603.Controllers
{
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly _2019HR603Context _contexto;

        public equiposController(_2019HR603Context miContexto){
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/equipos")]
        public IActionResult Get(){
            var equiposList = _contexto.equipos;
            //if(equiposList.count>0){
                return Ok(equiposList);
            //}
            //return NotFound();
        }
    }
}