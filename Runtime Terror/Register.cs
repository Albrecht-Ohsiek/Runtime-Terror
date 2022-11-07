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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        string fileName = @"users.txt";
        private void button_Register_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (textBox_Username.Text == "" || textBox_Password.Text == "" || textBox_PasswordConfirm.Text == "")
                {
                    MessageBox.Show("Please fill in all boxes.");
                }
                else if(textBox_Password.Text != textBox_PasswordConfirm.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                }
                else
                {
                    List<string> newUser = new List<string>();
                    User user = new User();
                    
                    newUser.Add(user.Username = textBox_Username.Text);
                    newUser.Add(user.Password = textBox_Password.Text);
                    
                    FileHandler.writeToFile(fileName, newUser);

                    // TODO: check if user already exists.

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
