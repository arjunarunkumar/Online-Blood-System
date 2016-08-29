using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;
using System.Data;

public partial class ExistingDonors : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        using (OracleConnection connection = new OracleConnection())
        {
            connection.ConnectionString = "Data Source=XE;User Id=system;Password=system;";//"Data Source=XE;User ID=system;Password=system;Unicode=True";
            connection.Open();
            OracleCommand command = connection.CreateCommand();
            command.Connection = connection;
            command.CommandText = "USP_getDonorInfo";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("TableData", OracleDbType.RefCursor, 100).Direction = ParameterDirection.Output;
            OracleDataAdapter oAdapter = new OracleDataAdapter(command);
            DataTable dtCursor = new DataTable();
            oAdapter.Fill(dtCursor);
            gvDonors.DataSource = dtCursor;
            gvDonors.DataBind();
            //command.Dispose();
            //connection.Dispose();
            connection.Close();
        }
    }
}