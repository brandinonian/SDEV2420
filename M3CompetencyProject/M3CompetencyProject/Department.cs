using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3CompetencyProject
{
    public class Department
    {
        public string DeptName { get; set; }

        public string Abbreviation { get; set; }

        public Department(string DeptName, string Abbreviation)
        {
            this.DeptName = DeptName;
            this.Abbreviation = Abbreviation;
        }
    }
}
