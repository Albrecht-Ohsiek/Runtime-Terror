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
    public partial class FormDataCapture : Form
    {
        public FormDataCapture()
        {
            InitializeComponent();
        }

        private void FormDataCapture_Load(object sender, EventArgs e)
        {

        }

        private void FormDataCapture_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonStoreInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string dob = dateTimePickerStudentDOB.Value.ToString("yyyy-MM-dd");
                Student newStudent = new Student(int.Parse(textBoxStudentID.Text), textBoxStudentName.Text, textBoxStudentLastName.Text, comboBoxStudentGender.Text, dob, int.Parse(textBoxStudentPhoneNum.Text), textBoxStudentEmail.Text, textBoxStudentModule.Text);
                DataHandler addStudent = new DataHandler();
                addStudent.StoreInformation(newStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                DataHandler handler = new DataHandler();
                DataTable dt = handler.Display();
                dgvDisplay.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
