using FN.Store.Domain.Contracts;
using FN.Store.Domain.Entities;
using System.Linq;

namespace FN.Store.Data.EF.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public Usuario GetByEmail(string email)
        {
            return _ctx.Usuarios.FirstOrDefault(u => u.Email == email);
        }
    }
}
