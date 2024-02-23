using FN.Store.Domain.Entities;
using System.Collections.Generic;

namespace FN.Store.Domain.Contracts
{
    public interface IClienteRepository:IRepository<Cliente>
    {
        IEnumerable<Cliente> GetByName(string name);
        IEnumerable<Cliente> GetById(int Id);
    }
}
