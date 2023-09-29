using datos.implementaciones;
using datos.interfaces;
using datos.modelo;
using negocio.Interfaces;

namespace negocio.Implementaciones
{
    public class UsuarioNegocio: IUsuarioNegocio
    {
        public IUsuarioData usuarioData;
        public UsuarioNegocio(IUsuarioData UsuarioData)
        {
            usuarioData = UsuarioData ?? throw new ArgumentNullException(nameof(UsuarioData));
        }

        public async Task<bool> login(string username, string password)
        {
            var login=await usuarioData.login(username, password);
            return login != null;
        }

        public async Task<int> registro(TblUsuario user)
        {
            int estado = 3;
            if (!await usuarioData.getMyEmail(user.Correo))
            {
                var registro = await usuarioData.register(user);
                if (registro != null)
                {
                    estado = 1;
                }
                else
                {
                    estado = 2;
                }
            }
            else
            {
                estado = 3;
            }
            
            return estado;
        }
    }
}
