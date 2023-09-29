using Contabilidad_api.Controllers;
using datos.modelo;
using Microsoft.AspNetCore.Mvc;
using negocio.Interfaces;

namespace loginApi.Controllers
{
    public class UsuarioController: BaseController
    {
        public IUsuarioNegocio usuarioNegocio;
        public UsuarioController(IUsuarioNegocio UsuarioNegocio) { 
            usuarioNegocio = UsuarioNegocio;
        }

        [HttpPost]
        public async Task<IActionResult> login(string username, string password)
        {
            var existe = await usuarioNegocio.login(username, password);
            return Ok(existe);
        }
        [HttpPost]
        public async Task<IActionResult> registro([FromBody]TblUsuario USER)
        {
            return Ok(await usuarioNegocio.registro(USER));
        }
    }
}
