using datos.common;
using datos.interfaces;
using datos.modelo;
using Microsoft.EntityFrameworkCore;

namespace datos.implementaciones
{
    public class UsuarioData: IUsuarioData
    {
        private IRepository<TblUsuario> tblUsuarioRepository;
        public UsuarioData(IRepository<TblUsuario> TblUsuarioRepository)
        {
            tblUsuarioRepository = TblUsuarioRepository ?? throw new ArgumentNullException(nameof(TblUsuarioRepository));
        }

        public async Task<TblUsuario?> login(string username, string password)
        {
            return await tblUsuarioRepository.AsQueryable().Where(x=>x.Correo == username&&x.Password==password).FirstOrDefaultAsync();
        }

        public async Task<TblUsuario> register(TblUsuario usuario)
        {
            return await tblUsuarioRepository.CreateAsync(usuario);
        }
        public async Task<bool> getMyEmail(string usuario)
        {
            return await tblUsuarioRepository.AsQueryable().Where(x=> x.Correo == usuario).AnyAsync();
        }
    }
}
