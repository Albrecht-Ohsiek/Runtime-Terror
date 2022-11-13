using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Terror
{
    internal class Person
    {
        private int stdNumber;
        private string name, surname, gender;
        private string dob;
        private int phone;
        private string address;
        private List<Module> moduleCodes = new List<Module>(); // list requires: code, name, description and resources(as a list).

        public int StdNumber { get => stdNumber; set => stdNumber = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Dob { get => dob; set => dob = value; }
        public int Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public List<Module> ModuleCodes { get => moduleCodes; set => moduleCodes = value; }

        public Person(int stdNumber, string name, string surname, string gender, string dob, int phone, string address, List<Module> moduleCodes)
        {
            this.StdNumber = stdNumber;
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Dob = dob;
            this.Phone = phone;
            this.Address = address;
            this.ModuleCodes = moduleCodes;
        }
    }
}
