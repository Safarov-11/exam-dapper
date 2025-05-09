using System.Data;
using Npgsql;

namespace Infrastructure.Data;

public class DataContext
{
    private const string connectionString = "Host = localhost; database = school_db ; user id = postgres; password = sr000080864";
    public IDbConnection GetDbConnection(){
        return new NpgsqlConnection(connectionString);
    }
}
