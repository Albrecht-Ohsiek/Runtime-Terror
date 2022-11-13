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

        public void StoreInformation()
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

        public void Display()
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


    }


}
