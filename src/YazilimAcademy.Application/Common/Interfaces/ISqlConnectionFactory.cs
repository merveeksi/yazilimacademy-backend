using System.Data;

namespace YazilimAcademy.Application.Common.Interfaces;

public interface ISqlConnectionFactory
{
    IDbConnection CreateConnection();
}
