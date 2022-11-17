using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        private void buttonStudentsViewAll_Click(object sender, EventArgs e) // Display all students.
        {
            try
            {
                string query = "SELECT * FROM Student";
                DataHandler handler = new DataHandler();
                DataTable dt = handler.Display(query);
                dgvDisplay.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void buttonMuduleViewAll_Click(object sender, EventArgs e) // Display all modules
        {
            try
            {
                string query = "SELECT * FROM Modules";
                DataHandler handler = new DataHandler();
                DataTable dt = handler.Display(query);
                dgvDisplay.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void buttonStoreInfo_Click(object sender, EventArgs e) // Student create.
        {
            try
            {
                if(textBoxStudentID.Text == "" || textBoxStudentName.Text == "" || textBoxStudentLastName.Text == "" || textBoxStudentPhoneNum.Text == "" || textBoxStudentEmail.Text == "" || textBoxStudentModule.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
                else
                {
                    string dob = dateTimePickerStudentDOB.Value.ToString("yyyy-MM-dd");
                    Student newStudent = new Student(int.Parse(textBoxStudentID.Text), textBoxStudentName.Text, textBoxStudentLastName.Text, comboBoxStudentGender.Text, dob, int.Parse(textBoxStudentPhoneNum.Text), textBoxStudentEmail.Text, textBoxStudentModule.Text);
                    DataHandler addStudent = new DataHandler();
                    addStudent.StoreInformation(newStudent);
                    
                    textBoxStudentID.Clear();
                    textBoxStudentName.Clear();
                    textBoxStudentLastName.Clear();
                    textBoxStudentPhoneNum.Clear();
                    comboBoxStudentGender.Text = "";
                    textBoxStudentEmail.Clear();
                    textBoxStudentModule.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonModuleStoreInfo_Click(object sender, EventArgs e) // Module Create.
        {
            try
            {
                if (textBoxModuleId.Text == "" || textBoxModuleName.Text == "" || textBoxDesc.Text == "" || textBoxLink.Text == "")
                {
                    MessageBox.Show("Please fill in all fields.");
                }
                else
                {
                    string dob = dateTimePickerStudentDOB.Value.ToString("yyyy-MM-dd");
                    Module newModule = new Module(textBoxModuleId.Text, textBoxModuleName.Text, textBoxDesc.Text, textBoxLink.Text);
                    DataHandler addModule = new DataHandler();
                    addModule.StoreInformation(newModule);
                    
                    textBoxModuleId.Clear();
                    textBoxModuleName.Clear();
                    textBoxDesc.Clear();
                    textBoxLink.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void buttonModuleUpdate_Click(object sender, EventArgs e) // Module Update
        {
            if (textBoxModuleSearch.Text == "")
            {
                MessageBox.Show("Please enter a module code to search for.");
            }
            else
            {
                string moduleCode = textBoxModuleSearch.Text;
                DataHandler updateModule = new DataHandler();
                if (updateModule.EntryExists(moduleCode, "Modules"))
                {
                    string dob = dateTimePickerStudentDOB.Value.ToString("yyyy-MM-dd");
                    Module newModule = new Module(textBoxModuleId.Text, textBoxModuleName.Text, textBoxDesc.Text, textBoxLink.Text);
                    updateModule.Update(newModule);

                    textBoxModuleId.Clear();
                    textBoxModuleName.Clear();
                    textBoxDesc.Clear();
                    textBoxLink.Clear();
                }
                else
                {
                    MessageBox.Show("Module does not exist.");
                }
            }
        }

        private void buttonModuleDelete_Click(object sender, EventArgs e) // Module Delete
        {
            if (textBoxModuleSearch.Text == "")
            {
                MessageBox.Show("Please enter a module code to search for.");
            }
            else
            {
                string moduleCode = textBoxModuleSearch.Text;
                DataHandler deleteModule = new DataHandler();
                if(deleteModule.EntryExists(moduleCode, "Modules"))
                {
                    deleteModule.Delete(moduleCode);
                    
                    textBoxModuleId.Clear();
                    textBoxModuleName.Clear();
                    textBoxDesc.Clear();
                    textBoxLink.Clear();
                }
                else
                {
                    MessageBox.Show("Module does not exist.");
                }
                
            }
        }


        private void buttonStudentSearch_Click(object sender, EventArgs e)
        {
            string studentID = textBoxSearchStudent.Text;
            DataHandler searchStudent = new DataHandler();
            
            if (searchStudent.EntryExists(studentID, "Student"))
            {
                DataTable dt = searchStudent.Search(studentID);
                dgvDisplay.DataSource = dt;

                textBoxStudentID.Text = dt.Rows[0][0].ToString();
                textBoxStudentName.Text = dt.Rows[0][1].ToString();
                textBoxStudentLastName.Text = dt.Rows[0][2].ToString();
                dateTimePickerStudentDOB.Text = dt.Rows[0][3].ToString();
                textBoxStudentPhoneNum.Text = dt.Rows[0][5].ToString();
                comboBoxStudentGender.Text = dt.Rows[0][4].ToString();
                textBoxStudentEmail.Text = dt.Rows[0][6].ToString();
                textBoxStudentModule.Text = dt.Rows[0][7].ToString();
            }
            else
            {
                MessageBox.Show("Student does not exist.");
            }

        }

        private void buttonModuleSearch_Click(object sender, EventArgs e)
        {
            string ModuleID = textBoxModuleSearch.Text;
            DataHandler searchModule = new DataHandler();
            
            if (searchModule.EntryExists(ModuleID, "Modules"))
            {
                DataTable dt = searchModule.searchModule(ModuleID);
                dgvDisplay.DataSource = dt;
                
                textBoxModuleId.Text = dt.Rows[0][0].ToString();
                textBoxModuleName.Text = dt.Rows[0][1].ToString();
                textBoxDesc.Text = dt.Rows[0][2].ToString();
                textBoxLink.Text = dt.Rows[0][3].ToString();
            }
            else
            {
                MessageBox.Show("Module does not exist.");
            }
        }

        private void buttonStudentUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxSearchStudent.Text == "")
            {
                MessageBox.Show("Please enter a Student ID to search for.");
            }
            else
            {
                int studentID = int.Parse(textBoxSearchStudent.Text);
                DataHandler deleteStudent = new DataHandler();
                if (deleteStudent.EntryExists(studentID.ToString(), "Student"))
                {
                    string dob = dateTimePickerStudentDOB.Value.ToString("yyyy-MM-dd");
                    Student student = new Student(int.Parse(textBoxStudentID.Text), textBoxStudentName.Text, textBoxStudentLastName.Text, comboBoxStudentGender.Text, dob, int.Parse(textBoxStudentPhoneNum.Text), textBoxStudentEmail.Text, textBoxStudentModule.Text);
                    deleteStudent.UpdateStudent(student);

                    textBoxStudentID.Clear();
                    textBoxStudentName.Clear();
                    textBoxStudentLastName.Clear();
                    textBoxStudentPhoneNum.Clear();
                    comboBoxStudentGender.Text = "";
                    textBoxStudentEmail.Clear();
                    textBoxStudentModule.Clear();
                }
                else
                {
                    MessageBox.Show("Module does not exist.");
                }
            }
        }

        private void buttonStudentDelete_Click(object sender, EventArgs e)
        {
            if (textBoxSearchStudent.Text == "")
            {
                MessageBox.Show("Please enter a Student ID to search for.");
            }
            else
            {
                int studentID = int.Parse(textBoxSearchStudent.Text);
                DataHandler deleteStudent = new DataHandler();
                if(deleteStudent.EntryExists(studentID.ToString(), "Student"))
                {
                    Student student = new Student();
                    student.StdNumber = studentID;
                    deleteStudent.DeleteStudent(student);

                    textBoxStudentID.Clear();
                    textBoxStudentName.Clear();
                    textBoxStudentLastName.Clear();
                    textBoxStudentPhoneNum.Clear();
                    comboBoxStudentGender.Text = "";
                    textBoxStudentEmail.Clear();
                    textBoxStudentModule.Clear();
                }
                else
                {
                    MessageBox.Show("Student does not exist.");
                }
                
            }
        }
    }
}
