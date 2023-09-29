using datos.modelo;

namespace negocio.Interfaces
{
    public interface IUsuarioNegocio
    {
        Task<bool> login(string username, string password);
        Task<int> registro(TblUsuario user);
    }
}
