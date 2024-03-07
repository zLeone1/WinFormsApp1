using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
     class estudient : Person
    {
        private string schoolid;
        public string ID
        {
            get { return schoolid; }
            set { schoolid = value; }
        }
        private string career;

        public string Career
        {
            get { return career; }
            set { career = value; }
        }

        private int grade;
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public estudient(NamePerson namePerson,DateTimePicker birthdate, string schoolid, string career, int grade ) : base(namePerson, birthdate)
        {
            this.schoolid = schoolid;
            
            this.career = career;
            
            this.grade = grade;
            
        }
    }
}
