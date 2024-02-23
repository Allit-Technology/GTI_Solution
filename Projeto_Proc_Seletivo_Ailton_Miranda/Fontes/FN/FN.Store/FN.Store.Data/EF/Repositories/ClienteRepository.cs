using FN.Store.Domain.Contracts;
using FN.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FN.Store.Data.EF.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public IEnumerable<Cliente> GetByName(string name)
        {
            return 
                _ctx.Clientes
                    .Where(c=> c.Nome.ToLower().Contains(name.ToLower()))
                    .ToList();
        }

        public IEnumerable<Cliente> GetById(int Id)
        {
            return
                _ctx.Clientes
                    .Where(c => c.Id.ToString().Contains(Id.ToString()))
                    .ToList();
        }
    }
}
