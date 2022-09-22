using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class DbCon
{
    SqlConnection sqlConnection = null;

    public void ConnectionToDatabase()
    {
        string connection = "Data Source=DESKTOP-MCA5OE5;Initial Catalog=crud;Integrated Security=True";
        sqlConnection = new SqlConnection(connection);
        sqlConnection.Open();
    }

    public void ConnectionClose()
    {
        sqlConnection.Close();
    }

    public SqlCommand UDI(string storedProcedure)
    {
        try
        {
            ConnectionToDatabase();

            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            return sqlCommand;
        }
        catch (SqlException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}

