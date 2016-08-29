using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;
using System.Data;

public partial class Search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        using (OracleConnection connection = new OracleConnection())
        {
            connection.ConnectionString = "Data Source=XE;User Id=system;Password=system;";
            connection.Open();
            OracleCommand command = connection.CreateCommand();
            command.Connection = connection;
            command.CommandText = "USP_GETSELECTIVEDONORS";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("BloodGroup", OracleDbType.Varchar2).Value = DropDownList1.SelectedValue;
            command.Parameters.Add("DonorsData", OracleDbType.RefCursor, 100).Direction = ParameterDirection.Output;
            OracleDataAdapter oAdapter = new OracleDataAdapter(command);
            DataTable dtCursor = new DataTable();
            oAdapter.Fill(dtCursor);
            gvSelectiveDonors.DataSource = dtCursor;
            gvSelectiveDonors.DataBind();
            //command.Dispose();
            //connection.Dispose();
            connection.Close();
            Chart1.DataSource = dtCursor;
            Chart1.Visible = true;
            Chart1.DataBind();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        using (OracleConnection connection = new OracleConnection())
        {
            connection.ConnectionString = "Data Source=XE;User Id=system;Password=system;";
            connection.Open();
            OracleCommand command = connection.CreateCommand();
            command.Connection = connection;
            command.CommandText = "USP_GETAvailability";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("BloodGroup", OracleDbType.Varchar2).Value = DropDownList1.SelectedValue;
            command.Parameters.Add("DonorsData", OracleDbType.Int16).Direction = ParameterDirection.Output;
            OracleDataAdapter oAdapter = new OracleDataAdapter(command);
            DataTable dtCursor = new DataTable();
            oAdapter.Fill(dtCursor);
            gvSelectiveDonors.DataSource = dtCursor;
            gvSelectiveDonors.DataBind();
            //command.Dispose();
            //connection.Dispose();
            connection.Close();
            Chart1.DataSource = dtCursor;
            Chart1.Visible = true;
            Chart1.DataBind();
        }
    }
}