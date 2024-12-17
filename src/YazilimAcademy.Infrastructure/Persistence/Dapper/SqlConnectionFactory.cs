using System;
using System.Data;
using Npgsql;
using YazilimAcademy.Application.Common.Interfaces;

namespace YazilimAcademy.Infrastructure.Persistence.Dapper;

public sealed class SqlConnectionFactory : ISqlConnectionFactory
{
    private readonly string _connectionString;

    public SqlConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IDbConnection CreateConnection()
    {
        var connection = new NpgsqlConnection(_connectionString);

        connection.Open();

        return connection;
    }
}
