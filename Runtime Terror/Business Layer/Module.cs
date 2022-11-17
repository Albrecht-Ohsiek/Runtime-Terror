using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Terror
{
    internal class Module
    {
        private string code;
        private string name;
        private string description;
        private string resources;
        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Resources { get => resources; set => resources = value; }

        public Module(string code, string name, string description, string resources)
        {
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.Resources = resources;
        }
    }
}
