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
        private List<string> resources = new List<string>(); // all resources(yt links) stored as a list.

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public List<string> Resources { get => resources; set => resources = value; }
        
        public Module(string code, string name, string description, List<string> resources)
        {
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.Resources = resources;
        }
    }
}
