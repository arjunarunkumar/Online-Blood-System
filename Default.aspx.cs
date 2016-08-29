using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Oracle.DataAccess.Client;
//using Oracle.DataAccess.Types;
using System.Data.OracleClient;

public partial class _Default : System.Web.UI.Page
{
    string connString = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        connString = "Data Source=XE;User ID=system;Password=system;Unicode=True";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OracleConnection connection = new OracleConnection();
        connection.ConnectionString = "Data Source=XE;User ID=system;Password=system;Unicode=True";
        connection.Open();

        OracleCommand command = connection.CreateCommand();
        command.Connection = connection;
        command.CommandText = "select * from employees";
        command.CommandType = System.Data.CommandType.Text;
        GridView1.DataSource = command.ExecuteReader();
        GridView1.DataBind();
        //using (OracleConnection connection = new OracleConnection())
        //{
        //    connection.ConnectionString = connString;
        //    connection.Open();
        //    Console.WriteLine("State: {0}", connection.State);
        //    Console.WriteLine("ConnectionString: {0}",
        //                      connection.ConnectionString);

        //    OracleCommand command = connection.CreateCommand();
        //    string sql = "SELECT * FROM bloodtypes";
        //    command.CommandText = sql;

        //    OracleDataReader reader = command.ExecuteReader();
        //    dataGridView1.DataSource = reader;//command.ExecuteScalar();
        //    while (reader.Read())
        //    {
        //        string myField = (string)reader["MYFIELD"];
        //        Console.WriteLine(myField);
        //    }
        //}
    }
}
