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
                string dob = dateTimePickerDOB.Value.ToString("yyyy-MM-dd");
                Student newStudent = new Student(int.Parse(textBoxStudentID.Text), textBoxName.Text, textBoxLastName.Text, comboBoxGender.Text, dob, int.Parse(textBoxPhoneNum.Text), textBoxEmail.Text, textBoxModule.Text);
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
            DataHandler handler = new DataHandler();
            DataTable dt = handler.Display();
            dgvDisplay.DataSource = dt;
        }
    }
}
