using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program.Model.NordWindDB
{
    internal class Person
    {
        //test delete class

        internal int DepartmentNumber { get; set; }
        
        internal string? DeskLocation{ get; set; }
        
        internal int EmployeeNumber { get; set; }

        public string? FirstName { get; set; }
        
        public string? LastName { get; set; }

    }
}