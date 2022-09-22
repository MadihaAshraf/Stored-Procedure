using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stored_Procedure
{
    public partial class EmployeeForm : System.Web.UI.Page
    {
        DbCon dbCon = new DbCon();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = dbCon.UDI(storedProcedure: "dbo.Employees_Insert");

                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = int.Parse(TBId.Text);
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = TBFName.Text;
                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = TBLName.Text;
                sqlCommand.Parameters.Add("@DateOfBirth", SqlDbType.VarChar).Value = TBDob.Text;
                sqlCommand.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = TBPhone.Text;
                sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = TBEmail.Text;
                sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = TBGender.Text;

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    LInfo.Text = "Data Inserted!";
                }
                else
                {
                    LInfo.Text = "Failed to Insert data!";
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dbCon.ConnectionClose();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = dbCon.UDI(storedProcedure: "dbo.Employees_Update");

                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = int.Parse(TBId.Text);
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = TBFName.Text;
                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = TBLName.Text;
                sqlCommand.Parameters.Add("@DateOfBirth", SqlDbType.VarChar).Value = TBDob.Text;
                sqlCommand.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = TBPhone.Text;
                sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = TBEmail.Text;
                sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = TBGender.Text;

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    LInfo.Text = "Data Updated!";
                }
                else
                {
                    LInfo.Text = "Failed to Update data!";
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dbCon.ConnectionClose();
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = dbCon.UDI(storedProcedure: "dbo.Employees_Delete");

                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = int.Parse(TBId.Text);

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    LInfo.Text = "Data Deleted!";
                }
                else
                {
                    LInfo.Text = "Failed to Delete data!";
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dbCon.ConnectionClose();
            }


        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = dbCon.UDI(storedProcedure: "dbo.Employees_Search");

                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = int.Parse(TBId.Text);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        TBId.Text = (sqlDataReader["EmployeeId"].ToString());
                        TBFName.Text = (sqlDataReader["FirstName"].ToString());
                        TBLName.Text = (sqlDataReader["LastName"].ToString());
                        TBDob.Text = (sqlDataReader["DateOfBirth"].ToString());
                        TBPhone.Text = (sqlDataReader["Phone"].ToString());
                        TBEmail.Text = (sqlDataReader["Email"].ToString());
                        TBGender.Text = (sqlDataReader["Gender"].ToString());
                        LInfo.Text = "Data Found!";
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dbCon.ConnectionClose();
            }

        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            TBLName.Text = "";
            TBFName.Text = "";
            TBId.Text = "";
            TBGender.Text = "";
            TBDob.Text = "";
            TBPhone.Text = "";
            TBEmail.Text = "";
        }

        protected void TBId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}