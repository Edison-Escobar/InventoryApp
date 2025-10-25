using InventoryApp.Domain;
using InventoryApp.Infrastructure;
using MySql.Data.MySqlClient;
using System.Data;

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

        public async Task<int> InsertAsync(Product p)
        {
            using var conn = DbConnectionFactory.Instance.CreateOpen();
            using var cmd = new MySqlCommand(
                @"INSERT INTO producto (nombre, precio, stock)
                  VALUES (@n, @pr, @st);
                  SELECT LAST_INSERT_ID();", conn);

            cmd.Parameters.AddWithValue("@n", p.Nombre);
            cmd.Parameters.AddWithValue("@pr", p.Precio);
            cmd.Parameters.AddWithValue("@st", p.Stock);

            var id = Convert.ToInt32(await cmd.ExecuteScalarAsync());
            return id;
        }

        public async Task<bool> UpdateAsync(Product p)
        {
            using var conn = DbConnectionFactory.Instance.CreateOpen();
            using var cmd = new MySqlCommand(
                @"UPDATE producto
                  SET nombre=@n, precio=@pr, stock=@st
                  WHERE id=@id;", conn);

            cmd.Parameters.AddWithValue("@id", p.Id);
            cmd.Parameters.AddWithValue("@n", p.Nombre);
            cmd.Parameters.AddWithValue("@pr", p.Precio);
            cmd.Parameters.AddWithValue("@st", p.Stock);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using var conn = DbConnectionFactory.Instance.CreateOpen();
            using var cmd = new MySqlCommand(
                "DELETE FROM producto WHERE id=@id;", conn);

            cmd.Parameters.AddWithValue("@id", id);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }
    }
}
