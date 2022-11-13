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
                LoginAuth loginAuth = new LoginAuth();
                if(loginAuth.passCheck(textBox_Username.Text, textBox_Password.Text))
                {
                    MessageBox.Show("LOGIN SUCCESSFUL");

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
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            Register newResgistration = new Register();
            newResgistration.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
