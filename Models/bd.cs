using System.Data.SqlClient;
using Dapper;

public class bd
{
    private static string _connectionString = @"Server=localhost;DataBase=JJOO; Trusted_Connection=True;";
    public static void AgregarDeportista()
    {
        using(SqlConnection db = new SqlConnection(_connectionString) ){
            string sql = "Up ";
            db.Execute(sql, new{});
        }
    }
}
