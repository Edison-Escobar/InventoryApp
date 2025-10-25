using InventoryApp.Domain;
using InventoryApp.Infrastructure;

namespace InventoryApp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public async Task<List<Product>> GetAllAsync()
        {
            var list = new List<Product>();

            using var conn = DbConnectionFactory.Instance.CreateOpen();
            using var cmd = new MySqlCommand(
                "SELECT id, nombre, precio, stock FROM producto ORDER BY id", conn);

            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                list.Add(new Product
                {
                    Id = reader.GetInt32("id"),
                    Nombre = reader.GetString("nombre"),
                    Precio = reader.GetDecimal("precio"),
                    Stock = reader.GetInt32("stock")
                });
            }
            return list;
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            using var conn = DbConnectionFactory.CreateConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Name, Price, Stock FROM Products WHERE Id = @Id";
            cmd.Parameters.Add(new SqlParameter("@Id", id));
            await conn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new Product
        {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Price = reader.GetDecimal(2),
                    Stock = reader.GetInt32(3)
                };
        }
            return null;
        }

        public async Task UpdateAsync(Product product)
        {
            // Implementar según necesidad
            await Task.CompletedTask;
        }
    }
}
