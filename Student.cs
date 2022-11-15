using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Terror
{
    internal class Student
    {
        private int stdNumber;
        private string name;
        private string surname;
        private string dob;
        private string gender;
        private int phone;
        private string email;
        private string moduleCodes;

        public int StdNumber { get => stdNumber; set => stdNumber = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Dob { get => dob; set => dob = value; }
        public int Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string ModuleCodes { get => moduleCodes; set => moduleCodes = value; }

        public Student(int stdNumber, string name, string surname, string gender, string dob, int phone, string email, string moduleCodes)
        {
            this.StdNumber = stdNumber;
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Dob = dob;
            this.Phone = phone;
            this.Email = email;
            this.ModuleCodes = moduleCodes;
        }
    }
}
