using FN.Store.Domain.Entities;

namespace FN.Store.Domain.Contracts
{
    public interface IUsuarioRepository:IRepository<Usuario>
    {
        Usuario GetByEmail(string email);
    }
}
