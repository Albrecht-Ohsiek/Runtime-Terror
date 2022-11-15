using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace Runtime_Terror
{
    internal class DataHandler
    {
        private string connection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bin\Debug\RuntimeTerrorDB.mdf;Integrated Security = True";
        private SqlConnection myConnection;

        public DataHandler() { }

        private void openConnection()
        {
            myConnection = new SqlConnection(connection);
            myConnection.Open();

        }

        public void StoreInformation(Student student)
        {
            openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("AddStudent", myConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentId", SqlDbType.Int).Value = student.StdNumber;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = student.Name;
                cmd.Parameters.AddWithValue("@Surname", SqlDbType.VarChar).Value = student.Surname;
                cmd.Parameters.AddWithValue("@DOB", SqlDbType.VarChar).Value = student.Dob;
                cmd.Parameters.AddWithValue("@Gender", SqlDbType.VarChar).Value = student.Gender;
                cmd.Parameters.AddWithValue("@Phone", SqlDbType.Int).Value = student.Phone;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = student.Email;
                cmd.Parameters.AddWithValue("@ModuleCodes", SqlDbType.VarChar).Value = student.ModuleCodes;


                cmd.ExecuteNonQuery();
                MessageBox.Show("Student added successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myConnection.Close();
            }

        }

        public void Search()
        {
            openConnection();

            try
            {

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myConnection.Close();

            }
        }

        public void Update()
        {
            openConnection();

            try
            {

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myConnection.Close();
            }


        }

        public void Delete()
        {
            openConnection();
            try
            {

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myConnection.Close();
            }

        }

        public DataTable Display()
        {
            openConnection();

            string query = "SELECT * FROM Student";
            SqlCommand cmd = new SqlCommand(query, myConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            myConnection.Close();

            return dt;

        }

    }

}