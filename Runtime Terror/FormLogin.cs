using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runtime_Terror
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            try 
            { 
                if(LoginAuth.passCheck(textBox_Username.Text, textBox_Password.Text) == true)
                {
                    MessageBox.Show("LOGIN SUCCESSFUL");
                    textBox_Username.Clear();
                    textBox_Password.Clear();

                    FormDataCapture formDataCapture = new FormDataCapture();
                    formDataCapture.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("USERNAME OR PASSWORD INCORRECT");
                    textBox_Username.Clear();
                    textBox_Password.Clear();
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            finally 
            { 

            }
        }

        private void button_Register_Click(object sender, EventArgs e)
        {

        }
    }
}
