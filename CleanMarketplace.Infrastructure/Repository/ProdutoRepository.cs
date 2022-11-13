using CleanMarketplace.Application.Interfaces;
using CleanMarketplace.Core.Entities;
using CleanMarketplace.Sql.Queries;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using System.Data.SqlClient;

namespace CleanMarketplace.Infrastructure.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly IConfiguration configuration;

        public ProdutoRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task<IReadOnlyList<Produto>> GetAllAsync()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Produto>(ProdutoQueries.AllProduto);
                return result.ToList();
            }
        }

        public async Task<Produto> GetByIdAsync(long id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Produto>(ProdutoQueries.ProdutoById, new { ID_PRODUTO = id });
                return result;
            }
        }

        public async Task<string> AddAsync(Produto entity)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(ProdutoQueries.AddProduto, entity);
                return result.ToString();
            }
        }

        public async Task<string> UpdateAsync(Produto entity)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(ProdutoQueries.UpdateProduto, entity);
                return result.ToString();
            }
        }

        public async Task<string> DeleteAsync(long id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(ProdutoQueries.DeleteProduto, new { ID_PRODUTO = id });
                return result.ToString();
            }
        }

    }
}
