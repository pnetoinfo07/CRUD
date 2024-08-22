using CRUD.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace APICRUD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PauloController :ControllerBase
    {
        [HttpPost("enviar-email")]
        public void EnviarEmail()
        {
            
        }
        [HttpPut("editar-registro")]
        public void EditarRegistro()
        {
            
        }
    }
}
