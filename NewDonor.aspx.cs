using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Data.OracleClient;
using System.Data;
using Oracle.DataAccess.Client;

public partial class NewDonor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        using (OracleConnection connection = new OracleConnection())
        {
            connection.ConnectionString = "Data Source=XE;User Id=system;Password=system;";//"Data Source=XE;User ID=system;Password=system;Unicode=True";
            connection.Open();

            /*
            OracleCommand command = connection.CreateCommand();
            command.Connection = connection;
            command.CommandText = "newtest";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("name1", OracleDbType.Varchar2).Value = txtboxName.Text;*/

            OracleCommand command = connection.CreateCommand();
            command.Connection = connection;
            command.CommandText = "USP_NEWDONOR";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("name", OracleDbType.NVarchar2).Value = txtboxName.Text;
            command.Parameters.Add("age", OracleDbType.Int16).Value = Convert.ToInt16(txtboxAge.Text);
            command.Parameters.Add("sex", OracleDbType.Varchar2).Value = ctrlDropDownSex.SelectedValue;
            command.Parameters.Add("address", OracleDbType.NVarchar2).Value = txtboxAddr.Text;
            command.Parameters.Add("phnumber", OracleDbType.Int64).Value = Convert.ToInt64(txtboxPhNo.Text);
            command.Parameters.Add("bloodgroup", OracleDbType.NVarchar2).Value = txtboxBloodGrp.Text;
            if (command.ExecuteNonQuery() != 0)
            {
                lblTitle.Text += " successfully.";
            }
            else
            {
                lblTitle.Text += " failed.";
            }
            connection.Close();
        }
    }
}