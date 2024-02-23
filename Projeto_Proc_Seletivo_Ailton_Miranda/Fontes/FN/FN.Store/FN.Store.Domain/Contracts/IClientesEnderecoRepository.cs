using FN.Store.Domain.Entities;
using System.Collections.Generic;

namespace FN.Store.Domain.Contracts
{
    /*public interface IClientesEnderecoRepository : IRepository<ClientesEndereco>
    {

    }*/

    public interface IClientesEnderecoRepository : IRepository<ClientesEndereco>
    {
        IEnumerable<ClientesEndereco> GetByName(string name);
        IEnumerable<ClientesEndereco> GetById(int id);
        List<ClientesEndereco> GetByClientId(int id);

    }
}