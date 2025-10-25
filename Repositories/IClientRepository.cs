using InventoryApp.Domain;
using System.Collections.Generic;

namespace InventoryApp.Infrastructure.Repositories
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAll(string? filtro = null);
        void Add(Client client);
        void Update(Client client);
        void Delete(int id);
        Client? GetById(int id);
    }
}
