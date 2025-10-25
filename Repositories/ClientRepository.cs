using InventoryApp.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace InventoryApp.Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public IEnumerable<Client> GetAll(string? filtro = null)
        {
            var list = new List<Client>();
            using var conn = DbConnectionFactory.Instance.CreateOpen();

            var sql = "SELECT id, nombre, nit, creado_en FROM cliente";
            if (!string.IsNullOrWhiteSpace(filtro))
                sql += " WHERE nombre LIKE @filtro OR nit LIKE @filtro";

            using var cmd = new MySqlCommand(sql, conn);

            if (!string.IsNullOrWhiteSpace(filtro))
                cmd.Parameters.AddWithValue("@filtro", $"%{filtro}%");

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Client
                {
                    Id = reader.GetInt32("id"),
                    Nombre = reader.GetString("nombre"),
                    Nit = reader.GetString("nit"),
                    CreadoEn = reader.GetDateTime("creado_en")
                });
            }
            return list;
        }

        public void Add(Client c)
        {
            using var conn = DbConnectionFactory.Instance.CreateOpen();
            string sql = @"INSERT INTO cliente(nombre, nit) 
                           VALUES(@nombre, @nit)";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nombre", c.Nombre);
            cmd.Parameters.AddWithValue("@nit", c.Nit);
            cmd.ExecuteNonQuery();
        }

        public void Update(Client c)
        {
            using var conn = DbConnectionFactory.Instance.CreateOpen();
            string sql = @"UPDATE cliente SET nombre=@nombre, nit=@nit
                           WHERE id=@id";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@nombre", c.Nombre);
            cmd.Parameters.AddWithValue("@nit", c.Nit);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = DbConnectionFactory.Instance.CreateOpen();
            string sql = "DELETE FROM cliente WHERE id=@id";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public Client? GetById(int id)
        {
            using var conn = DbConnectionFactory.Instance.CreateOpen();
            var sql = "SELECT id, nombre, nit, creado_en FROM cliente WHERE id=@id";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Client
                {
                    Id = reader.GetInt32("id"),
                    Nombre = reader.GetString("nombre"),
                    Nit = reader.GetString("nit"),
                    CreadoEn = reader.GetDateTime("creado_en")
                };
            }
            return null;
        }

        public async Task UpdateAsync(Client client)
        {
            using var conn = DbConnectionFactory.CreateConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Clients SET FullName=@FullName, Email=@Email, Phone=@Phone, Address=@Address WHERE Id=@Id";
            cmd.Parameters.Add(new SqlParameter("@FullName", client.FullName));
            cmd.Parameters.Add(new SqlParameter("@Email", client.Email));
            cmd.Parameters.Add(new SqlParameter("@Phone", client.Phone));
            cmd.Parameters.Add(new SqlParameter("@Address", client.Address));
            cmd.Parameters.Add(new SqlParameter("@Id", client.Id));
            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }
    }
}
