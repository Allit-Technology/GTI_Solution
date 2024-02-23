using FN.Store.Domain.Contracts;
using FN.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FN.Store.Data.EF.Repositories
{
    public class ClienteEnderecoRepository : Repository<ClientesEndereco>, IClientesEnderecoRepository
    {
        public IEnumerable<ClientesEndereco> GetByName(string logradouro)
        {
            return
                _ctx.ClientesEndereco
                    .Where(c => c.Logradouro.ToLower().Contains(logradouro.ToLower()))
                    .ToList();
        }

        public IEnumerable<ClientesEndereco> GetById(int Id)
        {
            return
                _ctx.ClientesEndereco
                    .Where(c => c.ClienteId.ToString().Contains(Id.ToString()))
                    .ToList();
        }

        public List<ClientesEndereco> GetByClientId(int Id)
        {
            return
                _ctx.ClientesEndereco
                    .Where(c => c.ClienteId.ToString().Contains(Id.ToString()))
                    .ToList();
        }
    }
}
