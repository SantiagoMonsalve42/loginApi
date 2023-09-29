using datos.modelo;

namespace datos.interfaces
{
    public interface IUsuarioData
    {
        Task<TblUsuario?> login(string username, string password);
        Task<TblUsuario> register(TblUsuario usuario);
        Task<bool> getMyEmail(string usuario);
    }
}
